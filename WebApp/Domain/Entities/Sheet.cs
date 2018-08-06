using EntityManager.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldRpgTool.Domain.Entities
{
    public class Sheet : IEntity
    {
        public string Name { get; set; }
        public string GameStyle { get; set; }
        public string Text { get; set; }
    }
}
