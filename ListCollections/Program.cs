// See https://aka.ms/new-console-template for more information


List <string> names = new List<string>();
string name = "";

//add values to list


names.Add("Matty");

Console.WriteLine("Enter Names: ");
while (name != "-1")
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    names.Add(name);
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        Console.Write($"{name} was added successfully.");
        names.Add(name);
    }
}

//print values in list
Console.WriteLine("Printing names via for loop");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via for loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}