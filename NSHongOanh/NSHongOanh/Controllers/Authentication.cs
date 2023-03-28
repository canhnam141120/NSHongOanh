using Microsoft.AspNetCore.Mvc;

namespace NSHongOanh.Controllers
{
    public class Authentication : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult PasswordChange()
        {
            return View();
        }

        public IActionResult PasswordReset()
        {
            return View();
        }
    }
}
