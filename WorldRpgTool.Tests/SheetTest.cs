using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            ISheetManager userManager = new SheetManager();
            var sheet = userManager.CreateNewUser(sheetDTO);

            Assert.AreEqual(sheetDTO.Name, sheet.Name);
            Assert.AreEqual(sheetDTO.GameStyle, sheet.GameStyle);
            Assert.AreEqual(sheetDTO.Text, sheet.Text);
        }

        [TestMethod]
        public void ShouldEditSheet()
        {
            var sheetDTO = new SheetDTO()
            {
                Name = "Ficha modelo",
                GameStyle = "3D&T",
                Text = "Atributos - Forca: 0"
            };

            ISheetManager userManager = new SheetManager();
            var sheet = userManager.CreateNewUser(sheetDTO);

            Assert.AreEqual(sheetDTO.Name, sheet.Name);
            Assert.AreEqual(sheetDTO.GameStyle, sheet.GameStyle);
            Assert.AreEqual(sheetDTO.Text, sheet.Text);
        }
    }
}
