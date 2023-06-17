// See https://aka.ms/new-console-template for more information



//Declare fixed size array

int[] grades = new int[5];
//5 space addresses will be stored in memory - 0, 1, 2, 3, 4
//if n is the size of array, then your array has addresses between 0 to n-1

//add values to fixed size array

//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 34;
//grades[3] = 45;
//grades[4] = 53;

//grades = new int[] { 1, 25, 38, 45, 54 };
Console.WriteLine("Enter all grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//print values in fixed size arrow

Console.WriteLine("The grades you have entered are");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

//delcare variable sized array
string[] studentNames = new string[] { "Test", "Student", "etc" };


//add values to variable sized array

Console.WriteLine("The names you entered are");
for (int i = 0;i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}

//print values in variable sized array

