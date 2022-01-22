using Microsoft.AspNetCore.Mvc;
using Shobha_Kudchimath_Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test_Shobha_sprint_3
{
    public class UserContrllerTest
    {
        private readonly IUserRepository _repository;

        public UserContrllerTest(IUserRepository repository)
        {
            _repository = repository;
        }
        [Fact]
        public void GetUserID_Return_OkResult()
        {
            int id = 2;
            //Arrange
            UserController controller = new UserController(_repository);

            //Act
            var data = controller.Get(id);

            var expectedResult = controller.Get(2);
            //Assert
            Assert.Equal(expectedResult, data);

        }

        [Fact]
        public void GetUserID_Return_NotFound()
        {
            int id = 2;
            //Arrange
            UserController controller = new UserController(_repository);

            //Act
            var data = controller.Get(id);

            controller.Get(2);
            //Assert
            Assert.IsType<NotFoundResult>(data);

        }

        [Fact]
        public void GetAllUsers_Return_OKResult()
        {
            //Arrange
            var controller = new UserController(_repository);

            //Act
            var data = controller.Get();

            //Assert
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public void Delete_User_Return_Ok()
        {
            int id = 2;
            //Arrange
            var controller = new UserController(_repository);

            //Act
            var data = controller.Delete(id);

            //Assert
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public void Delete_User_Return_NotFound()
        {
            int id = 2;
            //Arrange
            var controller = new UserController(_repository);

            //Act
            var data = controller.Delete(id);

            //Assert
            Assert.IsType<NotFoundResult>(data);

        }

    }
}
