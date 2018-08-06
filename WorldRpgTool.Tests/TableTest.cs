using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldRpgTool.Domain.Entities;
using System.Collections.Generic;

namespace WorldRpgTool.Tests
{
    [TestClass]
    public class TableTest
    {
        [TestMethod]
        public void ShouldCreateTable()
        {
            var tableDTO = new tableDTO()
            {
                Name = "Magos destruidores de mundos.",
                DescriptionAttribute = "Um mundo de magos, bla bla bla, e bla bla bla",
                GameStyle = "3D&T Alpha",
                MaxOfParticipants = 10,
                Password = "xvii",
                TableMaster = new User() { Name = "Gilberto" },
                Participants = new List<User>(),
                Private = true
            };

            ITableManager tableManager = new TableManager();
            var table = tableManager.Create(tableDTO);

        }
    }
}
