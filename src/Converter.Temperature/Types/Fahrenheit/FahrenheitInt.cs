namespace Converter.Temperature.Types.Fahrenheit
{
    public class FahrenheitInt
    {
        public FahrenheitInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}