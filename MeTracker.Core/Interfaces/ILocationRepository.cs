using MeTracker.Core.Models;

namespace MeTracker.Core.Interfaces
{
    public interface ILocationRepository
    {
        Task SaveAsync(Location location);
    }
}
