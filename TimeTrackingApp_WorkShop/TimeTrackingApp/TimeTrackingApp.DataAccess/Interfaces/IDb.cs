using TimeTrackingApp.Domain.Entities;

namespace TimeTrackingApp.DataAccess.Interfaces
{
    public interface IDb<T> where T : BaseEntity
    {
        int AddUser(T user);
        T GetUserById(int id);
        T GetUserByUsername(string username);
        bool UpdateUser(T user);
        bool DeleteUser(int id);
        List<T> GetAll();
    }
}
