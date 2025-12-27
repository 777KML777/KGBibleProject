namespace Infra.Data.Repositories;

public class DoubtRepository
(
    IGenericRepository context
) : Repository(context), IDoubtRepository
{
}