using MeTracker.Core.Models;
using MeTracker.Storage.DatabaseEntities;
using MeTracker.Storage.Interfaces;

namespace MeTracker.Storage.Mappers
{
    public class LocationMapper : ILocationMapper
    {
        public LocationEntity Map(Location location)
        {
            return new LocationEntity
            {
                Id = location.Id,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
            };
        }

        public Location Map(LocationEntity locationEntity)
        {
            return new Location
            {
                Id = locationEntity.Id,
                Latitude = locationEntity.Latitude,
                Longitude = locationEntity.Longitude,
            };
        }
    }
}