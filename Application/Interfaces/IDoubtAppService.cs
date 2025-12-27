using Application.Inputs;
using Domain.Dtos;

namespace Application.Interfaces;

public interface IDoubtAppService
{
    public DoubtDto Create(DoubtInputModel input);
}