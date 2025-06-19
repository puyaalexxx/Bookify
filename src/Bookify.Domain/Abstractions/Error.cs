namespace Bookify.Domain.Abstractions;

/// <summary>
/// When something goes wrong assign a unique error code and a name to the error.
/// </summary>
/// <param name="Code"></param>
/// <param name="Name"></param>
public record Error(string Code, string Name)
{
    public static Error None = new(string.Empty, string.Empty);

    public static Error NullValue = new("Error.NullValue", "Null value was provided");
}