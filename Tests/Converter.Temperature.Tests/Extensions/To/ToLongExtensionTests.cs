namespace Converter.Temperature.Tests.Extensions.To
{
    using System;
    using FluentAssertions;
    using Temperature.Extensions.To;
    using TemperatureTypes;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;
    using Xunit;

    public class ToLongExtensionTests
    {
        [Fact]
        public void Test_to_celsius_from_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusLong(42L);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_generic_from_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusLong(42L);

            // Act.
            var result = input.To<Celsius>();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 10L;
            var input = new FahrenheitLong(50L);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 10L;
            var input = new FahrenheitLong(50L);

            // Act.
            var result = input.To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 230L;
            var input = new GasLong(7L);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1L, 150L)]
        [InlineData(2L, 165L)]
        [InlineData(3L, 180L)]
        [InlineData(4L, 190L)]
        [InlineData(5L, 202L)]
        [InlineData(6L, 217L)]
        [InlineData(7L, 230L)]
        [InlineData(8L, 240L)]
        [InlineData(9L, 250L)]
        public void Test_to_celsius_generic_from_gas_returns_correct_value(long input, long expected)
        {
            // Arrange.
            var inputGas = new GasLong(input);

            // Act.
            var result = inputGas.To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 1L;
            var input = new KelvinLong(274L);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 1L;
            var input = new KelvinLong(274L);

            // Act.
            var result = input.To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = -121L;
            var input = new RankineLong(274L);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_generic_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = -121L;
            var input = new RankineLong(274L);

            // Act.
            var result = input.To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 54L;
            var input = new CelsiusLong(12L);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 54L;
            var input = new CelsiusLong(12L);

            // Act.
            var result = input.To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(long input)
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        public void Test_to_fahrenheit_generic_from_celsius_with_invalid_parameter_throws_exception(long input)
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Fahrenheit>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            var input = new FahrenheitLong(50L);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            var input = new FahrenheitLong(50L);

            // Act.
            var result = input.To<Fahrenheit>();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 446L;
            var input = new GasLong(7L);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 446L;
            var input = new GasLong(7L);

            // Act.
            var result = input.To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 34L;
            var input = new KelvinLong(274L);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 34L;
            var input = new KelvinLong(274L);

            // Act.
            var result = input.To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = -186L;
            var input = new RankineLong(274L);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = -186L;
            var input = new RankineLong(274L);

            // Act.
            var result = input.To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new CelsiusLong(200L);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(140L, 1L)]
        [InlineData(150L, 2L)]
        [InlineData(165L, 3L)]
        [InlineData(180L, 4L)]
        [InlineData(190L, 5L)]
        [InlineData(200L, 6L)]
        [InlineData(220L, 7L)]
        [InlineData(230L, 8L)]
        [InlineData(240L, 9L)]
        public void Test_to_gas_generic_from_celsius_returns_correct_value(long input, long expected)
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(input);

            // Act.
            var result = inputCelsius.To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new FahrenheitLong(392L);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_generic_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new FahrenheitLong(392L);

            // Act.
            var result = input.To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasLong(7L);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_gas_generic_from_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasLong(7L);

            // Act.
            var result = input.To<Gas>();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_gas_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new KelvinLong(473L);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_generic_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new KelvinLong(473L);

            // Act.
            var result = input.To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new RankineLong(862L);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_generic_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 6L;
            var input = new RankineLong(862L);

            // Act.
            var result = input.To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 473L;
            var input = new CelsiusLong(200L);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_generic_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 473L;
            var input = new CelsiusLong(200L);

            // Act.
            var result = input.To<Kelvin>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_celsius_with_invalid_parameter_throws_exception()
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(long.MaxValue);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToKelvin());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_kelvin_generic_from_celsius_with_invalid_parameter_throws_exception()
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(long.MaxValue);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Kelvin>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 473L;
            var input = new FahrenheitLong(392L);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_generic_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 473L;
            var input = new FahrenheitLong(392L);

            // Act.
            var result = input.To<Kelvin>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 490L;
            var input = new GasLong(6L);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_generic_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 490L;
            var input = new GasLong(6L);

            // Act.
            var result = input.To<Kelvin>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinLong(473L);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_kelvin_generic_from_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinLong(473L);

            // Act.
            var result = input.To<Kelvin>();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_kelvin_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 478L;
            var input = new RankineLong(862L);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_generic_from_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 478L;
            var input = new RankineLong(862L);

            // Act.
            var result = input.To<Kelvin>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            var input = new CelsiusLong(200L);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_generic_from_celsius_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            var input = new CelsiusLong(200L);

            // Act.
            var result = input.To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception()
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(long.MaxValue);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_rankine_generic_from_celsius_with_invalid_parameter_throws_exception()
        {
            // Arrange.
            var inputCelsius = new CelsiusLong(long.MaxValue);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Rankine>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_rankine_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 716L;
            var input = new FahrenheitLong(256L);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const long expected = 716L;
            var input = new FahrenheitLong(256L);

            // Act.
            var result = input.To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 882L;
            var input = new GasLong(6L);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_generic_from_gas_returns_correct_value()
        {
            // Arrange.
            const long expected = 882L;
            var input = new GasLong(6L);

            // Act.
            var result = input.To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 11860L;
            var input = new KelvinLong(6589L);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_generic_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const long expected = 11860L;
            var input = new KelvinLong(6589L);

            // Act.
            var result = input.To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_rankine_returns_same_value()
        {
            // Arrange.
            var input = new RankineLong(862L);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_rankine_generic_from_rankine_returns_same_value()
        {
            // Arrange.
            var input = new RankineLong(862L);

            // Act.
            var result = input.To<Rankine>();

            // Assert.
            result.Should().Be(input.Temperature);
        }
    }
}
