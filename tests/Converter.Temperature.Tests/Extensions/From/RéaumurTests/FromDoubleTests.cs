using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromDoubleTests
{
    [Fact]
    public void Test_From_Newton_Double_Returns_RéaumurDouble_Type()
    {
        // Arrange.
        const double input = 3.3;

        // Act.
        RéaumurDouble result = input.FromRéaumur();

        // Assert.
        result.Should().BeOfType<RéaumurDouble>();
    }

    [Fact]
    public void Test_From_Newton_Double_Returns_Correct_Value()
    {
        // Arrange.
        const double input = 3.3;

        // Act.
        RéaumurDouble result = input.FromRéaumur();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}

