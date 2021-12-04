namespace Converter.Temperature.Types.Celsius
{
    using BaseTypes;

    public class CelsiusString : StringBase
    {
        public CelsiusString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}