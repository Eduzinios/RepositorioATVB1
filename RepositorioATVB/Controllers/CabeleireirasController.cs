using RepositorioATVB.Models;
using Microsoft.AspNetCore.Mvc;

namespace RepositorioATVB.Controllers
{
    public class CabeleireirasController : Controller
    {

        public IActionResult Index()
        {
            var cabeleireira = new List<Cabeleireira>
        {
            new Cabeleireira { Id = 1, Nome = "Sônia", Pais = "Brasil" },
            new Cabeleireira { Id = 2, Nome = "Heloisa", Pais = "Brasil" }
        };
            return View(cabeleireira);
        }
    }



}