using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldRpgTool.Domain.Entities;
using WorldRpgTool.Domain.DTOs;
using WorldRpgTool.Domain.Managers;
using WorldRpgTool.Domain.Managers.Interfaces;

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
            var user = userManager.Create(userDTO);

            Assert.AreEqual(userDTO.Name, user.Name);
            Assert.AreEqual(userDTO.Surname, user.Surname);
            Assert.AreEqual(userDTO.Email, user.Email);
            Assert.AreEqual(userDTO.Password, user.Password);
        }

        [TestMethod]
        public void ShouldEditUser()
        {
            var user = new User()
            {
                Name = "Gilberto",
                Surname = "Test",
                Email = "gilbertormm.ramos@gmail.com",
                Password = "ASedsK23%ns@394"
            };

            var userDTO = new UserDTO()
            {
                Name = "Fabio",
                Surname = "another test",
                Email = "another test"
            };

            IUserManager userManager = new UserManager();
            var userEdited = userManager.Edit(user, userDTO);

            Assert.AreEqual(userDTO.Name, userEdited.Name);
            Assert.AreEqual(userDTO.Surname, userEdited.Surname);
            Assert.AreEqual(userDTO.Email, userEdited.Email);
            Assert.AreEqual(user.Password, userEdited.Password);
        }
    }
}
