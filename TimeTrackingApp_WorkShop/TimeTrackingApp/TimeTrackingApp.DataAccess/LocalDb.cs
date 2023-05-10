using TimeTrackingApp.DataAccess.Interfaces;
using TimeTrackingApp.Domain.Entities;

namespace TimeTrackingApp.DataAccess
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCounter { get; set; }

        private List<T> db;
        public LocalDb()
        {
            db = new List<T>();
            IdCounter = 1;
        }

        public List<T> GetAll()
        {
            return db;
        }


        public User Authenticate(string username, string password)
        {
            return db.OfType<User>().FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public int AddUser(T user)
        {
            user.Id = IdCounter++;
            db.Add(user);
            return user.Id;
        }

        public T GetUserById(int id)
        {
            return db.Single(x => x.Id == id);
        }

        public T GetUserByUsername(string username)
        {
            return db.Single(x => x.Username == username);

        }

        public bool UpdateUser(T user)
        {
            try
            {
                T dbUser = GetUserById(user.Id);

                dbUser = user;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                T user = GetUserById(id);
                db.Remove(user);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
