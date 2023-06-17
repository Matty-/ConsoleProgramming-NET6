// See https://aka.ms/new-console-template for more information




Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());

Cube cube = new Cube(width, height, length);


var triangle = new Triangle();
var triangle1 = new Triangle() { Height = height, Length = length, Hypotenuse = 10 };
var triangle2 = new Triangle(10); 
var triangle3 = new Triangle(10, height, length);


var rectangle = new Rectangle() { Length = length, Width = width }; ;

   
Console.WriteLine("Cube Area is: " + cube.GetArea());
Console.WriteLine("Cube Area is: " + cube.getVolume());

Console.WriteLine("Triangle Area is: " + triangle.GetArea());
Console.WriteLine("Triangle Area is: " + triangle1.GetArea());
Console.WriteLine("Triangle Area is: " + triangle2.GetArea());
Console.WriteLine("Triangle Area is: " + triangle3.GetArea());


Console.WriteLine("Rectangle Area is: " + rectangle.GetArea());