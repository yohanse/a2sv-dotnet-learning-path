using FluentValidation.Results;

namespace Application;

public class ValidatorException : ApplicationException {

    public List<string> Errors {get; set;} = new List<string>();

    public ValidatorException(ValidationResult validationResult)
    {
        foreach(var error in validationResult.Errors) {
            Errors.Add(error.ErrorMessage);
        }
    }

    public ValidatorException()
    {
    }
}