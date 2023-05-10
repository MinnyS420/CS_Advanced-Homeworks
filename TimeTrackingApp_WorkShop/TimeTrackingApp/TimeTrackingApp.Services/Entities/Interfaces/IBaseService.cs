using TimeTrackingApp.Domain.Entities;

namespace TimeTrackingApp.Services.Entities.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        bool AddUser(T user);
        T GetUserById(int id);
        T GetUserByUsername(string username);
        bool DeleteUser(int id);
        List<T> GetAll();
    }
}
