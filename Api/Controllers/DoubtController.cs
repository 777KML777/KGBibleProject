using Application.Apps;
using Services.Objects.Dtos;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DoubtController
(
    IDoubtAppServices _appServices
) : ControllerBase
{
    [HttpPost]
    public DoubtDto Create(DoubtInputModel input) =>
        _appServices.Create(input);

    [HttpGet, Route("progressao-aritmetica")]
    public static string ProgressaoAritmetica(int termoInicial, int termo, int razao, int numeroPosicao) =>
        ProgressaoAritmeticaAppServices.Exibicao(termoInicial, termo, razao, numeroPosicao);
}