﻿using API_IBGE_BALTA.Entities;

namespace API_IBGE_BALTA.Interfaces.Repositories
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetLocationsAsync();
        Task<Location> GetLocationByIdAsync(string id);
        Task<Location> CreateLocationAsync(Location location);
        Task<Location> UpdateLocationAsync(string id, Location location);
        Task<bool> DeleteLocationAsync(string id);
    }

}
