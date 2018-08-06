using EntityManager.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldRpgTool.Domain.DTOs.Interfaces
{
    public interface ISheetDTO : IBaseDTO
    {
        string Name { get; set; }
        string GameStyle { get; set; }
        string Text { get; set; }
    }
}
