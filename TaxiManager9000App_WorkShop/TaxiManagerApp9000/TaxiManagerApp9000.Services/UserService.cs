using TaxiManagerApp9000.DataAccess;
using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public User? CurrentUser { get; set; }
        protected new FileSystemDb<User> Db;
        public UserService() 
        {
            Db = new FileSystemDb<User>();
        }

        public bool ChangePassword(int id, string oldPassword, string newPassword)
        {
            User user = GetById(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.Password == oldPassword)
            {
                user.Password = newPassword;
                return Db.Update(user);
            }
            else
            {
                Console.WriteLine("New password can not be previous password.");
                return false;
            }
        }

        public void Login(string username, string password)
        {
            CurrentUser = GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);

            if (CurrentUser == null)
            {
                throw new Exception("Login unsuccessful. Please try again.");
            }
        }

        public List<User> GetUsersForRemoval()
        {
            return GetAll().Where(x => x != CurrentUser).ToList();
        }
    }
}
