namespace Application.Apps;

public static class ProgressaoAritmeticaAppServices
{
    private static string exibirPosicao = "";
    private static string resultadoFormatado;
    public static string Exibicao(int termoInicial, int termo, int razao, int numeroPosicao)
    {
        resultadoFormatado = "";
        int resultado = SomaDaPa(termoInicial, termo, razao, numeroPosicao);
        // Range Operator?
        string textoFormatado = $" {resultadoFormatado[..^2]} \n\n {exibirPosicao} \n\n {ExibirSoma(resultado)}";

        return textoFormatado;
    }

    private static int SomaDaPa(int termoInicial, int termo, int razao, int numeroPosicao)
    {
        int resultado = 0;

        // Somando Pa
        for (int i = 1; i <= termo; i++)
            resultado += termoInicial + (i - 1) * razao; // Formula PA

        // For para exibição.
        for (int i = 0; i < termo; i++)
        {
            resultadoFormatado += ExibirPA(termoInicial + (razao * i), i + 1);

            if (i + 1 == numeroPosicao)
                exibirPosicao = ExibirPosicao(numeroPosicao, termoInicial + (razao * i));

            if(i+ 1 < numeroPosicao)
                exibirPosicao = "Posição solicitada menor ou maior que o termo da PA";
        }

        return resultado;
    }

    private static string ExibirPA(int resultado, int termo) =>
        $"P.A Correspondente é: {resultado}(t{termo}) | ";

    private static string ExibirPosicao(int posicao, int termo) =>
        $"O número de posição {posicao} correspondente é: (t{termo})";

    private static string ExibirSoma(int resultado) =>
        $"Soma total dos termos da P.A é: {resultado}";
}