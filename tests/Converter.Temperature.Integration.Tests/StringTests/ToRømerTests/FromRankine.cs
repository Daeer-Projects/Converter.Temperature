using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRømerTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000d, -427.5704166666667d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -121.32041666666666d)]
    [InlineData(100d, -106.73708333333333d)]
    [InlineData(500d, 9.929583333333328d)]
    [InlineData(1000d, 155.76291666666665d)]
    public void Test_string_extension_from_rankine_to_rømer_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -427.5704166666667d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -121.32041666666666d)]
    [InlineData(100d, -106.73708333333333d)]
    [InlineData(500d, 9.929583333333328d)]
    [InlineData(1000d, 155.76291666666665d)]
    public void Test_string_extension_generic_from_rankine_to_rømer_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -427.5704166666667d, -1)]
    [InlineData(0d, -135.90375d, -1)]
    [InlineData(50d, -121.32041666666666d, -1)]
    [InlineData(100d, -106.73708333333333d, -1)]
    [InlineData(500d, 9.929583333333328d, -1)]
    [InlineData(1000d, 155.76291666666665d, -1)]
    [InlineData(-1000d, -428d, 0)]
    [InlineData(0d, -136d, 0)]
    [InlineData(50d, -121d, 0)]
    [InlineData(100d, -107d, 0)]
    [InlineData(500d, 10d, 0)]
    [InlineData(1000d, 156d, 0)]
    [InlineData(-1000d, -427.6d, 1)]
    [InlineData(0d, -135.90375d, 13)]
    [InlineData(50d, -121.3204d, 4)]
    [InlineData(100d, -106.7d, 1)]
    [InlineData(500d, 9.9295833d, 7)]
    [InlineData(1000d, 155.76291666666665d, 14)]
    public void Test_string_extension_with_parameter_from_rankine_to_rømer_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToRømer(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -427.5704166666667d, -1)]
    [InlineData(0d, -135.90375d, -1)]
    [InlineData(50d, -121.32041666666666d, -1)]
    [InlineData(100d, -106.73708333333333d, -1)]
    [InlineData(500d, 9.929583333333328d, -1)]
    [InlineData(1000d, 155.76291666666665d, -1)]
    [InlineData(-1000d, -428d, 0)]
    [InlineData(0d, -136d, 0)]
    [InlineData(50d, -121d, 0)]
    [InlineData(100d, -107d, 0)]
    [InlineData(500d, 10d, 0)]
    [InlineData(1000d, 156d, 0)]
    [InlineData(-1000d, -427.6d, 1)]
    [InlineData(0d, -135.90375d, 13)]
    [InlineData(50d, -121.3204d, 4)]
    [InlineData(100d, -106.7d, 1)]
    [InlineData(500d, 9.9295833d, 7)]
    [InlineData(1000d, 155.76291666666665d, 14)]
    public void Test_string_extension_generic_with_parameter_from_rankine_to_rømer_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Rømer>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
