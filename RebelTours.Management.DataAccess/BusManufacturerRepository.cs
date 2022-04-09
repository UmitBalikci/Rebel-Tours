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
    public class BusManufacturerRepository : IBusManufacturerRepository
    {
        public void Create(BusManufacturer busManufacturer)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.BusManufacturers.Add(busManufacturer);
            dbContext.SaveChanges();
        }

        public void Delete(BusManufacturer busManufacturer)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Remove(busManufacturer);
            dbContext.SaveChanges();
        }

        public IEnumerable<BusManufacturer> GetAll()
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.BusManufacturers.ToList();
        }

        public BusManufacturer GetById(int id)
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.BusManufacturers.Find(id);
        }

        public void Update(BusManufacturer busManufacturer)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Update(busManufacturer);
            dbContext.SaveChanges();
        }
    }
}
