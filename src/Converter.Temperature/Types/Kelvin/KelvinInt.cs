namespace Converter.Temperature.Types.Kelvin
{
    public class KelvinInt
    {
        public KelvinInt(int temp)
        {
            Temperature = temp;
        }

        public int Temperature { get; }
    }
}