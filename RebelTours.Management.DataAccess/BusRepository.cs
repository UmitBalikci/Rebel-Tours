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
    public class BusRepository : IBusRepository
    {
        public void Create(Bus bus)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Buses.Add(bus);
            dbContext.SaveChanges();
        }

        public void Delete(Bus bus)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Buses.Remove(bus);
            dbContext.SaveChanges();
        }

        public IEnumerable<Bus> GetAll()
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.Buses.ToList();
        }

        public Bus GetById(int id)
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.Buses.Find(id);
        }

        public void Update(Bus bus)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Buses.Update(bus);
            dbContext.SaveChanges();
        }
    }
}
