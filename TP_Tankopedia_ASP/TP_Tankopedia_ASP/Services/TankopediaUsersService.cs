using Microsoft.AspNetCore.Identity;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;
using TP_Tankopedia_ASP.Utility;

namespace TP_Tankopedia_ASP.Services
{
    public class TankopediaUsersService : ITankopediaUsersService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly TankopediaDbContext _dbContext;
        public TankopediaUsersService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager , TankopediaDbContext dbContext)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._dbContext = dbContext;
        }

        public async Task AssignRolesToUser(string email, string role)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.Email == email);
            _userManager.AddToRoleAsync(user, role)
                .GetAwaiter().GetResult();
        }
    }

}
