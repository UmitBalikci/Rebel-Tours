using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BaseServices
{
    public interface IService<TDto> : IQueryableService<TDto>, IModifiableService<TDto>
    {
    }
}
