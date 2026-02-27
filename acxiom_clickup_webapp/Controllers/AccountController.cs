using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace acxiom_clickup_webapp.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            var callbackUrl = Url.Action("Index", "Home");
            return SignOut(new AuthenticationProperties { RedirectUri = callbackUrl }, CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
        }

        [AllowAnonymous]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult SignInChallenge(string returnUrl = "/")
        {
            var props = new AuthenticationProperties { RedirectUri = returnUrl ?? Url.Action("Index", "Home") };
            return Challenge(props, OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}
