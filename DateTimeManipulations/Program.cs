// See https://aka.ms/new-console-template for more information




//Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

//Create a DateTime from date and time

DateTime dateOfBirth = new DateTime(1993, 12, 08);
Console.WriteLine($"My dob is: " + dateOfBirth);

//Create a DateTime from current timestamp

DateTime now = DateTime.Now;
Console.WriteLine($"The time now is {now}");

//Create a Datetime from a string

DateTime datefromstring = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine($"The date from string: " + datefromstring);


//Add Additional time

now.AddHours(1);
now.AddDays(1);
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

//DateTime from ticks

Console.WriteLine("Time as a numeral: " + now.Ticks);

//Date Only

DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("The date only now is: " + dateOnlyOfBirth);

//Time Only

TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("The time only now is: " + timeOnly);


