namespace CarDealerShip.Entities
{
   
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> _entities = new List<T>();

        public void Insert(T entity)
        {
            _entities.Add(entity);
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public void PrintAll()
        {
            //Console.WriteLine("All cars:");  za da izzgleda po cool so color vo program.cs e staveno
            foreach (T entity in _entities)
            {
                Console.WriteLine($"{entity.Brand} {entity.Model}.");
            }
        }
    }
}
