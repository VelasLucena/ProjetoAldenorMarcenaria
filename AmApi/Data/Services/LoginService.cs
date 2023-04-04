using AmApi.Models;
using AmApi.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace AmApi.Data.Services
{
    public class LoginService : ILoginService
    {
        private readonly SignInManager<UserModel> _signInManager;
        private readonly UserManager<UserModel> _userManager;

        public LoginService(SignInManager<UserModel> signInManager, UserManager<UserModel> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(email, password, false, false);

            return result.Succeeded;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<bool> RegisterUser(string email, string password)
        {
            UserModel createUser = new UserModel
            {
                UserName = email,
                Email = email
            };

            IdentityResult result = await _userManager.CreateAsync(createUser, password);

            if (result.Succeeded)
                await _signInManager.SignInAsync(createUser, false);

            return result.Succeeded;
        }
    }
}
