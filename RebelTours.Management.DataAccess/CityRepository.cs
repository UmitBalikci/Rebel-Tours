using RebelTours.Domain;
using RebelTours.Management.Application.Repositories;
using RebelTours.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.DataAccess
{
    public class CityRepository : ICityRepository
    {
        public void Create(City city)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Cities.Add(city);
            dbContext.SaveChanges();
        }

        public void Delete(City city)
        {
            var dbContext = new RebelToursDbContext();
            var cityRemove = dbContext.Cities.Find(city.Id);
            dbContext.Remove(cityRemove);
            dbContext.SaveChanges();
        }

        public IEnumerable<City> GetAll()
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.Cities.ToList();
        }

        public City GetById(int id)
        {
            var dbContext = new RebelToursDbContext();
            //return dbContext.Cities.FirstOrDefault(ci => ci.Id == id);
            return dbContext.Cities.Find(id);
        }

        public void Update(City city)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Cities.Update(city);
            dbContext.SaveChanges();
        }
    }
}
