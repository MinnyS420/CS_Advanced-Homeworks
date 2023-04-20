using Task1.Entities;

//1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
Console.WriteLine("//1. All persons firstnames starting with 'J', ordered by Age - DESCENDING ORDER");
List<Person> peopleWithRNames = DB.People.OrderBy((Person p) => p.Age)
    .Where((Person p) => p.FirstName.StartsWith("J"))
    .ToList();
Console.WriteLine("People with first name starting with 'J', ordered by age (descending):");
foreach (Person person in peopleWithRNames.OrderByDescending((Person p) => p.Age))
{
    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Age} years old)");
}
Console.WriteLine();

//2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
Console.WriteLine("//2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");
List<Dog> brownDogs = DB.Dogs.OrderBy((Dog d) => d.Age)
    .Where((Dog d) => d.Color == "Brown" && d.Age > 3)
    .ToList();
Console.WriteLine("Brown dogs older than 3 years, ordered by age (ascending):");
foreach (Dog dog in brownDogs.OrderBy((Dog d) => d.Age))
{
    Console.WriteLine($"{dog.Name} ({dog.Age} years old)");
}
Console.WriteLine();

//3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
Console.WriteLine("//3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
List<Person> peopleWithMultipleDogs = DB.People.OrderByDescending((Person p) => p.LastName)
    .ThenByDescending((Person p) => p.FirstName)                                                    
    .Where((Person p) => p.Dogs.Count > 2)
    .ToList();
Console.WriteLine("People with more than 2 dogs, ordered by name (descending):");
foreach (Person person in peopleWithMultipleDogs)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Dogs.Count} dogs)");
}
Console.WriteLine();

//4. Find and print all Freddy`s dogs names older than 1 year
Console.WriteLine("//4. All Elena`s dogs names older than 1 year");
List<Dog> elenasDogs = DB.People.Where((Person p) => p.FirstName == "Elena")
    .SelectMany((Person p) => p.Dogs)
    .Where((Dog d) => d.Age > 1)
    .ToList();
Console.WriteLine("Elena's dogs older than 1 year:");
foreach (Dog dog in elenasDogs)
{
    Console.WriteLine(dog.Name);
}
Console.WriteLine();

//5. Find and print Nathen`s first dog
Console.WriteLine("//5. Ana`s first dog");
Dog? nathensFirstDog = DB.People.Where((Person p) => p.FirstName == "Ana")
    .Select((Person p) => p.Dogs.FirstOrDefault())
    .FirstOrDefault();
Console.WriteLine("Ana's first dog:");
if (nathensFirstDog != null)
{
    Console.WriteLine(nathensFirstDog.Name);
}
else
{
    Console.WriteLine("No dogs found.");
}
Console.WriteLine();

//6. Find and print all white dogs names from Dimitar, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
Console.WriteLine("//6. White dogs names from Dimitar, Katerina, Goran and Ana, ordered by Name - ASCENDING ORDER");
List<Dog> whiteDogs = DB.People.Where((Person p) => new[] { "Dimitar", "Katerina", "Goran", "Ana" }.Contains(p.FirstName))
    .SelectMany((Person p) => p.Dogs.Where((Dog d) => d.Color == "White"))
    .OrderBy((Dog d) => d.Name)
    .ToList();
Console.WriteLine("White dogs from Dimitar, Katerina, Goran, and Ana, ordered by name (ascending):");
foreach (Dog dog in whiteDogs)
{
    Console.WriteLine(dog.Name);
}