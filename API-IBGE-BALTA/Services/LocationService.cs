using API_IBGE_BALTA.Entities;
using API_IBGE_BALTA.Interfaces.Repositories;
using API_IBGE_BALTA.Interfaces.Services;

namespace API_IBGE_BALTA.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return await _locationRepository.GetLocationsAsync();
        }

        public async Task<Location> GetLocationByIdAsync(string id)
        {
            return await _locationRepository.GetLocationByIdAsync(id);
        }

        public async Task<Location> CreateLocationAsync(Location location)
        {
            return await _locationRepository.CreateLocationAsync(location);
        }

        public async Task<Location> UpdateLocationAsync(string id, Location location)
        {
            return await _locationRepository.UpdateLocationAsync(id, location);
        }

        public async Task<bool> DeleteLocationAsync(string id)
        {
            return await _locationRepository.DeleteLocationAsync(id);
        }
    }

}
