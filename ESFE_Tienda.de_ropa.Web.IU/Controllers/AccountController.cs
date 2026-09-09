using Microsoft.AspNetCore.Mvc;

namespace ESFE_Tienda_de_ropa.Web.IU.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Validación de prueba
            if (email == "admin@tienda.com" && password == "123456")
            {
                return RedirectToAction("Index", "Producto");
            }

            ViewBag.Error = "Correo o contraseña incorrectos.";
            return View();
        }
    }
}