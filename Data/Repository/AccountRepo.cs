using CRMBackend.Data.Interface;
using CRMBackend.Data.Models;
using CRMBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRMBackend.Data.Repository
{
    public class AccountRepo : IAccountRepo
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly CRMbackendContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtBearerTokenSettings _jwtBearerTokenSettings;

        public AccountRepo(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration, IOptions<JwtBearerTokenSettings> jwtTokenOptions, CRMbackendContext context, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _context = context;
            _roleManager = roleManager;
            _jwtBearerTokenSettings = jwtTokenOptions.Value;
        }
        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var userData = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email!.Split("@")[0],
            };
            var result = await _userManager.CreateAsync(userData, model.Password);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(userData.Email);
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result;
        }

        public async Task<UserViewModel> LoginAsync(SignInModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            UserViewModel userDetails = new();

            if (!result.Succeeded)
            {
                return null;
            }
            var user = await _userManager.FindByNameAsync(model.Email);
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Email),
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JwtBearerTokenSettings:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtBearerTokenSettings:Issuer"],
                audience: _configuration["JwtBearerTokenSettings:Audience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );


            userDetails.Token = new JwtSecurityTokenHandler().WriteToken(token);
            userDetails.Id = user.Id;
            userDetails.FirstName = user?.FirstName ?? string.Empty;
            userDetails.LastName = user?.LastName ?? string.Empty;
            userDetails.UserName = user?.UserName ?? string.Empty;
            userDetails.Role = userRoles.ToList();
            userDetails.Email = user?.Email ?? string.Empty;
            userDetails.SessionExpriryTime = _jwtBearerTokenSettings.ExpiryTimeInSeconds / 60;
            return userDetails;
        }

        public async Task<UserViewModel> MyAccountAsync(Claim claims)
        {
            string email = claims!.Value!.ToString();
            var data = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            var roles = await _context.UserRoles.Join(_roleManager.Roles, x => x.RoleId, y => y.Id, (x, y) => new { Id = x.UserId, Name = y.Name }).ToListAsync();
            var UserRoles = roles!.Where(x => x.Id == data!.Id).Select(x => x.Name).ToList();

            var userData = new UserViewModel()
            {
                Id = data!.Id,
                FirstName = data!.FirstName!,
                LastName = data!.LastName!,
                UserName = data!.UserName!,
                Email = data!.Email!,
                Role = UserRoles!
            };

            return userData!;
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
