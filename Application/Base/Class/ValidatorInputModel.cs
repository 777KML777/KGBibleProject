namespace Application.Base.Class; 

public abstract record class ValidatorInputModel
{
    public abstract void Validate(string controller = "");
} 