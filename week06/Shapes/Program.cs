using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        //Square square = new Square("blue", 10);
        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea());
        //Rectangle rectangle = new Rectangle("red", 10, 5);
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());
        //Circle circle = new Circle("yellow", 5);
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 10));
        shapes.Add(new Rectangle("red",10, 5));
        shapes.Add(new Circle("yellow", 5));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            Console.WriteLine(color);
            double area = shape.GetArea();
            Console.WriteLine(area);
        }
        
    }
}