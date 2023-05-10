using TimeTrackingApp.DataAccess;
using TimeTrackingApp.DataAccess.Interfaces;
using TimeTrackingApp.Domain.Entities;
using TimeTrackingApp.Services.Entities.Interfaces;

namespace TimeTrackingApp.Services.Entities
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private IDb<T> Db;
        public BaseService()
        {
            Db = new FileDataBase<T>();
        }

        public bool AddUser(T user)
        {
            try
            {
                Db.AddUser(user);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            return Db.DeleteUser(id);
        }

        public List<T> GetAll()
        {
            return Db.GetAll();
        }

        public T GetUserById(int id)
        {
            return Db.GetUserById(id);
        }

        public T GetUserByUsername(string username)
        {
            return Db.GetUserByUsername(username);

        }
    }
}
