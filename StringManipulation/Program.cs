// See https://aka.ms/new-console-template for more information
string firstName = "Matty";
string lastName = "Canty";
DateTime date = DateTime.Now;



// Print to string
Console.WriteLine(firstName);
Console.WriteLine("String printed");


//Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + " " + firstName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName); 


// String Length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");



// Replace String Parts
string newName = firstName.Replace('t', 'L');
Console.WriteLine($"Your new name is {newName}");

string newName1 = firstName.Replace('u', ' ');
Console.WriteLine($"Your newest name is {newName1}");

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");


// split string
string [] splitName = fullName.Split('t');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);

}

string nullString = null;
string emptyString = "";
string whitespaceString = " ";

//compare strings
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("names are equal");
} 
    
if (firstName != lastName)
{
    Console.WriteLine("names are not equal");   
}

int comparisonResult = string.CompareOrdinal(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("names are equal");
}
else
{
    Console.WriteLine("names are not equal");
}



// convert to string
string convertedString = string.Empty;
int number 12345678;

convertedString = number.ToString();
convertedString = 1234218418.ToString();

fullName.ToUpper();
fullName.ToLower();