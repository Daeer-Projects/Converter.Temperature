using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(108L, 1L)]
    [InlineData(160L, 6L)]
    [InlineData(196L, 10L)]
    public void Test_long_extensions_from_réaumur_to_gas_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(108L, 1L)]
    [InlineData(160L, 6L)]
    [InlineData(196L, 10L)]
    public void Test_long_extensions_generic_from_réaumur_to_gas_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(107L, "Temp too low for gas mark!")]
    [InlineData(216L, "Temp too high for gas mark!")]
    public void Test_long_extensions_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        long input,
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
    [InlineData(107L, "Temp too low for gas mark!")]
    [InlineData(216L, "Temp too high for gas mark!")]
    public void Test_long_extensions_generic_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        long input,
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
