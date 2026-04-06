using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToNewtonTests;

public class FromRømer
{
    [Theory]
    [InlineData(60, 33)]
    [InlineData(7, 0)]
    [InlineData(int.MinValue, -1349846869)]
    [InlineData(int.MaxValue, 1349846859)]
    public void Test_int_extension_from_rømer_to_newton_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(60, 33)]
    [InlineData(7, 0)]
    [InlineData(int.MinValue, -1349846869)]
    [InlineData(int.MaxValue, 1349846859)]
    public void Test_int_extension_generic_from_rømer_to_newton_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.From<Rømer>().To<Newton>();

        // Assert.
        result.Should().Be(expected);
    }

}
