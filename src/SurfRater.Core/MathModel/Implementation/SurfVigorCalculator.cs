using SurfRater.Core.Data.ValueObjects;
using SurfRater.Core.MathModel.Interfaces;

namespace SurfRater.Core.MathModel.Implementation;

public class BasicSurfVigorCalculator : ISurfVigorCalculator
{
    public WeatherData WeatherData { get; set; }
    public double Result { get; private set; }

    public void Calculate()
    {
        if (WeatherData == null)
        Result = WeatherData.WindSpeed * 0.8 + WeatherData.WaveHeight * 1.2;
    }
}