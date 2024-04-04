namespace Converter.Temperature.Tests.Extensions.To.Gas;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Gas;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToStringExtensionsTests : BaseToExtensionTests<GasString, string>
{
    public ToStringExtensionsTests() : base("5", GetData()) { }

    private static List<string> GetData()
    {
        return new List<string>
        {
            "0.25",
            "5",
            "10"
        };
    }

    protected override string To(
        GasString value,
        int fractionalCount)
    {
        return value.ToGas(fractionalCount);
    }

    protected override string ToUsingGeneric(
        GasString value,
        int fractionalCount)
    {
        return value.To<Gas>(fractionalCount);
    }

    protected override GasString Create(
        string value)
    {
        return new GasString(value);
    }

    [Fact]
    public void Test_to_gas_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "6";
        CelsiusString input = new("200");

        // Act.
        string result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "6";
        CelsiusString input = new("200");

        // Act.
        string result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_celsius_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        CelsiusString input = new("79");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_celsius_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        CelsiusString input = new("79");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_celsius_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        CelsiusString input = new("271");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_celsius_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        CelsiusString input = new("271");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "6";
        FahrenheitString input = new("392");

        // Act.
        string result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "6";
        FahrenheitString input = new("392");

        // Act.
        string result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_fahrenheit_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        FahrenheitString input = new("174");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        FahrenheitString input = new("174");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_fahrenheit_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        FahrenheitString input = new("520");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        FahrenheitString input = new("520");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_gas_returns_same_value()
    {
        // Arrange.
        GasString input = new("7");

        // Act.
        string result = input.ToGas();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_generic_from_gas_returns_same_value()
    {
        // Arrange.
        GasString input = new("7");

        // Act.
        string result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "6";
        KelvinString input = new("478.15");

        // Act.
        string result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "6";
        KelvinString input = new("478.15");

        // Act.
        string result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_kelvin_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        KelvinString input = new("174");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        KelvinString input = new("174");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_kelvin_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        KelvinString input = new("544.15");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        KelvinString input = new("544.15");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "3";
        RankineString input = new("806.67");

        // Act.
        string result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "3";
        RankineString input = new("806.67");

        // Act.
        string result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_rankine_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        RankineString input = new("174");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        RankineString input = new("174");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_rankine_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        RankineString input = new("1524.25");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        RankineString input = new("1524.25");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Theory]
    [InlineData("10", "148.367")]
    [InlineData("6", "110.384")]
    [InlineData("0.25", "50.994")]
    public void Test_to_gas_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("10", "148.367")]
    [InlineData("6", "110.384")]
    [InlineData("0.25", "50.994")]
    public void Test_to_gas_generic_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_rømer_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        RømerString input = new("49");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_rømer_throws_out_of_range_exception_too_low()
    {
        // Arrange.
        RømerString input = new("49");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_rømer_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        RømerString input = new("149.5");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_generic_from_rømer_throws_out_of_range_exception_too_high()
    {
        // Arrange.
        RømerString input = new("149.5");

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
