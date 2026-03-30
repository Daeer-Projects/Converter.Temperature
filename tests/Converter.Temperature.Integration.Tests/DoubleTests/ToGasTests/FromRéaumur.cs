using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToGasTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(64d, 0.25d)]
    [InlineData(160d, 6d)]
    [InlineData(196d, 10d)]
    public void Test_double_extensions_from_réaumur_to_gas_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRéaumur()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(64d, 0.25d)]
    [InlineData(160d, 6d)]
    [InlineData(196d, 10d)]
    public void Test_double_extensions_generic_from_réaumur_to_gas_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Réaumur>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(63.2d, "Temp too low for gas mark!")]
    [InlineData(216d, "Temp too high for gas mark!")]
    public void Test_double_extensions_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        double input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(63.2d, "Temp too low for gas mark!")]
    [InlineData(216d, "Temp too high for gas mark!")]
    public void Test_double_extensions_generic_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        double input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
