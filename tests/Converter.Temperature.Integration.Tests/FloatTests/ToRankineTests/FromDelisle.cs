using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300f, 311.670013427734f)]
    [InlineData(150f, 491.670013427734f)]
    [InlineData(0f, 671.669982910156f)]
    public void Test_float_extensions_from_delisle_to_rankine_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromDelisle()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(300f, 311.670013427734f)]
    [InlineData(150f, 491.670013427734f)]
    [InlineData(0f, 671.669982910156f)]
    public void Test_float_extensions_generic_from_delisle_to_rankine_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Delisle>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
