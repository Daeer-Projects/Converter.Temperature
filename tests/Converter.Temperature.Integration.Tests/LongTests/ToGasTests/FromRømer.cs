using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromRømer
{
    [Theory]
    [InlineData(83L, 1L)]
    [InlineData(88L, 2L)]
    [InlineData(99L, 3L)]
    [InlineData(104L, 4L)]
    [InlineData(109L, 5L)]
    [InlineData(117L, 6L)]
    [InlineData(125L, 7L)]
    [InlineData(130L, 8L)]
    [InlineData(135L, 9L)]
    [InlineData(136L, 10L)]
    [InlineData(148L, 10L)]
    public void Test_long_extensions_from_rømer_to_gas_returns_correct_gas_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRømer()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(83L, 1L)]
    [InlineData(88L, 2L)]
    [InlineData(99L, 3L)]
    [InlineData(104L, 4L)]
    [InlineData(109L, 5L)]
    [InlineData(117L, 6L)]
    [InlineData(125L, 7L)]
    [InlineData(130L, 8L)]
    [InlineData(135L, 9L)]
    [InlineData(136L, 10L)]
    [InlineData(148L, 10L)]
    public void Test_long_extensions_generic_from_rømer_to_gas_returns_correct_gas_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Rømer>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 48L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_generic_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 48L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 149L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_generic_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const long input = 149L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
