namespace Converter.Temperature.Types.Celsius
{
    using BaseTypes;

    public class CelsiusDouble : DoubleBase
    {
        public CelsiusDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}