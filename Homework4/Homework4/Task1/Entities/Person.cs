namespace Task1.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, List<Dog> dogs)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Dogs = dogs;
        }
    }

}
