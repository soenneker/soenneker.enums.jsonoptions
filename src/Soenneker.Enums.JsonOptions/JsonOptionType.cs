using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.JsonOptions;

/// <summary>
/// Identifies a predefined JSON serialization profile.
/// </summary>
[EnumValue]
public sealed partial class JsonOptionType
{
    /// <summary>
    /// Web-oriented defaults, including camel-case property names and permissive input handling.
    /// </summary>
    public static readonly JsonOptionType Web = new(0);

    /// <summary>
    /// General-purpose serialization without camel-case property-name conversion.
    /// </summary>
    public static readonly JsonOptionType General = new(1);

    /// <summary>
    /// Indented, non-camel-case output with relaxed character escaping. Use only for trusted internal content.
    /// </summary>
    /// <remarks>https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding</remarks>
    public static readonly JsonOptionType Pretty = new(2);

    /// <summary>
    /// Indented, non-camel-case output with standard safe character escaping.
    /// </summary>
    /// <remarks>https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding</remarks>
    public static readonly JsonOptionType PrettySafe = new(3);
}
