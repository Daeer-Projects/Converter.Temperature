namespace Converter.Temperature.Types.Kelvin
{
    public class KelvinString
    {
        public KelvinString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}