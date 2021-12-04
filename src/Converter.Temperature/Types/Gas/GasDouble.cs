namespace Converter.Temperature.Types.Gas
{
    using BaseTypes;

    public class GasDouble : DoubleBase
    {
        public GasDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}