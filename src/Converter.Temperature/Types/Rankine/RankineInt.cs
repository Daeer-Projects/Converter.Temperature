namespace Converter.Temperature.Types.Rankine;

using BaseTypes;

public sealed class RankineInt : IntBase
{
    public RankineInt(int temp)
    {
        Temperature = temp;
    }

    public int Temperature { get; }
}