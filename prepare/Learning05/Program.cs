using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(1.5, "Blue");
        Rectangle r1 = new Rectangle(2, 2, "Red");
        Circle c1 = new Circle(2, "green");
        List<Shape> manyShapes = [s1, r1, c1];
        
        foreach (Shape shape in manyShapes)
        {
            Console.WriteLine($"Shape: {shape.WriteName()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }


        

        // Console.WriteLine($"{s1.GetColor()}");
        // Console.WriteLine($"{s1.GetArea()}");
        // Console.WriteLine($"{r1.GetColor()}");
        // Console.WriteLine($"{r1.GetArea()}");
        // Console.WriteLine($"{c1.GetColor()}");
        // Console.WriteLine($"{c1.GetArea()}");

    }
}