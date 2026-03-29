using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, NewtonDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override NewtonDouble ConvertFrom(
        double value)
    {
        return value.FromNewton();
    }

    [Fact]
    public void Test_from_newton_returns_newton_double_Type()
    {
        // Arrange.
        const double input = 10.0;

        // Act.
        NewtonDouble result = input.FromNewton();

        // Assert.
        result.Should().BeOfType<NewtonDouble>();
    }

    [Fact]
    public void Test_from_newton_returns_correct_value()
    {
        // Arrange.
        const double input = 10.0;

        // Act.
        NewtonDouble result = input.FromNewton();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}
