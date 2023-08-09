namespace Converter.Temperature.Tests.Extensions.To;

using System;
using FluentAssertions;
using Xunit;

public abstract class BaseToExtensionTests<TInputTemp, TResultType>
{
    private readonly TResultType _highValue;
    private readonly TResultType _lowValue;
    private readonly TResultType _midHighValue;
    private readonly TResultType _midLowValue;
    private readonly TResultType _midValue;

    protected BaseToExtensionTests(
        TResultType highValue,
        TResultType midHighValue,
        TResultType midValue,
        TResultType midLowValue,
        TResultType lowValue)
    {
        _highValue = highValue;
        _midHighValue = midHighValue;
        _midValue = midValue;
        _midLowValue = midLowValue;
        _lowValue = lowValue;
    }

    protected abstract TResultType To(
        TInputTemp value,
        int fractionalCount);

    protected abstract TInputTemp Create(
        TResultType value);

    [Fact]
    public void Test_to_output_type_with_too_long_parameter_from_input_type_throws_exception()
    {
        // Arrange.
        TInputTemp input = Create(_midHighValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => To(input, 16));

        // Assert.
        result.Message.Should()
            .Contain("Rounding digits must be between 0 and 15, inclusive.");
    }
}
