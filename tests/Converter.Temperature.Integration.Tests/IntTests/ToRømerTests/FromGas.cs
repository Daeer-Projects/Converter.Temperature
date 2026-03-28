using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromGas
{
    [Fact]
    public void Test_int_extension_from_gas_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 121;
        const int input = 6;

        // Act.
        int result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_gas_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 121;
        const int input = 6;

        // Act.
        int result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
