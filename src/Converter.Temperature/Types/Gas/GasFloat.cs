namespace Converter.Temperature.Types.Gas
{
    using BaseTypes;

    public class GasFloat : FloatBase
    {
        public GasFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}