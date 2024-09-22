using RepositorioATVB.Models;
using Microsoft.AspNetCore.Mvc;

public class SalõesController : Controller
{

    public IActionResult Index()
    {
        var Salão = new List<Salão>
        {
            new Salão { Id = 1, Nome = "Studio Hair", Genero = "Feminino", CabeleireiraId = 1 },
            new Salão { Id = 2, Nome = "Mãos de fada", Genero = "Manicure", CabeleireiraId = 2 }
        };
        return View(Salão);
    }
}
