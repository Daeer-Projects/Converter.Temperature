namespace Converter.Temperature.Types.Fahrenheit
{
    using BaseTypes;

    public class FahrenheitInt : IntBase
    {
        public FahrenheitInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}