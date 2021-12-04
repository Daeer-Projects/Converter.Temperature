namespace Converter.Temperature.Types.Gas
{
    using BaseTypes;

    public class GasString : StringBase
    {
        public GasString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}