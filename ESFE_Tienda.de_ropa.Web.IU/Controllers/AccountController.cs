using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ESFE_Tienda_de_ropa.Web.IU.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string usuario, string password)
        {
            if ((usuario == "admin" && password == "admin123") || (usuario == "cliente" && password == "1234"))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario),
                    new Claim(ClaimTypes.Role, usuario == "admin" ? "Admin" : "Cliente")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Producto");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}