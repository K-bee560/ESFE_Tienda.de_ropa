using Microsoft.AspNetCore.Mvc;

namespace ESFE_Tienda_de_ropa.Web.IU.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}