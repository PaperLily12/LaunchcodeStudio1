// See https://aka.ms/new-console-template for more information
Console.WriteLine("What should the radius of the circle be?");
double radius = float.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
double circumference = Math.PI * radius * 2;

Console.WriteLine($"The area of the circle is {area}");
Console.WriteLine($"The circumference of the circle is {circumference}");
Console.WriteLine($"The diameter of the circle is {radius*2}");

Console.WriteLine("What is the Miles per Gallon of your car?");
double MilesPerGallon = double.Parse(Console.ReadLine());
double gallonsNeeded = circumference / MilesPerGallon;
Console.WriteLine($"You would need {gallonsNeeded} gallons of gas to travel around the circle.");