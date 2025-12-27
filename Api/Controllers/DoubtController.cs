using Application.Apps;
using Application.Inputs;
using Domain.Dtos;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DoubtController
(
    IDoubtAppService _app
) : ControllerBase
{
    [HttpPost]
    public DoubtDto Create(DoubtInputModel input) =>
        _app.Create(input);

    [HttpGet, Route("progressao-aritmetica")]
    public static string ProgressaoAritmetica(int termoInicial, int termo, int razao, int numeroPosicao) =>
        ProgressaoAritmeticaAppServices.Exibicao(termoInicial, termo, razao, numeroPosicao);
}