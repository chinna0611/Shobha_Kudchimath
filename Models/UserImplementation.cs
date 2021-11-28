namespace Shobha_Kudchimath_Sprint_I.Models
{
    public class UserImplementation:IUserRepository
    {
        private static List<User> user = new List<User>();
        private int count = 2;

        public UserImplementation()
        {
            user.Add(new User() { UserId = 1, FirstName = "Shobha", LastName = "Kudchimath", EmailId = "chinnakudchimath@gmail.com", Password = "1234" });
            user.Add(new User() { UserId = 2, FirstName = "Shubham", LastName = "Kudchimath", EmailId = "s.kudchimath@gmail.com", Password = "12345" });
    
        }
         
        public User AddUser(User users)
        {
            users.UserId = ++count;
            user.Add(users);
            return users;
        }

        public void DeleteUser(int id)
        {
            var result = user.FirstOrDefault(a => a.UserId == id);
            var deleted = user.Remove(result);
        }

        public List<User> GetAllUsers()
        {
            return user;
        }

        public User GetUserById(int id)
        {
            return user.FirstOrDefault(emp => emp.UserId == id);
        }

        public void UpdateUser(User user)
        {
            var data = new User()
            {
                EmailId = user.EmailId,
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
    }
}
