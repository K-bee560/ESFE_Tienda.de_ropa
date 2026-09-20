using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESFE_Tienda_de_ropa.Web.IU.Controllers
{
    [AllowAnonymous] // 👈 Permitir que cualquiera pueda ver los productos
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
