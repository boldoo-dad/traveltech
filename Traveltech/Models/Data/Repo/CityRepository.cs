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
        public void AddCity(City city)
        {
            dc.Cities.Add(city);
        }

        public void DeleteCity(int cityId)
        {
            var id = dc.Cities.Find(cityId);
            dc.Cities.Remove(id);
        }

        public async Task<City> FindCityAsync(int id)
        {
            return await dc.Cities.FindAsync(id);
        }
        public async Task<IList<City>> GetCitiesAsync()
        {
            return await dc.Cities.ToListAsync();
        }
    }
    public interface ICityRepository
    {
        void AddCity(City city);
        void DeleteCity(int cityId);
        Task<City> FindCityAsync(int id);
        Task<IList<City>> GetCitiesAsync();
    }
}
