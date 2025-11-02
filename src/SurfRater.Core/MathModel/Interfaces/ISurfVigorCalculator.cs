using SurfRater.Core.Data.ValueObjects;

namespace SurfRater.Core.MathModel.Interfaces;

public interface ISurfVigorCalculator
{
    WeatherData WeatherData { get; set; }
    double Result { get; }
    void Calculate();
}