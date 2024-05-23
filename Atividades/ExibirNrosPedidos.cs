namespace Atividade10.Atividades;

public class ExibirNrosPedidos(
    int[] numeros
){
    public override string ToString()
    {
        int paresDigitados = 0, zeros = 0;
        foreach (int num in numeros)
            if (num % 2 == 0 && num < 0)
                paresDigitados++;
            else if (num == 0)
                zeros++;
        return $"pares negativos: {paresDigitados} >>><<< zeros: {zeros}";
    }
}