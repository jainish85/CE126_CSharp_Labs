using System;

class Program
{
    delegate double Calculator(double a, double b);

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero not possible.");
            return 0;
        }
        return a / b;
    }

    static void Main()
    {
        Console.Write("Enter First Number : ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number : ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Calculator cal = null;

        switch (choice)
        {
            case 1:
                cal = Add;
                break;

            case 2:
                cal = Subtract;
                break;

            case 3:
                cal = Multiply;
                break;

            case 4:
                cal = Divide;
                break;

            default:
                Console.WriteLine("Invalid Choice");
                return;
        }

        Console.WriteLine("Result = " + cal(n1, n2));
    }
}

