using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300, -45)]
    [InlineData(150, 8)]
    [InlineData(0, 60)]
    public void Test_int_extensions_from_delisle_to_rømer_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromDelisle()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300, -45)]
    [InlineData(150, 8)]
    [InlineData(0, 60)]
    public void Test_int_extensions_generic_from_delisle_to_rømer_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Delisle>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
