using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromGas
{
    [Fact]
    public void Test_string_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        const string input = "6";

        // Act.
        string result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        const string input = "6";

        // Act.
        string result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
