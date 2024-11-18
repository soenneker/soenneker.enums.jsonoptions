namespace Soenneker.Enums.JsonOptions;

/// <summary>
/// Represents different JSON option types.
/// </summary>
public enum JsonOptionType
{
    /// <summary>
    /// Web defaults, non-strict
    /// </summary>
    Web = 0,

    /// <summary>
    /// Non-camel case
    /// </summary>
    General = 1,

    /// <summary>
    /// Non-camel case with indentation WITHOUT escaping. WARNING Dangerous! Do not use unless for internal uses!
    /// </summary>
    /// <remarks>https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding</remarks>
    Pretty = 2,

    /// <summary>
    /// Non-camel case with indentation, WITH escaping. Safe for output.
    /// </summary>
    /// <remarks>https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding</remarks>
    PrettySafe = 3
}