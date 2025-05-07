using MeTracker.Core.Interfaces;

namespace MeTracker.Core.Services
{
    public partial class LocationTrackingService : ILocationTrackingService
    {
        public void StartTracking()
        {
            StartTrackingInternal();
        }

        partial void StartTrackingInternal();
    }
}
