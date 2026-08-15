using System;

// Abstract class
abstract class Shape
{
    public abstract double CalculateArea();
}

// Circle class
class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

// Rectangle class
class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}

class Program4_ShapeAbstraction
{
    static void Main()
    {
        Console.WriteLine("Choose Shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter radius: ");
                double r = Convert.ToDouble(Console.ReadLine());

                Shape c = new Circle(r);
                Console.WriteLine("Area of Circle = " + c.CalculateArea());
                break;

            case 2:
                Console.Write("Enter length: ");
                double l = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter width: ");
                double w = Convert.ToDouble(Console.ReadLine());

                Shape rect = new Rectangle(l, w);
                Console.WriteLine("Area of Rectangle = " + rect.CalculateArea());
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}