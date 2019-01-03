namespace Converter.Temperature.Types.Fahrenheit
{
    public class FahrenheitFloat
    {
        public FahrenheitFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}