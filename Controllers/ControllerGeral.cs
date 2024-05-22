using Microsoft.AspNetCore.Mvc;

namespace Atividade10.Controllers;
public class ControllerGeral : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View("/Views/Index.cshtml");
    }

    [Route("/tabuada")]
    public IActionResult Tabuada()
    {
        return View("/Views/Tabuada.cshtml");
    }
}