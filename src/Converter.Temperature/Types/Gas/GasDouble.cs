namespace Converter.Temperature.Types.Gas
{
    public class GasDouble
    {
        public GasDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}