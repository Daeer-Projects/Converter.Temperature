namespace Converter.Temperature.Types.Kelvin
{
    using BaseTypes;

    public sealed class KelvinFloat : FloatBase
    {
        public KelvinFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}