using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldRpgTool.Domain.DTOs.Interfaces;

namespace WorldRpgTool.Domain.DTOs
{
    public class UserDTO : IUserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
