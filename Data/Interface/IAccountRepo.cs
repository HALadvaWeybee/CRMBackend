using CRMBackend.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CRMBackend.Data.Interface
{
    public interface IAccountRepo
    {
        Task<IdentityResult> SignUpAsync(SignUpModel model);
        Task<UserViewModel> LoginAsync(SignInModel model);
        Task LogOut();
        Task<UserViewModel> MyAccountAsync(Claim claims);
        //Task<List<string>> GetAllCountryStateAndCity();
    }
}
