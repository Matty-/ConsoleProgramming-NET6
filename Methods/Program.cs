// See https://aka.ms/new-console-template for more information


//Prototype - defines the function (type, name and parameters)
//definition - has the code, it contains the code block
//function call - makes the function execute
//DRY - DONT REPEAT YOURSELF
//YAGNI - YOU ARENT GOING TO NEED IT



//Void Functions - completes a task and movies along
void PrintName()
{
    Console.WriteLine("Matty");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");    

}

// Value Returning Functions - completes a task and returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if (largest < num2);
    {
        largest = num2;
    }
    if (largest < num3) 
    {
        largest = num3;
    }
    return largest;
}
PrintName();

Console.WriteLine("Enter number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
int number2 = Convert.ToInt32((Console.ReadLine()));


Addition(number1, number2);
Console.WriteLine("End of Void Function");

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");
