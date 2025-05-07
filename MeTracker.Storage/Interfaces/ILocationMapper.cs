using MeTracker.Core.Models;
using MeTracker.Storage.DatabaseEntities;

namespace MeTracker.Storage.Interfaces
{
    public interface ILocationMapper
    {
        LocationEntity Map(Location location);
        Location Map(LocationEntity locationEntity);
    }
}