// See https://aka.ms/new-console-template for more information



//For Loop (Counter Controlled)

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine($"Counter Value: {i}");
}

Console.WriteLine();
Console.WriteLine("FOR LOOP FINISHED");


//While Loop (Condition Controlled - Pre Check)

int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}");
}

Console.WriteLine("Finished!");


// Do While Loop ( Condition Controlled - Post Check

int n1 = 0;
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n1}");
} while (n < 5);

//For each 

