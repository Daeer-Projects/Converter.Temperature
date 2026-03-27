using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, NewtonFloat>
{
        public FromFloatGenericExtensionTests() : base(
            float.MaxValue,
            999.999f,
            0f,
            -999.999f,
            float.MinValue) { }

        protected override NewtonFloat ConvertFrom(
            float value)
        {
            return value.From<Newton>() as NewtonFloat;
        }

        [Fact]
        public void Test_from_newton_generic_returns_newton_float_type()
        {
            // Arrange.
            const float input = 39f;

            // Act.
            FloatBase result = input.From<Newton>();

            // Assert.
            result.Should()
                .BeOfType<NewtonFloat>()
                .Which.Temperature.Should()
                .Be(input);
        }
}
