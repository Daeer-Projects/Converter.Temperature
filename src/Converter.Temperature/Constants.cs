namespace Converter.Temperature;

/// <summary>
///     A collection of constant messages exposed to the user.
/// </summary>
public static class Constants
{
    /// <summary>
    ///     <see cref="Temperature" /> out of range error message.
    /// </summary>
    public const string TemperatureOutOfRangeError = "Temp too low or too high for gas mark!";

    /// <summary>
    ///     <see cref="Temperature" /> too high error message.
    /// </summary>
    public const string TemperatureTooHighForGasError = "Temp too high for gas mark!";

    /// <summary>
    ///     <see cref="Temperature" /> too low error message.
    /// </summary>
    public const string TemperatureTooLowForGasError = "Temp too low for gas mark!";

    /// <summary>
    ///     Value out of range message.
    /// </summary>
    public const string ValueOutOfRangeForType = "Value out of range for type.";
}