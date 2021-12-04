namespace Converter.Temperature.Types.Kelvin
{
    using BaseTypes;

    public class KelvinInt : IntBase
    {
        public KelvinInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}