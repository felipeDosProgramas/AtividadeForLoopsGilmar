namespace Atividade10.Atividades;

public class CalcularMaiorMenor(
    int[] numeros
) {
    public override string ToString()
    {
        int maior = numeros.Max(),
            menor = numeros.Min();
        return $"o maior número é {maior} e o menor é {menor}";
    }
}