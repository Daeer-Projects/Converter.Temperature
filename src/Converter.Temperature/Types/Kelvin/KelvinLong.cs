namespace Converter.Temperature.Types.Kelvin
{
    using BaseTypes;

    public sealed class KelvinLong : LongBase
    {
        public KelvinLong(long temp)
        {
            Temperature = temp;
        }

        public long Temperature { get; }
    }
}
