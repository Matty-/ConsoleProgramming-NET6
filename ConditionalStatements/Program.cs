// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32((Console.ReadLine()));




//If Statements ( ==, <, >, <=, >=, !=  )

if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfOranges > numberOfApples)
{
    Console.WriteLine("You have more oranges");

}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same amount of oranges and apples.");
}
else
{
    Console.WriteLine("No direct action");
}


Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
//Switch Statments
switch (grade)
{
    case int n when (n >= 0 && n <= 59): //bettwen 0 and 59
        Console.WriteLine("You failed");
        break;

    case int n when (n >=60 && n <=100): //between 60 and 100
        Console.WriteLine("You passed");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;

    
}

//Ternary 

var message = numberOfApples > numberOfOranges ? "you have more apples" : "you have more oranges";
Console.WriteLine(message);