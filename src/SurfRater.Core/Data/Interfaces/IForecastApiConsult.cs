using SurfRater.Core.Data.ValueObjects;

namespace SurfRater.Core.Data.Interfaces;

public interface IForecastApiConsult
{
    public Coordinate Coordinate { get; set; }
}