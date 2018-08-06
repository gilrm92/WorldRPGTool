using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager.DTOs.Interfaces;
using EntityManager.Entities.Interfaces;
using AutoMapper.Configuration;

namespace EntityManager.Managers.Interfaces
{
    public class BaseManager<TOne, TTwo> : IBaseManager<TOne, TTwo> 
        where TOne : IEntity, new()
        where TTwo : IBaseDTO
    {
        protected IMapper _iMapper;
        public BaseManager()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TTwo, TOne>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
                cfg.CreateMap<TOne, TTwo>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            });
            _iMapper = config.CreateMapper();
        }

        public TOne Create(TTwo entityDTO)
        {
            return _iMapper.Map<TTwo, TOne>(entityDTO);
        }

        public TOne Edit(TOne entity, TTwo entityDTO)
        {
            return _iMapper.Map<TTwo, TOne>(entityDTO, entity);
        }
    }
}
