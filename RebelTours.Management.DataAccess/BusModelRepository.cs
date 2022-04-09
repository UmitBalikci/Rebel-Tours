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
    public class BusModelRepository : IBusModelRepository
    {
        public void Create(BusModel busModel)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.BusModels.Add(busModel);
            dbContext.SaveChanges();
        }

        public void Delete(BusModel busModel)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.BusModels.Remove(busModel);
            dbContext.SaveChanges();
        }

        public IEnumerable<BusModel> GetAll()
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.BusModels.ToList();
        }

        public BusModel GetById(int id)
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.BusModels.Find(id);
        }

        public void Update(BusModel busModel)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Update(busModel);
            dbContext.SaveChanges();
        }
    }
}
