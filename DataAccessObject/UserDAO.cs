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

        public User GetUserById(string id)
        {
            using var db = new DoCaPrnContext();
            var user = db.Users.SingleOrDefault(u => u.Id.Equals(id));
            user.Password = DecodeFrom64(user.Password);
            return user;
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
        private static string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
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

        public void UpdateUser(User u)
        {
            using var db = new DoCaPrnContext();
            var user = db.Users.Find(u.Id);
            if (user != null)
            {
                user.Fullname = u.Fullname;
                user.Dob = u.Dob;
                user.Gender = u.Gender;
                db.SaveChanges();
            }
        }

        public void UpdatePassword(User u, string newPass)
        {
            using var db = new DoCaPrnContext();
            var user = db.Users.Find(u.Id);
            if (user != null)
            {
                user.Password = EncodePasswordToBase64(newPass);
                db.SaveChanges();
            }
        }
        
        public void DeleteUser(User u)
        {
            using var db = new DoCaPrnContext();
            u.Isactive = false;
            db.Users.Update(u);
            db.SaveChanges();
        }

        public void BanUser(User u)
        {
            using var db = new DoCaPrnContext();
            if (u.Isban == true) u.Isban = false;
            else if (u.Isban == false) u.Isban = true;
            db.Users.Update(u);
            db.SaveChanges();
        }
    }
}