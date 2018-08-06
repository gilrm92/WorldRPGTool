using EntityManager.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldRpgTool.Domain.DTOs.Interfaces
{
    public interface IUserDTO : IBaseDTO
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
