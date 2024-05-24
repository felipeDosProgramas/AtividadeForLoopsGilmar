namespace Atividade10.Atividades;

public class ImprimirSequenciasNumericas
{
    public string[] Linhas;
    public ImprimirSequenciasNumericas SetLinhas()
    {
        Linhas = new string[11];
        for (int i = 0; i < 11; i++)
            Linhas[i] =  $"{i} 1 2 3 4 5 6 7 8 9 10";
        return this;
    }
}