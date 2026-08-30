[![](https://img.shields.io/nuget/v/Soenneker.Enums.JsonOptions.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonOptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonoptions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonoptions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.JsonOptions.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonOptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonoptions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonoptions/actions/workflows/codeql.yml)

# Soenneker.Enums.JsonOptions

An integer-backed enum-value type for selecting one of the JSON profiles used by Soenneker JSON utilities.

## Install

```bash
dotnet add package Soenneker.Enums.JsonOptions
```

## Usage

```csharp
using Soenneker.Enums.JsonOptions;

JsonOptionType profile = JsonOptionType.PrettySafe;
int value = profile.Value; // 3

if (JsonOptionType.TryFromValue(configuredValue, out JsonOptionType? parsed))
{
    profile = parsed;
}
```

| Value | Numeric value | Intended profile |
| --- | ---: | --- |
| `Web` | `0` | Compact web defaults with camel-case property names |
| `General` | `1` | Compact general defaults without camel-case conversion |
| `Pretty` | `2` | Indented general output with relaxed escaping |
| `PrettySafe` | `3` | Indented general output with standard escaping |

The generated `System.Text.Json` converter writes the numeric value and accepts only defined values when reading. `FromValue` throws for an unknown integer; use `TryFromValue` at configuration or request boundaries. `FromName` and `TryFromName` use the C# member names.

This package supplies profile identifiers, not `JsonSerializerOptions`. The component receiving the value defines the concrete settings; in the Soenneker options collection these profiles also differ in null handling, comment handling, and enum converters.

Do not use `Pretty` for JSON that will be embedded in HTML or otherwise cross an untrusted output boundary: its relaxed encoder allows characters that the default encoder escapes. `PrettySafe` keeps standard escaping, but output-context encoding is still the caller's responsibility.
