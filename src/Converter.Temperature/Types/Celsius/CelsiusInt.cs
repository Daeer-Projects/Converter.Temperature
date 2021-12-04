namespace Converter.Temperature.Types.Celsius
{
    using BaseTypes;

    public class CelsiusInt : IntBase
    {
        public CelsiusInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}