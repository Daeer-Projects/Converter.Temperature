namespace Converter.Temperature.Tests.Extensions.From;

using BaseTypes;
using FluentAssertions;
using Xunit;

public abstract class BaseFromExtensionTests<TInputType, TOutputType>
    where TOutputType : TypeBase<TInputType>
{
    protected BaseFromExtensionTests(
        TInputType highValue,
        TInputType midHighValue,
        TInputType midValue,
        TInputType midLowValue,
        TInputType lowValue)
    {
        _highValue = highValue;
        _midHighValue = midHighValue;
        _midValue = midValue;
        _midLowValue = midLowValue;
        _lowValue = lowValue;
    }

    private readonly TInputType _highValue;
    private readonly TInputType _lowValue;
    private readonly TInputType _midHighValue;
    private readonly TInputType _midLowValue;
    private readonly TInputType _midValue;

    protected abstract TOutputType ConvertFrom(
        TInputType value);

    [Fact]
    public void Test_from_with_high_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(_highValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(_highValue);
    }

    [Fact]
    public void Test_from_with_mid_high_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(_midHighValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(_midHighValue);
    }

    [Fact]
    public void Test_from_with_mid_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(_midValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(_midValue);
    }

    [Fact]
    public void Test_from_with_mid_low_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(_midLowValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(_midLowValue);
    }

    [Fact]
    public void Test_from_with_low_value_returns_expected_type_and_temperature()
    {
        // Arrange.
        // Act.
        TOutputType result = ConvertFrom(_lowValue);

        // Assert.
        result.Should()
            .BeOfType<TOutputType>()
            .Which.Temperature.Should()
            .Be(_lowValue);
    }
}
