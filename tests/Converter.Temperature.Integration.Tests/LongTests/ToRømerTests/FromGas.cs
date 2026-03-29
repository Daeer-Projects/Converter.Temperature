using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromGas
{
    [Fact]
    public void Test_long_extension_from_gas_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 121L;
        const long input = 6L;

        // Act.
        long result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_gas_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 121L;
        const long input = 6L;

        // Act.
        long result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
