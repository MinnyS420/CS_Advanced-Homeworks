using Newtonsoft.Json;
using Task1.Entities;
using Task1.Helpers;

#region Logic
string folderPath = "../../../JsonFolder";
string filePath = folderPath + "/JsonFile.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

void WriteToJson(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine(json);
    }
}
void ReadFromJson1()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        TextHelper.TextGenerator($"All dogs:\n", ConsoleColor.Yellow);
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(line);
            foreach (Dog d in dogs)
            {
                TextHelper.TextGenerator($"Name: {d.Name}\nAge: {d.Age}\nColor: {d.Color}\n", ConsoleColor.Green);
            }
        }
    }
}

void ReadFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.Clear();
        Console.WriteLine(sr.ReadToEnd());
    }
}

#endregion

TextHelper.TextGenerator("Welcome to homework5", ConsoleColor.Green);
List<Dog> dogs = new List<Dog>();

while (true)
{
    TextHelper.TextGenerator("Enter dog name, or enter 'done' to exit:", ConsoleColor.Green);
    string name = Console.ReadLine();
    if (name.ToLower() == "done")
    {
        break;
    }
    TextHelper.TextGenerator("Enter dog age:", ConsoleColor.Green);
    int age = int.Parse(Console.ReadLine());
    TextHelper.TextGenerator("Eneter dog color:", ConsoleColor.Green);
    string color = Console.ReadLine();

    Dog dog = new Dog
    {
        Name = name,
        Age = age,
        Color = color
    };

    dogs.Add(dog);
}

string dogJson = JsonConvert.SerializeObject(dogs);
WriteToJson(dogJson);

ReadFromJson();
ReadFromJson1();

List<Dog> deserializedDogs = JsonConvert.DeserializeObject<List<Dog>>(dogJson);

//TextHelper.TextGenerator($"All dogs:\n", ConsoleColor.Yellow);
//Uncomment only if u uncommet the 26-42 line code
TextHelper.TextGenerator($"The last dog/'s:\n", ConsoleColor.Yellow);

foreach (Dog d in deserializedDogs)
{
    TextHelper.TextGenerator($"Name: {d.Name}\nAge: {d.Age}\nColor: {d.Color}\n", ConsoleColor.Green);
}