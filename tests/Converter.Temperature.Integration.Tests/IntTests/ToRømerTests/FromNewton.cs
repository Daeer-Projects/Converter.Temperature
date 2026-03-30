using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33, -45)]
    [InlineData(0, 8)]
    [InlineData(33, 60)]
    public void Test_int_extensions_from_newton_to_rømer_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromNewton()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33, -45)]
    [InlineData(0, 8)]
    [InlineData(33, 60)]
    public void Test_int_extensions_generic_from_newton_to_rømer_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Newton>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
