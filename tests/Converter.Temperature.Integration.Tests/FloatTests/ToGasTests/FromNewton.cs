using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromNewton
{
    [Theory]
    [InlineData(26.3999996185303f, 0.25f)]
    [InlineData(66f, 6f)]
    [InlineData(80.8499984741211f, 10f)]
    public void Test_float_extensions_from_newton_to_gas_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromNewton()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(26.3999996185303f, 0.25f)]
    [InlineData(66f, 6f)]
    [InlineData(80.8499984741211f, 10f)]
    public void Test_float_extensions_generic_from_newton_to_gas_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Newton>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(26.0699996948242f, "Temp too low for gas mark!")]
    [InlineData(89.0999984741211f, "Temp too high for gas mark!")]
    public void Test_float_extensions_from_newton_to_gas_with_invalid_parameters_throws_exception(
        float input,
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
    [InlineData(26.0699996948242f, "Temp too low for gas mark!")]
    [InlineData(89.0999984741211f, "Temp too high for gas mark!")]
    public void Test_float_extensions_generic_from_newton_to_gas_with_invalid_parameters_throws_exception(
        float input,
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
