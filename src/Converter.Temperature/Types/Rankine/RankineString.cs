namespace Converter.Temperature.Types.Rankine
{
    using BaseTypes;

    public class RankineString : StringBase
    {
        public RankineString(string temp)
        {
            Temperature = temp;
        }

        public string Temperature { get; }
    }
}
