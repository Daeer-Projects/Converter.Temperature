# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

Converter.Temperature is a .NET library providing extension methods to convert between temperature scales (Celsius, Fahrenheit, Kelvin, Gas, Rankine, Rømer, Delisle, Newton, Réaumur) across numeric types (int, long, float, double, string). Uses a fluent API: `34.FromCelsius().ToFahrenheit()`.

## Build, Test, and Run

Targets .NET 8.0, 9.0, and 10.0. No `.sln` file exists (uses `.slnx`).

```bash
# Build
dotnet build

# Run all tests (xUnit)
dotnet test

# Run a single test
dotnet test --filter "FullyQualifiedName~TestMethodName"

# Run tests for a specific project
dotnet test tests/Converter.Temperature.Tests/

# Run benchmarks
dotnet run --project tests/Converter.Benchmark.Tests/ -c Release

# Pack the NuGet package
dotnet pack
```

## Architecture

### Directory Structure

- `src/Converter.Temperature/` — Main library
  - `BaseTypes/` — `TypeBase<T>` and typed variants (`IntBase`, `LongBase`, etc.)
  - `TemperatureTypes/` — Marker types for generic API (`Celsius`, `Fahrenheit`, etc. extending `TemperatureBase`)
  - `Types/{Scale}/` — Concrete wrapper types per numeric type (e.g., `CelsiusInt`, `CelsiusDouble`), each extending the appropriate `BaseType` and holding a `Temperature` property
  - `Converters/{Scale}/` — Internal static conversion logic classes with range checks (e.g., `DelisleIntConversions`, `CelsiusDoubleConversions`)
  - `Extensions/From/` — `From{Type}Extensions.cs` — provides `value.FromCelsius()`, `value.FromFahrenheit()`, and generic `value.From<T>()` on `int`, `long`, `float`, `double`, `string`
  - `Extensions/To/` — `To{Type}Extensions.cs` — provides `.ToCelsius()`, `.ToFahrenheit()`, and generic `.To<T>()` methods on the typed wrapper classes
  - `Constants.cs` — Shared error messages
- `tests/Converter.Temperature.Tests/` — Unit tests (xUnit + FluentAssertions)
- `tests/Converter.Benchmark.Tests/` — Performance benchmarks (BenchmarkDotNet)
- `tests/Converter.Temperature.Integration.Tests/` — Integration tests

### Conversion Flow

```
value.FromCelsius()      → wrapping object (e.g., CelsiusInt)
    .ToFahrenheit()      → unwraps, calls internal conversion, returns int
```

The generic API works the same way:
```csharp
value.From<Celsius>().To<Fahrenheit>()
```

`FromX()` creates a typed wrapper; `To<T>()` uses a switch expression on `TInput.Name` + `is` pattern matching on the wrapper type to route to the correct internal converter.

### Adding a New Temperature Scale

1. Add marker type in `TemperatureTypes/` extending `TemperatureBase`
2. Add wrapper types in `Types/{Scale}/` for each numeric type (Int, Long, Float, Double, String)
3. Add conversion logic in `Converters/{Scale}/` — internal static class with range checks using `decimal` for precision
4. Add `From{Scale}` extension in `Extensions/From/From{Type}Extensions.cs`
5. Add `To{Scale}` extension in `Extensions/To/To{Type}Extensions.cs`
6. Register the type in the generic `From<T>()` and `To<T>()` switch expressions
7. Add tests

### Adding a New Data Type (e.g., short)

1. Add `ShortBase` in `BaseTypes/`
2. Add wrapper types `Types/{Scale}/CelsiusShort.cs`, etc.
3. Add conversion logic in `Converters/{Scale}/`
4. Add `From{Type}Extensions.cs` and `To{Type}Extensions.cs`
5. Register in generic switch expressions
6. Add tests

### Edge Case Handling

When a converted value exceeds the target type's range (e.g., converting a large `int` from Celsius to Fahrenheit), the converters throw `ArgumentOutOfRangeException` with `Constants.ValueOutOfRangeForType`. Min/max boundary checks use `decimal` arithmetic for precision, comparing the computed result against `int.MinValue - 0.5m` and `int.MaxValue + 0.5m` (with analogous bounds for `long`, `float`, `double`).

## CI/CD

Azure Pipelines (`azure-pipelines.yml`) on push to `main`: restore → build → test → pack → publish. Targets .NET 8, 9, and 10.
