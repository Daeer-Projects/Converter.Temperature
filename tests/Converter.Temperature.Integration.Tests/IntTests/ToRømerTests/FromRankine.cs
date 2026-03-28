using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000, -428)]
    [InlineData(0, -136)]
    [InlineData(50, -121)]
    [InlineData(100, -107)]
    [InlineData(500, 10)]
    [InlineData(1000, 156)]
    public void Test_int_extension_from_rankine_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -428)]
    [InlineData(0, -136)]
    [InlineData(50, -121)]
    [InlineData(100, -107)]
    [InlineData(500, 10)]
    [InlineData(1000, 156)]
    public void Test_int_extension_generic_from_rankine_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
