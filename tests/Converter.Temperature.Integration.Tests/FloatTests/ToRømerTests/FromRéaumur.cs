using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRømerTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80f, -45f)]
    [InlineData(0f, 7.5f)]
    [InlineData(80f, 60f)]
    public void Test_float_extensions_from_réaumur_to_rømer_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRéaumur()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-80f, -45f)]
    [InlineData(0f, 7.5f)]
    [InlineData(80f, 60f)]
    public void Test_float_extensions_generic_from_réaumur_to_rømer_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Réaumur>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
