using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext dc;

        public CityRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void addCity(City city)
        {
            dc.Cities.Add(city);
        }

        public void deleteCity(int cityId)
        {
            var id = dc.Cities.Find(cityId);
            dc.Cities.Remove(id);
        }

        public async Task<City> findCityAsync(int id)
        {
            return await dc.Cities.FindAsync(id);
        }
        public async Task<IList<City>> getCitiesAsync()
        {
            return await dc.Cities.ToListAsync();
        }
    }
    public interface ICityRepository
    {
        void addCity(City city);
        void deleteCity(int cityId);
        Task<City> findCityAsync(int id);
        Task<IList<City>> getCitiesAsync();
    }
}
