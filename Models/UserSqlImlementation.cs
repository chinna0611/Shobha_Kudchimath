namespace Shobha_Kudchimath_Sprint1.Models
{
    public class UserSqlImlementation: IUserRepository
    {
        private readonly AppDbContext _context;

        public UserSqlImlementation(AppDbContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            User user = GetUserById(id);
            _context.User.Remove(user);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(user => user.UserId == id);
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
