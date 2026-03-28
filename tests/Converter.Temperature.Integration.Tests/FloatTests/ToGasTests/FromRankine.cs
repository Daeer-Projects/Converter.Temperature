using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromRankine
{
        [Fact]
    public void Test_float_extensions_from_rankine_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 3f;
        const float input = 806.67f;

        // Act.
        float result = input.FromRankine()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_rankine_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 3f;
        const float input = 806.67f;

        // Act.
        float result = input.From<Rankine>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 405.2368f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 405.2368f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 1002.89786f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 1002.89786f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
