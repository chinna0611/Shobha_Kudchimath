using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shobha_Kudchimath_Sprint2.Models
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        User AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
