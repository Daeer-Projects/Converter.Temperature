namespace Converter.Temperature.Types.Celsius
{
    using BaseTypes;

    public class CelsiusFloat : FloatBase
    {
        public CelsiusFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}