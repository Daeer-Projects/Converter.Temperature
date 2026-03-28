using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromRømer
{
        [Theory]
    [InlineData(-1000d, -2962.615714285714d)]
    [InlineData(0d, 465.9557142857143d)]
    [InlineData(50d, 637.3842857142857d)]
    [InlineData(100d, 808.8128571428572d)]
    [InlineData(500d, 2180.2414285714285d)]
    [InlineData(1000d, 3894.5271428571427d)]
    public void Test_double_extension_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -2962.615714285714d)]
    [InlineData(0d, 465.9557142857143d)]
    [InlineData(50d, 637.3842857142857d)]
    [InlineData(100d, 808.8128571428572d)]
    [InlineData(500d, 2180.2414285714285d)]
    [InlineData(1000d, 3894.5271428571427d)]
    public void Test_double_extension_generic_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -2962.615714285714d, -1)]
    [InlineData(0d, 465.9557142857143d, -1)]
    [InlineData(50d, 637.3842857142857d, -1)]
    [InlineData(100d, 808.8128571428572d, -1)]
    [InlineData(500d, 2180.2414285714285d, -1)]
    [InlineData(1000d, 3894.5271428571427d, -1)]
    [InlineData(-1000d, -2963d, 0)]
    [InlineData(0d, 466d, 0)]
    [InlineData(50d, 637d, 0)]
    [InlineData(100d, 809d, 0)]
    [InlineData(500d, 2180d, 0)]
    [InlineData(1000d, 3895d, 0)]
    [InlineData(-1000d, -2962.6d, 1)]
    [InlineData(0d, 465.9557142857143d, 13)]
    [InlineData(50d, 637.3843d, 4)]
    [InlineData(100d, 808.8d, 1)]
    [InlineData(500d, 2180.2414286d, 7)]
    [InlineData(1000d, 3894.527142857143d, 14)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -2962.615714285714d, -1)]
    [InlineData(0d, 465.9557142857143d, -1)]
    [InlineData(50d, 637.3842857142857d, -1)]
    [InlineData(100d, 808.8128571428572d, -1)]
    [InlineData(500d, 2180.2414285714285d, -1)]
    [InlineData(1000d, 3894.5271428571427d, -1)]
    [InlineData(-1000d, -2963d, 0)]
    [InlineData(0d, 466d, 0)]
    [InlineData(50d, 637d, 0)]
    [InlineData(100d, 809d, 0)]
    [InlineData(500d, 2180d, 0)]
    [InlineData(1000d, 3895d, 0)]
    [InlineData(-1000d, -2962.6d, 1)]
    [InlineData(0d, 465.9557142857143d, 13)]
    [InlineData(50d, 637.3843d, 4)]
    [InlineData(100d, 808.8d, 1)]
    [InlineData(500d, 2180.2414286d, 7)]
    [InlineData(1000d, 3894.527142857143d, 14)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
