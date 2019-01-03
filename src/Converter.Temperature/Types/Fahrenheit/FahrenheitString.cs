namespace Converter.Temperature.Types.Fahrenheit
{
    public class FahrenheitString
    {
        public FahrenheitString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}