using Services.Objects.Dtos;

namespace Application.Apps;

public class DoubtAppServices
(
    IDoubtServices _services
) : IDoubtAppServices
{
    public DoubtDto Create(DoubtInputModel input)
    {
        // TODO: Implementar IsValid 
        throw new NotImplementedException();
    }
}