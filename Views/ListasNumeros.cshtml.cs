using Atividade10.Atividades;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Atividade10.Views;

public class ListasNumeros : PageModel
{
    public static string[] ListaNumerosParaExibir = new ImprimirSequenciasNumericas()
        .SetLinhas()
        .Linhas;

    public void OnGet()
    {
    }
}