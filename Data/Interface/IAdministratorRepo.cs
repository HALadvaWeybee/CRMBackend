using CRMBackend.Models;
using WebsiteCMS.DAL.Models;

namespace WebsiteCMS.DAL.Data.Interface
{
    public interface IAdministratorRepo
    {
        Task<ApplicationUser> AssignRole(ViewRoleModel model);

        Task AddRoleAsync(string roleModel);
    }
}
