using PodkarpackiLekarz.Shared.Exceptions;

namespace PodkarpackiLekarz.Core.Users.Exceptions;
public class FieldCannotBeNullOrEmptyException : BadRequestException
{
    public FieldCannotBeNullOrEmptyException(string fieldName) 
        : base($"Field {fieldName} cannot be null or empty")
    {
    }
}
