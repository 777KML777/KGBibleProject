namespace Application.Base.Interfaces; 

public interface IAppServices <TInputModel, TDto>
{
    public TDto Create(TInputModel input);
}