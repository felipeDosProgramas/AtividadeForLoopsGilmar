using Atividade10.Atividades;
using Microsoft.AspNetCore.Mvc;
namespace Atividade10.Controllers;
public class ControllerGeral : Controller
{
    [Route("/")]
    public IActionResult Index()
        => View("/Views/Index.cshtml");

    [Route("/tabuada")]
    public IActionResult Tabuada()
        =>  View("/Views/Tabuada.cshtml");

    [Route("/tabuada/{nro}")]
    public string Tabuada(int nro)
        => new CalculadoraTabuada(nro).ToString();

    [Route("/receberNros")]
    public IActionResult ReceberNrosPedidos()
        =>  View("/Views/ImprimirNrosPedidos.cshtml");

    [HttpGet("/exibirNros")]
    public string ExibirNrosPedidos([FromQuery]string nums)
        =>  new CalcularMaiorMenor(
                nums
                    .Split(' ')
                    .Select(e => Convert.ToInt32(e))
                    .ToArray()
            )
            .ToString();

    [Route("/exibirListasNumeros")]
    public IActionResult ExibirListasNumeros()
        => View("/Views/ListasNumeros.cshtml");
}