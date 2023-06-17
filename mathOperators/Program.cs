// See https://aka.ms/new-console-template for more information

//Basic Assignment Operator

int num = 5;

// Arithmetic operators

int num1 = 4;
int num2 = 3;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 1;
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

//compound assignment operators

num1 += 4;
Console.WriteLine(num1);
num1 -= 4;
Console.WriteLine(num1);
num1 *= 4;
Console.WriteLine(num1);
num1 /= 4;
Console.WriteLine(num1);
num1 %= 4;
Console.WriteLine(num1);


