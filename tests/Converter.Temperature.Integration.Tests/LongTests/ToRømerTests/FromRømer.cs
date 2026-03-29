using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromRømer
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_rømer_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_generic_from_and_to_rømer_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(value);
    }
}
