using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests
{
    public class ToKelvinFloatTests
    {
        #region From Celsius


        #endregion From Celsius

        #region From Fahrenheit


        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65f)]
        [InlineData(0.0f)]
        [InlineData(7564.2334f)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_and_to_kelvin_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Kelvin

        #region From Gas



        #endregion From Gas
    }
}
