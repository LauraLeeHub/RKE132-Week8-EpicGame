string folderPath = @"C:\data-prog";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));



//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };


string[] weapons = { "magic wand", "plastic fork", "banana", "sword", "lego brick" };



string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villan = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {villan} with {villainWeapon} takes over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length );
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}