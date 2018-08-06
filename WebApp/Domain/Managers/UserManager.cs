using EntityManager.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldRpgTool.Domain.DTOs;
using WorldRpgTool.Domain.DTOs.Interfaces;
using WorldRpgTool.Domain.Entities;
using WorldRpgTool.Domain.Managers.Interfaces;

namespace WorldRpgTool.Domain.Managers
{
    public class UserManager : BaseManager<User, UserDTO>, IUserManager
    {
       
    }
}
