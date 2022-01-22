using Microsoft.AspNetCore.Mvc;
using Shobha_Kudchimath_Sprint1.Models;

namespace Shobha_Kudchimath_Sprint1.Controllers
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
                list.Add(new User() { UserId = 1, FirstName = "Shobha", LastName = "Kudchimath", EmailId = "chinnakudchimath@gmail.com", Password = "9876" });
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
