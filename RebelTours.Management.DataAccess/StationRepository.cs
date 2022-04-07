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
    public class StationRepository : IStationRepository
    {
        public void Create(Station station)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Stations.Add(station);
            dbContext.SaveChanges();
        }

        public void Delete(Station station)
        {
            var dbContext = new RebelToursDbContext();
            var stationRemove = dbContext.Stations.Find(station.Id);
            dbContext.Stations.Remove(stationRemove);
            dbContext.SaveChanges();
        }

        public IEnumerable<Station> GetAll()
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.Stations.ToList();
        }

        public Station GetById(int id)
        {
            var dbContext = new RebelToursDbContext();
            return dbContext.Stations.Find(id);
        }

        public void Update(Station station)
        {
            var dbContext = new RebelToursDbContext();
            dbContext.Stations.Update(station);
            dbContext.SaveChanges();
        }
    }
}
