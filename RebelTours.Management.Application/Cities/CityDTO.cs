using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Cities
{
    // DTO => Data Transfer Object
    // Bir projede katmanlar arasında sadece ve sadece veri taşımak için kullanılan
    // üzerinde davranış olmayan ( yani POCO cinsi) sınıflar

    // bu proje özelinde; DTO sınıflarımız Presentation <-> APplication katmanları
    // arasında veri taşımak
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
