using RebelTours.Domain;
using RebelTours.Management.Application.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Cities
{
    // Interface
    // -Implementation (kodlama) yerine yalnızca yapılacak işlerin adını 
    // dönüş tipini ve parametresini içeren soyutlama yapılarıdır
    // - İşin nasıl yapılsığını değil hangi işin yapılacağını söylemektir
    // - Bundan dolayı da interface'lere CONTRACT(sözleşme) de denir
    // 
    //- Peki işi (implementation) kim yapacak
    // yazdığımız interface i hangi sınıf implement ediyorsa işi/kodlamayı o yapacak

    // public class CityService : ICityService
    // Yukarıda yazan kodlamadaki sentaks' a interface'ler özelinde miras almak DEĞİL
    // interface 'i IMPLEMENT ETMEK (uyarılmak/kodlamak) denir
    public interface ICityService : IService<CityDTO>
    {
        //CityDTO GetById(int id);
        //IEnumerable<CityDTO> GetAll();
        //CommandResult Create(CityDTO city);
        //CommandResult Update(CityDTO city);
        //CommandResult Delete(CityDTO city);

    }
}
