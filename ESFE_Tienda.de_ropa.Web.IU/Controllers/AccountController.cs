using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ESFE_Tienda_de_ropa.Web.UI.Controllers
{
    /// <summary>
    /// Controlador encargado de gestionar el proceso de inicio de sesión y autenticación de usuarios.
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Muestra la pantalla del formulario de inicio de sesión (Login).
        /// </summary>
        /// <returns>La vista correspondiente al formulario de autenticación.</returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Valida las credenciales ingresadas por el usuario y genera la cookie de sesión si son correctas.
        /// </summary>
        /// <param name="usuario">Nombre de usuario o credencial ingresada.</param>
        /// <param name="password">Contraseña asociada a la cuenta.</param>
        /// <returns>Redirecciona a la vista principal si las credenciales son válidas, o retorna la misma vista si fallan.</returns>
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

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }

        /// <summary>
        /// Cierra la sesión activa del usuario eliminando las cookies de autenticación.
        /// </summary>
        /// <returns>Redirecciona al formulario de inicio de sesión.</returns>
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}