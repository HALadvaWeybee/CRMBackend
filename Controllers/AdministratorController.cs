﻿using CRMBackend.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebsiteCMS.DAL.Data.Interface;
using WebsiteCMS.DAL.Models;

namespace WebsiteCMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class AdministratorController : ControllerBase
    {
        private readonly IAdministratorRepo _administratorRepo;
        AuthResponse response = new AuthResponse();

        public AdministratorController(IAdministratorRepo administratorRepo)
        {
            _administratorRepo = administratorRepo;
        }

        [HttpPost("Addrole")]
        public async Task<IActionResult> AddRole([FromBody] string role)
        {
            await _administratorRepo.AddRoleAsync(role);
            response.Success = true;
            response.Message = "Role Added";
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost("Assignrole")]
        public async Task<IActionResult> AssignRole([FromBody] ViewRoleModel model)
        {
            var result = await _administratorRepo.AssignRole(model);

            if (result == null)
            {
                response.Success = false;
                response.error.errorMessage = "Username Is Not Availavle In Database";
                return StatusCode(StatusCodes.Status404NotFound, response);
            }
            response.Success = true;
            response.Message = "Role Assigned";
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
