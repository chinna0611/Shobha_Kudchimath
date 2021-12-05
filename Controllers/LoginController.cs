using Shobha_Kudchimath_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Shobha_Kudchimath_Sprint2.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public string Login(User userModel)
        {
            if (string.IsNullOrEmpty(userModel.EmailId) || string.IsNullOrEmpty(userModel.Password))
            {
                return "UserId and password cannot be null";
            }
            else
            {

                List<User> list = new List<User>();
                list.Add(new User() { UserId = 1, FirstName = "Shobha", LastName = "Kudchimath", EmailId = "shobha.kudchimath@socgen.com", Password = "8765" });
                list.Add(new User() { UserId = 2, FirstName = "Shubham", LastName = "Kudchimath", EmailId = "s.kudchimath@gmail.com", Password = "P@ssword" });
                var display = list.Where(a => a.UserId == userModel.UserId && a.Password == userModel.Password).FirstOrDefault();
                if (display == null)
                {
                    return "InCorrect UserName and Password";
                }
                return "Correct UserName and Password,Welcome";
            }
        }
    }
}
