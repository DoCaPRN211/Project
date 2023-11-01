using BusinessObject.Models;
using System.Diagnostics.Metrics;

namespace DataAccessObject
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get 
            { 
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance; 
            }
        }

        public User checkLogin(string email, string password)
        {
            using var db = new DoCaPrnContext();
            return db.Users.SingleOrDefault(u => (u.Email.Equals(email) || u.Username.Equals(email)) 
                                            && u.Password.Equals(EncodePasswordToBase64(password)));
        }

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Register Form" + ex.Message);
            }
        }

        public List<User> GetUsers()
        {
            using var db = new DoCaPrnContext();
            return db.Users.ToList();
        }

        public void CreateUser(User u)
        {
            using var db = new DoCaPrnContext();
            u.Password = EncodePasswordToBase64(u.Password);
            db.Users.Add(u);
            db.SaveChanges();
        }
    }
}