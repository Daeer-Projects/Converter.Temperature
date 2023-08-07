namespace Converter.Temperature.Tests.Extensions.From;

using BaseTypes;
using FluentAssertions;
using Xunit;

public abstract class BaseFromExtensionTests<TInputType, TOutputType>
    where TInputType : struct
    where TOutputType : TypeBase<TInputType>
{
    protected virtual TInputType HighValue { get; }
    protected virtual TInputType MidHighValue { get; }
    protected virtual TInputType MidValue { get; }
    protected virtual TInputType MidLowValue { get; }
    protected virtual TInputType LowValue { get; }

    protected abstract TOutputType ConvertFrom(
        TInputType value);

    [Fact]
    public void Test_from_with_high_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(HighValue);


        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(HighValue);
    }

    [Fact]
    public void Test_from_with_mid_high_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(MidHighValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(MidHighValue);
    }

    [Fact]
    public void Test_from_with_mid_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(MidValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(MidValue);
    }

    [Fact]
    public void Test_from_with_mid_low_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(MidLowValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(MidLowValue);
    }

    [Fact]
    public void Test_from_with_low_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(LowValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(LowValue);
    }
}
