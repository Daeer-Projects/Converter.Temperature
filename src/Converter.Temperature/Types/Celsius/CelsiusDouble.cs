namespace Converter.Temperature.Types.Celsius
{
    public class CelsiusDouble
    {
        public CelsiusDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}