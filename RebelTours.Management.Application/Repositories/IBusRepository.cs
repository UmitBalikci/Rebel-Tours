using RebelTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Repositories
{
    public interface IBusRepository
    {
        IEnumerable<Bus> GetAll();
        Bus GetById(int id);
        void Create(Bus bus);
        void Update(Bus bus);
        void Delete(Bus bus);
    }
}
