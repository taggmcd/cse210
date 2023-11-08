using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>{
            new Circle(10,"green"),
            new Square(10, "blue"),
            new Rectangle(10,20,"red")
        };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} has an area of {shape.GetArea()}");
        }
    }
}

