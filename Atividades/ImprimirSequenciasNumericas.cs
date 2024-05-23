namespace Atividade10.Atividades;

public class ImprimirSequenciasNumericas {
    public string Linha = "";
    public override string ToString()
    {
        for (int i = 0; i < 11; i++)
            Linha += $"{i} 1 2 3 4 5 6 7 8 9 10 >>><<<";
        return Linha;
    }
}