using System.ComponentModel.DataAnnotations;

namespace Application;

public class ValidatorException : ApplicationException {

    public List<string> Errors {get; set;} = new List<string>();

    public ValidatorException(ValidationResult validationResult)
    {
        for(var error in validationResult.) {

        }
    }

}