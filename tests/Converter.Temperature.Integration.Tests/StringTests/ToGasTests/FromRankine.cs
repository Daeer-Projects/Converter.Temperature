using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToGasTests;

public class FromRankine
{
    [Fact]
    public void Test_string_extensions_from_rankine_to_gas_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "3";
        const string input = "806.67";

        // Act.
        string result = input.FromRankine()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_rankine_to_gas_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "3";
        const string input = "806.67";

        // Act.
        string result = input.From<Rankine>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const string input = "405.2368";

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_string_extensions_generic_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const string input = "405.2368";

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_string_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const string input = "1002.89786";

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_string_extensions_generic_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const string input = "1002.89786";

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
