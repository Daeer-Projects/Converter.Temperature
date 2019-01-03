namespace Converter.Temperature.Types.Kelvin
{
    public class KelvinFloat
    {
        public KelvinFloat(float temp)
        {
            Temperature = temp;
        }

        public float Temperature { get; }
    }
}