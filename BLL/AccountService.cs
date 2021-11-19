using Microsoft.AspNetCore.Identity;
using WebApplication.Authentication;

namespace BLL
{
    public class AccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
    }
}