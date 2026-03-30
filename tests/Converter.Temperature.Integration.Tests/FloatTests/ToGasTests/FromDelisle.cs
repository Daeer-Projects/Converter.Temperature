using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromDelisle
{
    [Theory]
    [InlineData(30f, 0.25f)]
    [InlineData(-150f, 6f)]
    [InlineData(-217.5f, 10f)]
    public void Test_float_extensions_from_delisle_to_gas_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromDelisle()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(30f, 0.25f)]
    [InlineData(-150f, 6f)]
    [InlineData(-217.5f, 10f)]
    public void Test_float_extensions_generic_from_delisle_to_gas_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Delisle>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(31.5f, "Temp too low for gas mark!")]
    [InlineData(-255f, "Temp too high for gas mark!")]
    public void Test_float_extensions_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        float input,
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
    [InlineData(31.5f, "Temp too low for gas mark!")]
    [InlineData(-255f, "Temp too high for gas mark!")]
    public void Test_float_extensions_generic_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        float input,
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
