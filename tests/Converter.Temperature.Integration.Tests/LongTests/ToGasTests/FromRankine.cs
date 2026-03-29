using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromRankine
{
    [Fact]
    public void Test_long_extensions_from_rankine_to_gas_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 4L;
        const long input = 807L;

        // Act.
        long result = input.FromRankine()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_rankine_to_gas_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 4L;
        const long input = 807L;

        // Act.
        long result = input.From<Rankine>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 405L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_generic_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 405L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 1001L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_generic_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 1001L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
