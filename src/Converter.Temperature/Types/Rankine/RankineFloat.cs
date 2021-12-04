namespace Converter.Temperature.Types.Rankine
{
    using BaseTypes;

    public class RankineFloat : FloatBase
    {
        public RankineFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}
