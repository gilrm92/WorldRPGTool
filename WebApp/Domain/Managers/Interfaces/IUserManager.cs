using EntityManager.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldRpgTool.Domain.DTOs;
using WorldRpgTool.Domain.Entities;

namespace WorldRpgTool.Domain.Managers.Interfaces
{
    public interface IUserManager : IBaseManager<User, UserDTO>
    {

    }
}
