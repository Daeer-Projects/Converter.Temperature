using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToNewtonTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(int.MinValue)]
    public void Test_int_extension_from_fahrenheit_and_to_newton_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(-393705341);
    }

    [Theory]
    [InlineData(int.MinValue)]
    public void
        Test_int_extension_generic_from_fahrenheit_and_to_newton_with_invalid_values_throws_out_of_range_exception(
            int input)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Newton>();

        // Assert.
        result.Should()
            .Be(-393705341);
    }

    [Theory]
    [InlineData(212, 33)]
    [InlineData(32, 0)]
    [InlineData(0, -6)]
    public void Test_int_extension_from_fahrenheit_to_newton_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_newton_with_max_value_returns_correct_value()
    {
        // Arrange.
        const int expected = 393705329;
        const int input = int.MaxValue;

        // Act.
        int result = input.FromFahrenheit()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
