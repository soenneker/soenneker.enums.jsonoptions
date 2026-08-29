[![](https://img.shields.io/nuget/v/Soenneker.Enums.JsonOptions.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonOptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonoptions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonoptions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.JsonOptions.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonOptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonoptions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonoptions/actions/workflows/codeql.yml)

# Soenneker.Enums.JsonOptions

Identifies a predefined JSON serialization profile.

## Install

```bash
dotnet add package Soenneker.Enums.JsonOptions
```

## What you get

- `JsonOptionType` — Identifies a predefined JSON serialization profile.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `JsonOptionType.Web` | Web-oriented defaults, including camel-case property names and permissive input handling. | Web-oriented defaults, including camel-case property names and permissive input handling. |
| `JsonOptionType.General` | General-purpose serialization without camel-case property-name conversion. | General-purpose serialization without camel-case property-name conversion. |
| `JsonOptionType.Pretty` | Indented, non-camel-case output with relaxed character escaping. Use only for trusted internal content. | https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding. |
| `JsonOptionType.PrettySafe` | Indented, non-camel-case output with standard safe character escaping. | https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding. |

## Important behavior

- `JsonOptionType.Pretty`: https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding.
- `JsonOptionType.PrettySafe`: https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-character-encoding.
