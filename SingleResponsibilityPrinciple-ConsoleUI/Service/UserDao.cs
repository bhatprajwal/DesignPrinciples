using SRP.Models;

namespace SRP.Service
{
    public class UserDao
    {
        public static List<User> users = new List<User>();

        public static User Add(User user)
        {
            user.Id = users.Count() + 1;
            users.Add(user);
            return user;
        }

        public static List<User> GetAll() => users;
    }
}