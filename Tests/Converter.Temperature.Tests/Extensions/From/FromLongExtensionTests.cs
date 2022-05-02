﻿namespace Converter.Temperature.Tests.Extensions.From
{
    using FluentAssertions;
    using Temperature.Extensions.From;
    using TemperatureTypes;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;
    using Xunit;

    public class FromLongExtensionTests
    {
        [Fact]
        public void Test_from_celsius_returns_celsius_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.FromCelsius();

            // Assert.
            result.Should().BeOfType<CelsiusLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_celsius_generic_returns_celsius_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.From<Celsius>();

            // Assert.
            result.Should().BeOfType<CelsiusLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_fahrenheit_returns_fahrenheit_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.FromFahrenheit();

            // Assert.
            result.Should().BeOfType<FahrenheitLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_fahrenheit_generic_returns_fahrenheit_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.From<Fahrenheit>();

            // Assert.
            result.Should().BeOfType<FahrenheitLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_gas_returns_gas_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.FromGas();

            // Assert.
            result.Should().BeOfType<GasLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_gas_generic_returns_gas_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.From<Gas>();

            // Assert.
            result.Should().BeOfType<GasLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_kelvin_returns_kelvin_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.FromKelvin();

            // Assert.
            result.Should().BeOfType<KelvinLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_kelvin_generic_returns_kelvin_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.From<Kelvin>();

            // Assert.
            result.Should().BeOfType<KelvinLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_rankine_returns_rankine_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.FromRankine();

            // Assert.
            result.Should().BeOfType<RankineLong>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_rankine_generic_returns_rankine_long_type()
        {
            // Arrange.
            const long input = 39L;

            // Act.
            var result = input.From<Rankine>();

            // Assert.
            result.Should().BeOfType<RankineLong>().Which.Temperature.Should().Be(input);
        }
    }
}
