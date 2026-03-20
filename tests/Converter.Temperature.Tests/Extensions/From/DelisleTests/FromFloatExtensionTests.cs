namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Delisle;
using Xunit;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, DelisleFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0,
        -999.999f,
        float.MinValue) { }

    protected override DelisleFloat ConvertFrom(
        float value)
    {
        return value.FromDelisle();
    }

    [Fact]
    public void Test_from_delisle_returns_delisle_float_type()
    {
        // Arrange.
        const float input = 39.9f;

        // Act.
        DelisleFloat result = input.FromDelisle();

        // Assert.
        result.Should()
            .BeOfType<DelisleFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
