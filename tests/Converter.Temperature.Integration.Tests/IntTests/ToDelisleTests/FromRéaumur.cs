using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, 300)]
    [InlineData(0, 150)]
    [InlineData(80, 0)]
    public void Test_int_extensions_from_réaumur_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, 300)]
    [InlineData(0, 150)]
    [InlineData(80, 0)]
    public void Test_int_extensions_generic_from_réaumur_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
