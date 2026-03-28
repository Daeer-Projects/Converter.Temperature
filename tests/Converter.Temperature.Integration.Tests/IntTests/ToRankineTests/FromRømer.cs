using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000, -2963)]
    [InlineData(0, 466)]
    [InlineData(50, 637)]
    [InlineData(100, 809)]
    [InlineData(500, 2180)]
    [InlineData(1000, 3895)]
    public void Test_int_extension_from_rømer_and_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -2963)]
    [InlineData(0, 466)]
    [InlineData(50, 637)]
    [InlineData(100, 809)]
    [InlineData(500, 2180)]
    [InlineData(1000, 3895)]
    public void Test_int_extension_generic_from_rømer_and_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
