using Newtonsoft.Json;
using TimeTrackingApp.DataAccess.Interfaces;
using TimeTrackingApp.Domain.Entities;

namespace TimeTrackingApp.DataAccess
{
    public class FileDataBase<T> : IDb<T> where T : BaseEntity
    {
        private string _databaseFolder;
        private string _databasePath;
        private string _idPath;

        public FileDataBase()
        {
            _databaseFolder = "../../../Database";
            _databasePath = $"{_databaseFolder}/{typeof(T).Name}s.json";
            _idPath = $"{_databaseFolder}/{typeof(T).Name}Id.txt";

            if (!Directory.Exists(_databasePath))
            {
                Directory.CreateDirectory(_databaseFolder);
            }

            if (!File.Exists(_databasePath))
            {
                File.Create(_databasePath).Close();
            }

            if (!File.Exists(_idPath))
            {
                File.Create(_idPath).Close();
            }
        }

        public int AddUser(T user)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }

            if (data == null)
            {
                data = new List<T>();
            }

            user.Id = GenerateId();
            data.Add(user);
            WriteData(data);

            return user.Id;
        }
        public List<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }
        public bool DeleteUser(int id)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }

            if (data == null)
            {
                data = new List<T>();
            }

            T item = data.SingleOrDefault(x => x.Id == id);

            if (item != null)
            {
                data.Remove(item);
                WriteData(data);
            }

            return true;
        }
        public T GetUserById(int id)
        {
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()).FirstOrDefault(x => x.Id == id);
            }
        }
        public T GetUserByUsername(string username)
        {
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()).FirstOrDefault(x => x.Username == username);
            }
        }
        public bool UpdateUser(T user)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }

            if (data == null)
            {
                data = new List<T>();
            }

            T item = data.SingleOrDefault(x => x.Id == user.Id);

            if (item != null)
            {
                data[data.IndexOf(item)] = user;
                WriteData(data);
            }

            return true;
        }
        private void WriteData(List<T> data)
        {
            using (StreamWriter sw = new StreamWriter(_databasePath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
        private int GenerateId()
        {
            int id = 1;
            using (StreamReader sr = new StreamReader(_idPath))
            {
                string currentId = sr.ReadLine();
                if (currentId != null)
                {
                    id = int.Parse(currentId);
                }
            }

            using (StreamWriter sw = new StreamWriter(_idPath))
            {
                sw.WriteLine(id + 1);
            }

            return id;
        }
    }
}