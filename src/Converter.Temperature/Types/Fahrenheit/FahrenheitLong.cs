namespace Converter.Temperature.Types.Fahrenheit
{
    using BaseTypes;

    public sealed class FahrenheitLong : LongBase
    {
        public FahrenheitLong(long temp)
        {
            Temperature = temp;
        }

        public long Temperature { get; }
    }
}
