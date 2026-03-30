using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToGasTests;

public class FromNewton
{
    [Theory]
    [InlineData(26.4d, 0.25d)]
    [InlineData(66d, 6d)]
    [InlineData(80.85d, 9d)]
    public void Test_double_extensions_from_newton_to_gas_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(26.4d, 0.25d)]
    [InlineData(66d, 6d)]
    [InlineData(80.85d, 9d)]
    public void Test_double_extensions_generic_from_newton_to_gas_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(26.07d, "Temp too low for gas mark!")]
    [InlineData(89.1d, "Temp too high for gas mark!")]
    public void Test_double_extensions_from_newton_to_gas_with_invalid_parameters_throws_exception(
        double input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(26.07d, "Temp too low for gas mark!")]
    [InlineData(89.1d, "Temp too high for gas mark!")]
    public void Test_double_extensions_generic_from_newton_to_gas_with_invalid_parameters_throws_exception(
        double input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
