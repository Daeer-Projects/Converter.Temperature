namespace Converter.Temperature.Types.Kelvin
{
    using BaseTypes;

    public class KelvinString : StringBase
    {
        public KelvinString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}