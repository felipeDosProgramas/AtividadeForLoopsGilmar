using Atividade10.Atividades;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Atividade10.Views;

public class ListasNumeros : PageModel
{
    public static string[] ListaNumerosParaExibir = new ImprimirSequenciasNumericas()
        .ToString()
        .Split(">>><<<")
        .Where(str => str.Length != 0)
        .ToArray();
    public void OnGet()
    {
    }
}