using MeTracker.Core.Interfaces;
using MeTracker.Core.Models;
using MeTracker.Storage.Interfaces;
using SQLite;

namespace MeTracker.Storage.Storages
{
    public class LocationRepository(ILocationMapper locationMapper) : ILocationRepository
    {
        private SQLiteAsyncConnection connection;
        private async Task CreateConnectionAsync()
        {
            if (connection != null)
            {
                return;
            }
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Locations.db");
            connection = new SQLiteAsyncConnection(databasePath);
            await connection.CreateTableAsync<Location>();
        }

        public async Task SaveAsync(Location location)
        {
            var locationEntity = locationMapper.Map(location);
            location.Id = locationEntity.Id;    
            await CreateConnectionAsync();
            await connection.InsertAsync(locationEntity);
        }
    }
}