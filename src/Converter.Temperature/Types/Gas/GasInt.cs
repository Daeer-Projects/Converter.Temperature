namespace Converter.Temperature.Types.Gas
{
    public class GasInt
    {
        public GasInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}