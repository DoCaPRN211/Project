using BusinessObject.Models;
using DataAccessObject;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public User checkLogin(string email, string password)
            => UserDAO.Instance.checkLogin(email, password);

        public void CreateUser(User user)
            => UserDAO.Instance.CreateUser(user);

        public List<User> GetUsers()
            => UserDAO.Instance.GetUsers();
    }
}