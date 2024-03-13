using System;
class Program {
    static void Main() {
        Console.WriteLine("Running...............");
        Rectangle Rectangle1 = new Rectangle("Blue", 10, 30);
        Console.WriteLine(Rectangle1.Name);
        Console.WriteLine(Rectangle1.CalculateArea());

        Circle Circle1 = new Circle("Red", 10);
        Console.WriteLine(Circle1.Name);
        Console.WriteLine(Circle1.CalculateArea());

        Triangle Triangle1 = new Triangle("Red", 10, 8);
        Console.WriteLine(Triangle1.Name);
        Console.WriteLine(Triangle1.CalculateArea());

        Console.WriteLine("Using name function");
        Console.WriteLine(PrintShapeArea(Rectangle1));
        Console.WriteLine(PrintShapeArea(Circle1));
        Console.WriteLine(PrintShapeArea(Triangle1));
    }

    static string PrintShapeArea(Shape shape) {
        return shape.Name;
    }
}