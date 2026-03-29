using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromGas
{
    [Fact]
    public void Test_float_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67f;
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67f;
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
