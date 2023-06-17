// See https://aka.ms/new-console-template for more information

using ClassesAndObjects;
//Console = class
//list = class

// primitive datatypes
//int, string, char, bool

// Object oriented programming = creating your own datatypes
// class = blueprint of what an object is going to be

//single responsibility principle



Person person = new ();

string middleName = string.Empty;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter age: ");
person.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter middle name: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Your full name is: " + person.getFullName());
}
else
{
    Console.WriteLine("Full name is: " + person.getFullName(middleName));
}

person.setSalary(salary);
//Console.WriteLine("First Name is: " + person.FirstName);
//Console.WriteLine("Second Name is: " + person.LastName);

Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Salary is: " + person.getSalary());




