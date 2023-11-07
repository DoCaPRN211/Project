using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        User checkLogin(string email, string password);
        User GetUserById(string id);
        void CreateUser(User user);
        List<User> GetUsers();
        void UpdateUser(User u);
        void UpdatePassword(User u, string newPass);
        void DeleteUser(User u);
        void BanUser(User u);
        User GetUserByUsernameAndEmail(string username, string email);

    }
}
