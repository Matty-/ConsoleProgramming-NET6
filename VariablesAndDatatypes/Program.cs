// See https://aka.ms/new-console-template for more information

//Variable Declatations and Types

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working = false;


//Prompting user input
Console.WriteLine("Please enter your name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Please enter if you are working or not (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());


//print information

Console.WriteLine("Your name is: " + fullName); //concatenation
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}"); //interpolation
Console.WriteLine($"Your gender is: {gender}"); //interpolation
Console.WriteLine($"You are working: {working}"); //interpolation





