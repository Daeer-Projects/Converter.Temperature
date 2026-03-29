using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromRømer
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_and_to_rømer_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_and_to_rømer_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(value);
    }
}
