namespace Converter.Temperature.Types.Celsius
{
    public class CelsiusInt
    {
        public CelsiusInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}