using BusinessObject.Models;
using DataAccessObject;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public User checkLogin(string email, string password)
            => UserDAO.Instance.checkLogin(email, password);
        public User GetUserById(string id)
            => UserDAO.Instance.GetUserById(id);

        public void CreateUser(User user)
            => UserDAO.Instance.CreateUser(user);

        public List<User> GetUsers()
            => UserDAO.Instance.GetUsers();

        public void UpdateUser(User u)
            => UserDAO.Instance.UpdateUser(u);

        public void UpdatePassword(User u, string newPass)
            => UserDAO.Instance.UpdatePassword(u, newPass);

        public void DeleteUser(User u)
            => UserDAO.Instance.DeleteUser(u);

        public void BanUser(User u)
            => UserDAO.Instance.BanUser(u);
    }
}