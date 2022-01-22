namespace Shobha_Kudchimath_Sprint1.Models
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
