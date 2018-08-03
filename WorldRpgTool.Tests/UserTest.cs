using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldRpgTool.Tests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ShouldCreateNewUser()
        {
            var userDTO = new UserDTO()
            {
                Name = "Gilberto",
                Surname = "Test",
                Email = "gilbertormm.ramos@gmail.com",
                Password = "ASedsK23%ns@394"
            };

            IUserManager userManager = new UserManager();
            var user = userManager.CreateNewUser(userDTO);

            Assert.AreEqual(userDTO.Name, user.Name);
            Assert.AreEqual(userDTO.Surname, user.Surname);
            Assert.AreEqual(userDTO.Email, user.Email);
            Assert.AreEqual(userDTO.Password, user.Password);
        }

        [TestMethod]
        public void ShouldEditUser()
        {
            var userDTO = new UserDTO()
            {
                Name = "Gilberto",
                Surname = "Test",
                Email = "gilbertormm.ramos@gmail.com",
                Password = "ASedsK23%ns@394"
            };

            IUserManager userManager = new UserManager();
            var user = userManager.CreateNewUser(userDTO);

            userDTO.Name = "Fabio";
            userDTO.Surname = "another test";
            userDTO.Email = "another test";
            userDTO.Password = "another test";

            var userEdited = userManager.EditUser(user, userDTO);

            Assert.AreEqual(userDTO.Name, userEdited.Name);
            Assert.AreEqual(userDTO.Surname, userEdited.Surname);
            Assert.AreEqual(userDTO.Email, userEdited.Email);
            Assert.AreEqual(userDTO.Password, userEdited.Password);
        }
    }
}
