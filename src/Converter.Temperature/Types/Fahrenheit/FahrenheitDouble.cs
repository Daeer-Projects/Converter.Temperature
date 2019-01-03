namespace Converter.Temperature.Types.Fahrenheit
{
    public class FahrenheitDouble
    {
        public FahrenheitDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}