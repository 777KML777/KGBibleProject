namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DoubtController
(
// IDoubtAppServices _appServices
) : ControllerBase
{
    // [HttpPost]
    // public DoubtInputModel Create(DoubtInputModel input) =>
    //     _appServices.Create(input);

    static string resultadoFormatado = "";
    static string exibirPosicao = "";

    [HttpGet, Route("progressao-aritmetica")]
    public string ProgressaoAritmetica(int termoInicial, int termo, int razao, int numeroPosicao)
    {
        int resultado = SomaDaPa(termoInicial, termo, razao, numeroPosicao);
        string resultadoExibicao = $" {resultadoFormatado.Remove(resultadoFormatado.Length - 1)} \n\n {exibirPosicao} \n\n {ExibirSoma(resultado)}";

        return resultadoExibicao;
    }

    private static int SomaDaPa(int termoInicial, int termo, int razao, int numeroPosicao)
    {
        int resultado = termoInicial;

        // Processando Soma
        for (int i = 1; i < termo; i++)
            resultado += termoInicial + ((i + 1) - termoInicial) * razao;

        // Exibir
        for (int i = 0; i < termo; i++)
        {
            resultadoFormatado += Pa_formatada(termoInicial + (razao * i), i + 1);

            if (i + 1 == numeroPosicao)
                exibirPosicao = ExibirPosicao(numeroPosicao, termoInicial + (razao * i));
        }

        return resultado;
    }

    private static string Pa_formatada(int resultado, int termo) =>
        $"P.A Correspondente é: {resultado}(t{termo}) | ";

    private static string ExibirPosicao(int resultado, int termo) =>
        $"O número de posição (t{termo}) correspondente é: {resultado}";

    private static string ExibirSoma(int resultado) =>
        $"Soma total dos termos da P.A é: {resultado}";
}