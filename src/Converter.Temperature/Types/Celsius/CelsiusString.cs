namespace Converter.Temperature.Types.Celsius
{
    public class CelsiusString
    {
        public CelsiusString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}