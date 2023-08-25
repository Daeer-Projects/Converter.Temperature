﻿namespace Converter.Temperature.Tests.Extensions.To;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

public abstract class BaseToExtensionTests<TInputTemp, TResultType>
{
    private readonly List<TResultType> _data;
    private readonly TResultType _defaultValue;

    protected BaseToExtensionTests(
        TResultType defaultValue,
        List<TResultType> data)
    {
        _defaultValue = defaultValue;
        _data = data;
    }

    protected abstract TResultType To(
        TInputTemp value,
        int fractionalCount);

    protected abstract TResultType ToUsingGeneric(
        TInputTemp value,
        int fractionalCount);

    protected abstract TInputTemp Create(
        TResultType value);

    [Fact]
    public void Test_to_output_type_with_too_long_parameter_from_input_type_throws_exception()
    {
        // Arrange.
        TInputTemp input = Create(_defaultValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => To(input, 16));

        // Assert.
        result.Message.Should()
            .Contain("Rounding digits must be between 0 and 15, inclusive.");
    }

    [Fact]
    public void Test_to_with_same_type_returns_same_value()
    {
        foreach (TResultType testValue in _data)
        {
            ActualTestForSameValue(testValue);
            ActualTestForSameValueGeneric(testValue);
        }
    }

    private void ActualTestForSameValue(
        TResultType inputAndExpectedValue)
    {
        // Arrange.
        TInputTemp input = Create(inputAndExpectedValue);

        // Act.
        TResultType actual = To(input, -1);

        // Assert.
        actual.Should().Be(inputAndExpectedValue);
    }

    private void ActualTestForSameValueGeneric(
        TResultType inputAndExpectedValue)
    {
        // Arrange.
        TInputTemp input = Create(inputAndExpectedValue);

        // Act.
        TResultType actual = ToUsingGeneric(input, -1);

        // Assert.
        actual.Should().Be(inputAndExpectedValue);
    }
}
