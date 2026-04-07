# Coding Standards

## General Standards

- **Indentation**: Use 4-space indentation (as defined in `.editorconfig`)
- **Whitespace**: 
  - Use spaces, not tabs
  - Trim trailing whitespace
  - Maintain consistent spacing around operators and after commas
- **Line Endings**: Use CRLF (Windows standard)
- **File Encoding**: UTF-8 with BOM

## C# Standards

### Formatting
- Braces for all control structures (if/else, for/foreach, while, etc.)
- Braces on new lines
- Indent switch labels 4 spaces
- Indent block contents 4 spaces
- Use `using` statements for all `IDisposable` objects

### Naming Conventions
- **Classes/Structs**: PascalCase (e.g., `TemperatureConverter`)
- **Methods**: PascalCase (e.g., `ConvertToFahrenheit()`)
- **Properties**: PascalCase (e.g., `CelsiusValue`)
- **Parameters**: camelCase (e.g., `temperatureValue`)
- **Local Variables**: camelCase (e.g., `conversionFactor`)
- **Constants**: PascalCase with `k_` prefix (e.g., `k_MaxTemperature`)
- **Enum Values**: PascalCase (e.g., `Celsius`, `Fahrenheit`)

### Documentation
- XML comments required for all public members
- Summary comments for all public types and members
- Parameters and return values documented
- Exceptions documented

### Error Handling
- Use `ArgumentOutOfRangeException` for invalid arguments
- Use `InvalidOperationException` for invalid state
- Include error messages with context

## .NET Standards

### Project Structure
- **Main Library**: `src/Converter.Temperature/`
- **Tests**: `tests/Converter.Temperature.Tests/`
- **Benchmarks**: `tests/Converter.Benchmark.Tests/`
- **NuGet Packaging**: `dotnet pack` command

### Build Configuration
- Targets .NET 8, 9, and 10
- No `.sln` file (uses `.slnx`)
- Azure Pipelines configuration in `azure-pipelines.yml`

### Performance
- Use `decimal` for precision-critical calculations
- Range checks use `decimal` arithmetic
- Benchmarks use BenchmarkDotNet for performance testing

## Editor Configuration

The `.editorconfig` file enforces these standards:
```ini
[*]
indent_style = space
indent_size = 4
end_of_line = crlf
charset = utf-8
trim_trailing_whitespace = true
insert_final_newline = true

[*.cs]
# C# style settings
csharp_new_line_before_open_brace = all
csharp_new_line_before_else = true
csharp_new_line_before_catch = true
csharp_new_line_before_finally = true
csharp_indent_case_contents = true
csharp_indent_switch_labels = true
csharp_indent_labels = flush_left
csharp_indent_block_contents = true
csharp_indent_braces = false
csharp_indent_method_declaration_parameter_list = true
csharp_indent_method_call_parameter_list = true

# C# whitespace settings
csharp_space_after_cast = false
csharp_space_after_keywords_in_control_flow_statements = true
csharp_space_between_method_declaration_parameter_list_parentheses = false
csharp_space_between_method_call_parameter_list_parentheses = false
csharp_space_after_comma = true
csharp_space_before_comma = false
csharp_space_after_dot = false
csharp_space_before_dot = false
csharp_space_after_semicolon = true
csharp_space_before_semicolon = false
csharp_space_around_binary_operators = before_and_after

# C# Code Style Rules
csharp_style_var_for_built_in_types = false:error
csharp_style_var_when_type_is_apparent = false:error
csharp_style_var_elsewhere = false:error
csharp_prefer_simple_using_statement = true:suggestion
csharp_style_namespace_declarations = file_scoped:suggestion

# ReSharper settings
dotnet_diagnostic.IDE0005.severity = suggestion
dotnet_diagnostic.IDE0055.severity = error
```

## Compliance

All code must comply with these standards
Use ReSharper to enforce standards
`.editorconfig` is checked into version control
CI pipeline validates standards during builds

For questions about specific standards, consult the CLAUDE.md documentation or the .editorconfig file.