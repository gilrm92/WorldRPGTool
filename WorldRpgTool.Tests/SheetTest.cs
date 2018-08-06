using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldRpgTool.Domain.DTOs;
using WorldRpgTool.Domain.Managers.Interfaces;
using WorldRpgTool.Domain.Managers;
using WorldRpgTool.Domain.Entities;

namespace WorldRpgTool.Tests
{
    [TestClass]
    public class SheetTest
    {
        [TestMethod]
        public void ShouldCreateSheet()
        {
            var sheetDTO = new SheetDTO()
            {
                Name = "Ficha modelo",
                GameStyle = "3D&T",
                Text = "Atributos - Forca: 0"
            };

            ISheetManager sheetManager = new SheetManager();
            var sheet = sheetManager.Create(sheetDTO);

            Assert.AreEqual(sheetDTO.Name, sheet.Name);
            Assert.AreEqual(sheetDTO.GameStyle, sheet.GameStyle);
            Assert.AreEqual(sheetDTO.Text, sheet.Text);
        }

        [TestMethod]
        public void ShouldEditSheet()
        {
            var sheetDTO = new SheetDTO()
            {
                Name = "Ficha modelo [MODIFIED]",
                GameStyle = "3D&T [MODIFIED]",
            };

            var sheet = new Sheet()
            {
                Name = "Ficha modelo",
                GameStyle = "3D&T",
                Text = "Atributos - Forca: 0"
            };

            ISheetManager sheetManager = new SheetManager();
            var sheetEdited = sheetManager.Edit(sheet, sheetDTO);

            Assert.AreEqual(sheetDTO.Name, sheetEdited.Name);
            Assert.AreEqual(sheetDTO.GameStyle, sheetEdited.GameStyle);
            Assert.AreEqual(sheet.Text, sheetEdited.Text);

        }
    }
}
