### Coding Guidelines

This document outlines the coding standards and best practices used in the Temperature Converter solution. Follow these guidelines to ensure consistency across the codebase.

---

#### 1. Language and Framework
- **Target Framework:** .NET 8.0 or higher.
- **C# Version:** Latest supported version (C# 12.0+).

---

#### 2. General Code Structure
- **File-scoped Namespaces:** Use file-scoped namespaces to reduce indentation.
  ```csharp
  namespace Converter.Temperature.Converters.Celsius;
  ```
- **Using Directives:** 
  - Place `using` directives outside the namespace.
  - Group and sort them alphabetically, with `System` namespaces first.
- **Regions:** Use `#region` and `#endregion` to group related methods (e.g., in extension classes or tests).

---

#### 3. Naming Conventions
- **Classes/Interfaces/Methods:** Use `PascalCase`.
- **Parameters/Local Variables:** Use `camelCase`.
- **Constants:** Use `PascalCase` (following the project's existing style in `Constants.cs`).
- **Test Methods:** Use the pattern `Test_[Scenario]_[Action]_[ExpectedResult]` or `Test_[MethodName]_[Scenario]_[ExpectedResult]`.
  ```csharp
  public void Test_double_extension_from_and_to_celsius_returns_correct_double_value()
  ```

---

#### 4. Classes and Types
- **Accessibility:** 
  - Use `internal` for logic that shouldn't be exposed outside the library (e.g., core conversion logic classes).
  - Use `public` for the API surface (e.g., extension methods, base types).
- **Modifiers:**
  - Use `static` for utility and conversion logic classes.
  - Use `sealed` for concrete implementation classes to prevent further inheritance.
  - Use `abstract` for base classes.
- **Inheritance:** Use a clear inheritance hierarchy for types (e.g., `TypeBase<T>` -> `DoubleBase` -> `CelsiusDouble`).

---

#### 5. Documentation
- **XML Comments:** All public and internal members must have XML documentation.
  - Include `<summary>`, `<param>`, `<returns>`, and `<exception>` tags where applicable.
  - Ensure descriptions are clear and concise.
  ```csharp
  /// <summary>
  ///     The celsius to fahrenheit conversion.
  /// </summary>
  /// <param name="input"> The temperature to convert. </param>
  /// <returns> The converted temperature. </returns>
  ```

---

#### 6. Error Handling
- **Exceptions:** Throw specific exceptions. Use `ArgumentOutOfRangeException` for values beyond type limits or specialized domain limits (like Gas Mark).
- **Messages:** Use centralized constant strings for exception messages.
  ```csharp
  if (input < minValue)
  {
      throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
  }
  ```

---

#### 7. Coding Style
- **Indentation:** Use 4 spaces (no tabs).
- **Braces:** Always use braces, even for single-line statements. Braces should be on a new line.
- **Expression-bodied Members:** Use them for simple, one-line implementations.
- **Extension Methods:** Use them to provide a fluent API.
  ```csharp
  public static CelsiusDouble FromCelsius(this double input)
  ```
- **Pattern Matching:** Use modern C# features like `switch` expressions and property patterns where they improve readability.

---

#### 8. Unit and Integration Testing
- **Frameworks:** Use **xUnit** for testing and **FluentAssertions** for assertions.
- **Structure:** Follow the **Arrange-Act-Assert** (AAA) pattern. Label each section with comments.
- **Data-Driven Tests:** Use `[Theory]` and `[InlineData]` for tests that run against multiple data points.
- **Mocking:** Avoid over-mocking; favor integration tests for core logic.

---

#### 9. Specific Logic Guidelines
- **Math:** When converting types (e.g., `double` to `int`), use `Math.Round` with `MidpointRounding.AwayFromZero` for consistent results.
- **Validation:** Perform range checks before performing operations that might overflow or result in infinity.
