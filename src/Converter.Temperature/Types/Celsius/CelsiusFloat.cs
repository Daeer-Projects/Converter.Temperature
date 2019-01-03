namespace Converter.Temperature.Types.Celsius
{
    public class CelsiusFloat
    {
        public CelsiusFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}