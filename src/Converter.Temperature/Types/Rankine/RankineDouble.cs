namespace Converter.Temperature.Types.Rankine
{
    using BaseTypes;

    public class RankineDouble : DoubleBase
    {
        public RankineDouble(double temp)
        {
            Temperature = temp;
        }

        public double Temperature { get; }
    }
}
