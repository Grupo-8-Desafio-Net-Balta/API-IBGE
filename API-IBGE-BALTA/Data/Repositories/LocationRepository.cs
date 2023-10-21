﻿using API_IBGE_BALTA.Data.Context;
using API_IBGE_BALTA.Entities;
using API_IBGE_BALTA.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API_IBGE_BALTA.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _context;

        public LocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Location> GetLocationByIdAsync(string id)
        {
            return await _context.Locations.FindAsync(id);
        }

        public async Task<Location> CreateLocationAsync(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return location;
        }

        public async Task<Location> UpdateLocationAsync(string id, Location location)
        {
            var existingLocation = await _context.Locations.FindAsync(id);
            if (existingLocation != null)
            {
                existingLocation.City = location.City;
                existingLocation.State = location.State;
                await _context.SaveChangesAsync();
            }
            return existingLocation;
        }

        public async Task<bool> DeleteLocationAsync(string id)
        {
            var existingLocation = await _context.Locations.FindAsync(id);
            if (existingLocation != null)
            {
                _context.Locations.Remove(existingLocation);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
