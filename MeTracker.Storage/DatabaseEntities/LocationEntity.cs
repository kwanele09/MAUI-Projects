using SQLite;

namespace MeTracker.Storage.DatabaseEntities
{
    public class LocationEntity
    {
        [PrimaryKeyAttribute, AutoIncrement]
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public LocationEntity(){}
        public LocationEntity(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
    }
}
