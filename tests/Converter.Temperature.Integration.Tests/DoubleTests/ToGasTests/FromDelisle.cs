using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToGasTests;

public class FromDelisle
{
    [Theory]
    [InlineData(30d, 0.25d)]
    [InlineData(-150d, 6d)]
    [InlineData(-217.5d, 10d)]
    public void Test_double_extensions_from_delisle_to_gas_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromDelisle()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(30d, 0.25d)]
    [InlineData(-150d, 6d)]
    [InlineData(-217.5d, 10d)]
    public void Test_double_extensions_generic_from_delisle_to_gas_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Delisle>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(31.5d, "Temp too low for gas mark!")]
    [InlineData(-255d, "Temp too high for gas mark!")]
    public void Test_double_extensions_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        double input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromDelisle()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(31.5d, "Temp too low for gas mark!")]
    [InlineData(-255d, "Temp too high for gas mark!")]
    public void Test_double_extensions_generic_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        double input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Delisle>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
