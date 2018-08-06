using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager.DTOs.Interfaces;
using EntityManager.Entities.Interfaces;

namespace EntityManager.Managers.Interfaces
{
    public interface IBaseManager<TOne, TTwo> 
        where TOne : IEntity , new()
        where TTwo : IBaseDTO
    {
        TOne Create(TTwo entityDTO);
        TOne Edit(TOne entity, TTwo entityDTO);
    }
}
