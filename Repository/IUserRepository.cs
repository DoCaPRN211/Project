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
        void CreateUser(User user);
        List<User> GetUsers();
    }
}
