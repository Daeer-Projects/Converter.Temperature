using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToGasTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(108, 1)]
    [InlineData(160, 6)]
    [InlineData(196, 10)]
    public void Test_int_extensions_from_réaumur_to_gas_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(108, 1)]
    [InlineData(160, 6)]
    [InlineData(196, 10)]
    public void Test_int_extensions_generic_from_réaumur_to_gas_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(107, "Temp too low for gas mark!")]
    [InlineData(216, "Temp too high for gas mark!")]
    public void Test_int_extensions_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        int input,
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
    [InlineData(107, "Temp too low for gas mark!")]
    [InlineData(216, "Temp too high for gas mark!")]
    public void Test_int_extensions_generic_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        int input,
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
