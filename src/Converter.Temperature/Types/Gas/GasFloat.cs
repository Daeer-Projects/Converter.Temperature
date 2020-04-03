namespace Converter.Temperature.Types.Gas
{
    public class GasFloat
    {
        public GasFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}