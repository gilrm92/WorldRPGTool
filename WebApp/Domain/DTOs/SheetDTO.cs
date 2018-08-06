using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldRpgTool.Domain.DTOs.Interfaces;

namespace WorldRpgTool.Domain.DTOs
{
    public class SheetDTO : ISheetDTO
    {
        public string Name { get; set; }
        public string GameStyle { get; set; }
        public string Text { get; set; }
    }
}
