using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToGasTests;

public class FromRømer
{
    [Theory]
    [InlineData(83, 1)]
    [InlineData(88, 2)]
    [InlineData(99, 3)]
    [InlineData(104, 4)]
    [InlineData(109, 5)]
    [InlineData(117, 6)]
    [InlineData(125, 7)]
    [InlineData(130, 8)]
    [InlineData(135, 9)]
    [InlineData(136, 10)]
    [InlineData(148, 10)]
    public void Test_int_extensions_from_rømer_to_gas_returns_correct_gas_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRømer()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(83, 1)]
    [InlineData(88, 2)]
    [InlineData(99, 3)]
    [InlineData(104, 4)]
    [InlineData(109, 5)]
    [InlineData(117, 6)]
    [InlineData(125, 7)]
    [InlineData(130, 8)]
    [InlineData(135, 9)]
    [InlineData(136, 10)]
    [InlineData(148, 10)]
    public void Test_int_extensions_generic_from_rømer_to_gas_returns_correct_gas_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Rømer>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const int input = 48;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_int_extensions_generic_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const int input = 48;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_int_extensions_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const int input = 149;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_int_extensions_generic_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const int input = 149;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
