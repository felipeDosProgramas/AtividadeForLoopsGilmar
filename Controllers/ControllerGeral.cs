using Atividade10.Atividades;
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
    [Route("/tabuada/{nro}")]
    public string Tabuada(int nro)
    {
        return new CalculadoraTabuada(nro).ToString();
    }
    [Route("/receberNros")]
    public IActionResult ReceberNrosPedidos()
    {
        return View("/Views/ImprimirNrosPedidos.cshtml");
    }
    [HttpGet("/exibirNros")]
    public string ExibirNrosPedidos([FromQuery]string nums)
    {
        return new CalcularMaiorMenor(
                nums
                    .Split(' ')
                    .Select(e => Convert.ToInt32(e))
                    .ToArray()
            )
            .ToString();
    }
}