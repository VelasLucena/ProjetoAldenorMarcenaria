using AmApi.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmApi.Controllers
{
    [ApiController]
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;

        private LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }


    }
}
