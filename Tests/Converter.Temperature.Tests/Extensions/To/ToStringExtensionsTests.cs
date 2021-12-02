namespace Converter.Temperature.Tests.Extensions.To
{
    using System;
    using Converter.Temperature.Extensions.To;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;
    using FluentAssertions;
    using Xunit;

    public class ToStringExtensionsTests
    {
        [Fact]
        public void Test_to_celsius_from_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusString("42");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "10";
            var input = new FahrenheitString("50");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "220";
            var input = new GasString("7");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "1";
            var input = new KelvinString("274.15");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "1.0000000000000062";
            var input = new RankineString("493.47");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_celsius_returns_same_value()
        {
            // Arrange.
            const string expected = "53.6";
            var input = new CelsiusString("12");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            var input = new FahrenheitString("50");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_from_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "428";
            var input = new GasString("7");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "33.8";
            var input = new KelvinString("274.15");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "33.80099999999999";
            var input = new RankineString("493.471");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_celsius_returns_correct_value()
        {
            // Arrange.
            const string expected = "6";
            var input = new CelsiusString("200");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_celsius_throws_out_of_range_exception_too_low()
        {
            // Arrange.
            var input = new CelsiusString("79");

            // Act.
             var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_celsius_throws_out_of_range_exception_too_high()
        {
            // Arrange.
            var input = new CelsiusString("271");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "6";
            var input = new FahrenheitString("392");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_fahrenheit_throws_out_of_range_exception_too_low()
        {
            // Arrange.
            var input = new FahrenheitString("174");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_fahrenheit_throws_out_of_range_exception_too_high()
        {
            // Arrange.
            var input = new FahrenheitString("520");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasString("7");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_gas_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "6";
            var input = new KelvinString("478.15");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_kelvin_throws_out_of_range_exception_too_low()
        {
            // Arrange.
            var input = new KelvinString("174");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_kelvin_throws_out_of_range_exception_too_high()
        {
            // Arrange.
            var input = new KelvinString("544.15");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "3";
            var input = new RankineString("806.67");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_rankine_throws_out_of_range_exception_too_low()
        {
            // Arrange.
            var input = new RankineString("174");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_rankine_throws_out_of_range_exception_too_high()
        {
            // Arrange.
            var input = new RankineString("1524.25");

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Fact]
        public void Test_to_kelvin_from_celsius_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = new CelsiusString("200");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = new FahrenheitString("392");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = new GasString("6");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinString("473.15");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_kelvin_from_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.1499999999999";
            var input = new RankineString("851.67");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_celsius_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            var input = new CelsiusString("200");

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            var inputCelsius = new CelsiusString(input.ToString());

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_rankine_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6700000000001";
            var input = new FahrenheitString("392");

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            var input = new GasString("6");

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_kelvin_returns_same_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            var input = new KelvinString("473.15");

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_rankine_returns_same_value()
        {
            // Arrange.
            var input = new RankineString("851.67");

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(input.Temperature);
        }
    }
}
