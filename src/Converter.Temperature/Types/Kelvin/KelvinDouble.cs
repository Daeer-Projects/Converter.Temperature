namespace Converter.Temperature.Types.Kelvin
{
    public class KelvinDouble
    {
        public KelvinDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}