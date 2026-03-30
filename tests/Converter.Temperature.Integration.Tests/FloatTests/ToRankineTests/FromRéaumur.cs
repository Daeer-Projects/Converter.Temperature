using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80f, 311.670013427734f)]
    [InlineData(0f, 491.670013427734f)]
    [InlineData(80f, 671.669982910156f)]
    public void Test_float_extensions_from_réaumur_to_rankine_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-80f, 311.670013427734f)]
    [InlineData(0f, 491.670013427734f)]
    [InlineData(80f, 671.669982910156f)]
    public void Test_float_extensions_generic_from_réaumur_to_rankine_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
