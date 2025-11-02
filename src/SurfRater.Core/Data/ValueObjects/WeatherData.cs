namespace SurfRater.Core.Data.ValueObjects;

/// <summary>
/// Represents weather and ocean condition data used for surf rating calculations.
/// </summary>
public class WeatherData
{
    /// <summary>
    /// Location name where the data was collected.
    /// </summary>
    public Coordinate Location { get; set; }

    /// <summary>
    /// The timestamp of the weather data reading.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Wind speed, typically in km/h or m/s.
    /// </summary>
    public double WindSpeed { get; set; }

    /// <summary>
    /// Wave height in meters.
    /// </summary>
    public double WaveHeight { get; set; }

    /// <summary>
    /// Water temperature in degrees Celsius.
    /// </summary>
    public double WaterTemperature { get; set; }

    /// <summary>
    /// Air temperature in degrees Celsius.
    /// </summary>
    public double AirTemperature { get; set; }
}