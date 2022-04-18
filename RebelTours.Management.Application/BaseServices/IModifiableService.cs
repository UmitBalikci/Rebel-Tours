using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BaseServices
{
    public interface IModifiableService<TDto>
    {
        CommandResult Create(TDto dto);
        CommandResult Update(TDto dto);
        CommandResult Delete(TDto dto);
    }
}
