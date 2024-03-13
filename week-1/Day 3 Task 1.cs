public abstract class Shape {
    string name;
    public virtual string Name {
        get { return name; }
        set { name = value; }
    } 

    public abstract decimal CalculateArea();
}


public class Rectangle:Shape{
    decimal Height {get; set;}
    decimal Width {get; set;}
    public Rectangle(string name, decimal height, decimal width){
        Name = name;
        Height = height;
        Width = width;
    }

    public override string Name { 
        get => "Rectangle: " + base.Name; 
        set => base.Name = value; }

    public override decimal CalculateArea(){
        return Height * Width;
    }
}

public class Circle:Shape{
    decimal Radius {get; set;}
    public Circle(string name, decimal radius){
        Name = name;
        Radius = radius;
    }

    public override string Name { 
        get => "Circle: " + base.Name; 
        set => base.Name = value; }

    public override decimal CalculateArea(){
        return (decimal) Math.PI * Radius;
    }
}


public class Triangle:Shape{
    decimal Base {get; set;}
    decimal Height {get; set;}
    public Triangle(string name, decimal height, decimal base1){
        Name = name;
        Height = height;
        Base = base1;
    }

    public override string Name { 
        get => "Triangle: " + base.Name; 
        set => base.Name = value; }

    public override decimal CalculateArea(){
        return Base * Height / 2;
    }
}


// Main Method implmentation

// using System;
// class Program {
//     static void Main() {
//         Console.WriteLine("Running...............");
//         Rectangle Rectangle1 = new Rectangle("Blue", 10, 30);
//         Console.WriteLine(Rectangle1.Name);
//         Console.WriteLine(Rectangle1.CalculateArea());

//         Circle Circle1 = new Circle("Red", 10);
//         Console.WriteLine(Circle1.Name);
//         Console.WriteLine(Circle1.CalculateArea());

//         Triangle Triangle1 = new Triangle("Red", 10, 8);
//         Console.WriteLine(Triangle1.Name);
//         Console.WriteLine(Triangle1.CalculateArea());

//         Console.WriteLine("Using name function");
//         Console.WriteLine(PrintShapeArea(Rectangle1));
//         Console.WriteLine(PrintShapeArea(Circle1));
//         Console.WriteLine(PrintShapeArea(Triangle1));
//     }

//     static string PrintShapeArea(Shape shape) {
//         return shape.Name;
//     }
// }