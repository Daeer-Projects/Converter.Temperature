namespace Converter.Temperature.Types.Gas
{
    public class GasString
    {
        public GasString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}