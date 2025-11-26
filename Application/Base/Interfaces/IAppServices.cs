namespace Application.Base.Interfaces; 

public interface IAppServices <TInputModel>
{
    public TInputModel Create(TInputModel input);
}