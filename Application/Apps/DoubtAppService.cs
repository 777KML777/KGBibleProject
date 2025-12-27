using Application.Inputs;
using Domain.Dtos;
using Domain.Interfaces;

namespace Application.Apps;

public class DoubtAppService
(
    IDoubtService _service
) : IDoubtAppService
{
    public DoubtDto Create(DoubtInputModel input)
    {
        // TODO: Implementar IsValid 
        throw new NotImplementedException();
    }
}