using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESFE_Tienda_de_ropa.Web.IU.Controllers
{
    [Authorize]
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}