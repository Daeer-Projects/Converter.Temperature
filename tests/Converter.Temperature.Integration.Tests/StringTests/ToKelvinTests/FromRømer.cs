using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToKelvinTests;

public class FromRømer
{
        [Theory]
    [InlineData(-1000d, -1645.8976190476192d)]
    [InlineData(0d, 258.8642857142857d)]
    [InlineData(50d, 354.10238095238094d)]
    [InlineData(100d, 449.3404761904762d)]
    [InlineData(500d, 1211.2452380952382d)]
    [InlineData(1000d, 2163.6261904761905d)]
    public void Test_double_extension_from_rømer_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRømer()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -1645.8976190476192d)]
    [InlineData(0d, 258.8642857142857d)]
    [InlineData(50d, 354.10238095238094d)]
    [InlineData(100d, 449.3404761904762d)]
    [InlineData(500d, 1211.2452380952382d)]
    [InlineData(1000d, 2163.6261904761905d)]
    public void Test_double_extension_generic_from_rømer_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rømer>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -1645.8976190476192d, -1)]
    [InlineData(0d, 258.8642857142857d, -1)]
    [InlineData(50d, 354.10238095238094d, -1)]
    [InlineData(100d, 449.3404761904762d, -1)]
    [InlineData(500d, 1211.2452380952382d, -1)]
    [InlineData(1000d, 2163.6261904761905d, -1)]
    [InlineData(-1000d, -1646d, 0)]
    [InlineData(0d, 259d, 0)]
    [InlineData(50d, 354d, 0)]
    [InlineData(100d, 449d, 0)]
    [InlineData(500d, 1211d, 0)]
    [InlineData(1000d, 2164d, 0)]
    [InlineData(-1000d, -1645.9d, 1)]
    [InlineData(0d, 258.8642857142857d, 13)]
    [InlineData(50d, 354.1024d, 4)]
    [InlineData(100d, 449.3d, 1)]
    [InlineData(500d, 1211.2452381d, 7)]
    [InlineData(1000d, 2163.6261904761905d, 14)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRømer()
            .ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -1645.8976190476192d, -1)]
    [InlineData(0d, 258.8642857142857d, -1)]
    [InlineData(50d, 354.10238095238094d, -1)]
    [InlineData(100d, 449.3404761904762d, -1)]
    [InlineData(500d, 1211.2452380952382d, -1)]
    [InlineData(1000d, 2163.6261904761905d, -1)]
    [InlineData(-1000d, -1646d, 0)]
    [InlineData(0d, 259d, 0)]
    [InlineData(50d, 354d, 0)]
    [InlineData(100d, 449d, 0)]
    [InlineData(500d, 1211d, 0)]
    [InlineData(1000d, 2164d, 0)]
    [InlineData(-1000d, -1645.9d, 1)]
    [InlineData(0d, 258.8642857142857d, 13)]
    [InlineData(50d, 354.1024d, 4)]
    [InlineData(100d, 449.3d, 1)]
    [InlineData(500d, 1211.2452381d, 7)]
    [InlineData(1000d, 2163.6261904761905d, 14)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rømer>()
            .To<Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
