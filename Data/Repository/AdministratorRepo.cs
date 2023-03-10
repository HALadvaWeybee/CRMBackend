using CRMBackend.Data.Models;
using CRMBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteCMS.DAL.Data.Interface;
using WebsiteCMS.DAL.Models;

namespace WebsiteCMS.DAL.Data.Repositories
{
    public class AdministratorRepo : IAdministratorRepo
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly CRMbackendContext _dbContext;

        public AdministratorRepo(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, CRMbackendContext dbContext)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task AddRoleAsync(string role)
        {
            IdentityRole identityRole = new IdentityRole
            {
                Name = role
            };
            await _roleManager.CreateAsync(identityRole);
        }

        public async Task<ApplicationUser> AssignRole(ViewRoleModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return user;
            }
            else
            {
                await _userManager.UpdateAsync(user);
                await _userManager.AddToRoleAsync(user, model.Role);
            }
            return user;
        }
    }
}
