namespace Task1.Entities
{
    public static class DB
    {
        public static List<Person> People { get; set; }
        public static List<Dog> Dogs { get; set; }

        static DB()
        {
            List<Dog> dogs = new List<Dog>
        {
            new Dog("Borko", 5, "Brown"),
            new Dog("Ledi", 2, "White"),
            new Dog("Charli", 4, "Black"),
            new Dog("Luna", 3, "Brown"),
            new Dog("Kuper", 1, "White"),
            new Dog("Dejzi", 6, "Brown"),
            new Dog("Stenli", 2, "White"),
            new Dog("Lusi", 7, "Brown"),
            new Dog("Bejli", 5, "White"),
            new Dog("Sejdi", 3, "Brown"),
            new Dog("Tobi", 4, "White"),
            new Dog("Moli", 6, "Black")
        };

            List<Person> people = new List<Person>
        {
            new Person("Ana", "Petrova", 25, new List<Dog>{ dogs[0], dogs[1], dogs[2] }),
            new Person("Jovan", "Jovanovski", 30, new List<Dog>{ dogs[3], dogs[4] }),
            new Person("Elena", "Georgieva", 40, new List<Dog>{ dogs[5], dogs[6], dogs[7] }),
            new Person("Dimitar", "Trajanovski", 35, new List<Dog>{ dogs[8], dogs[9], dogs[10], dogs[11] }),
            new Person("Marija", "Angelovska", 20, new List<Dog>{ dogs[1], dogs[3], dogs[5] }),
            new Person("Nikola", "Gjorgiev", 45, new List<Dog>{ dogs[0], dogs[2], dogs[4] }),
            new Person("Katerina", "Stojanova", 27, new List<Dog>{ dogs[6], dogs[9] }),
            new Person("Goran", "Kostadinov", 33, new List<Dog>{ dogs[8], dogs[10] }),
            new Person("Jovana", "Miteva", 28, new List<Dog>{ dogs[11] })
        };

            People = people;
            Dogs = dogs;
        }
    }
}
