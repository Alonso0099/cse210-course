using System;
using System.Security.Cryptography.X509Certificates;
//GetType added
class Program

{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();
        Square square1 = new Square("Blue", 5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Green", 4, 6);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(8, "Purple");
        shapes.Add(circle1);

        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {shape.GetType().Name} of color {color} has an area of {area:F2}");
        }
    }
}