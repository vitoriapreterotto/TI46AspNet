using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProjeto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
