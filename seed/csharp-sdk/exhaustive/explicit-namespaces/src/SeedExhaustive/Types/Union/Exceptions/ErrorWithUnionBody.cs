using SeedExhaustive;

namespace SeedExhaustive.Types.Union;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ErrorWithUnionBody(Animal body)
    : SeedExhaustiveApiException("ErrorWithUnionBody", 400, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new Animal Body => body;
}
