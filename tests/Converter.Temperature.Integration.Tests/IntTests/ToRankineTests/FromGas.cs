using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromGas
{
    [Fact]
    public void Test_int_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 882;
        const int input = 6;

        // Act.
        int result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 882;
        const int input = 6;

        // Act.
        int result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
