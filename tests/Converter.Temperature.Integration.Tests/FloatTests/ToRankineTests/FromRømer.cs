using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000f, -2962.615714285714f)]
    [InlineData(0f, 465.9557142857143f)]
    [InlineData(50f, 637.3842857142857f)]
    [InlineData(100f, 808.8128571428572f)]
    [InlineData(500f, 2180.2414285714285f)]
    [InlineData(1000f, 3894.5271428571427f)]
    public void Test_float_extension_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -2962.615714285714f)]
    [InlineData(0f, 465.9557142857143f)]
    [InlineData(50f, 637.3842857142857f)]
    [InlineData(100f, 808.8128571428572f)]
    [InlineData(500f, 2180.2414285714285f)]
    [InlineData(1000f, 3894.5271428571427f)]
    public void Test_float_extension_generic_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -2962.615714285714f, -1)]
    [InlineData(0f, 465.9557142857143f, -1)]
    [InlineData(50f, 637.3842857142857f, -1)]
    [InlineData(100f, 808.8128571428572f, -1)]
    [InlineData(500f, 2180.2414285714285f, -1)]
    [InlineData(1000f, 3894.5271428571427f, -1)]
    [InlineData(-1000f, -2963f, 0)]
    [InlineData(0f, 466f, 0)]
    [InlineData(50f, 637f, 0)]
    [InlineData(100f, 809f, 0)]
    [InlineData(500f, 2180f, 0)]
    [InlineData(1000f, 3895f, 0)]
    [InlineData(-1000f, -2962.6f, 1)]
    [InlineData(0f, 465.9557142857143f, 13)]
    [InlineData(50f, 637.3843f, 4)]
    [InlineData(100f, 808.8f, 1)]
    [InlineData(500f, 2180.2414286f, 7)]
    [InlineData(1000f, 3894.527142857143f, 14)]
    public void Test_float_extension_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -2962.615714285714f, -1)]
    [InlineData(0f, 465.9557142857143f, -1)]
    [InlineData(50f, 637.3842857142857f, -1)]
    [InlineData(100f, 808.8128571428572f, -1)]
    [InlineData(500f, 2180.2414285714285f, -1)]
    [InlineData(1000f, 3894.5271428571427f, -1)]
    [InlineData(-1000f, -2963f, 0)]
    [InlineData(0f, 466f, 0)]
    [InlineData(50f, 637f, 0)]
    [InlineData(100f, 809f, 0)]
    [InlineData(500f, 2180f, 0)]
    [InlineData(1000f, 3895f, 0)]
    [InlineData(-1000f, -2962.6f, 1)]
    [InlineData(0f, 465.9557142857143f, 13)]
    [InlineData(50f, 637.3843f, 4)]
    [InlineData(100f, 808.8f, 1)]
    [InlineData(500f, 2180.2414286f, 7)]
    [InlineData(1000f, 3894.527142857143f, 14)]
    public void Test_float_extension_generic_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
