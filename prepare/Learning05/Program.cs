using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle(5, "Green"));
        shapes.Add(new Rectangle(4, 5, "Blue"));
        shapes.Add(new Square(4, "Purple"));

        Console.Clear();
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}