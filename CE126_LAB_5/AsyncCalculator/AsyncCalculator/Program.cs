using System;
using System.Threading.Tasks;

class Calculator
{
    static async Task<double> add(double x, double y)
    {
        await Task.Delay(2000);
        return x + y;
    }

    static async Task<double> sub(double x, double y)
    {
        await Task.Delay(2000);
        return x - y;
    }

    static async Task<double> Mul(double x, double y)
    {
        await Task.Delay(2000);
        return x * y;
    }

    static async Task<double> Div(double x, double y)
    {
        await Task.Delay(2000);

        if (y == 0)
            throw new DivideByZeroException();

        return x / y;
    }

    static async Task Main()
    {
        double a = 20;
        double b = 5;

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Perform All Operations");

        Console.Write("Enter your choice: ");
        int ch = Convert.ToInt32(Console.ReadLine());

        switch (ch)
        {
            case 1:
                Console.WriteLine("Addition = " + await add(a, b));
                break;

            case 2:
                Console.WriteLine("Subtraction = " + await sub(a, b));
                break;

            case 3:
                Console.WriteLine("Multiplication = " + await Mul(a, b));
                break;

            case 4:
                Console.WriteLine("Division = " + await Div(a, b));
                break;

            case 5:
                Task<double> t1 = add(a, b);
                Task<double> t2 = sub(a, b);
                Task<double> t3 = Mul(a, b);
                Task<double> t4 = Div(a, b);

                double[] result = await Task.WhenAll(t1, t2, t3, t4);

                Console.WriteLine("Addition = " + result[0]);
                Console.WriteLine("Subtraction = " + result[1]);
                Console.WriteLine("Multiplication = " + result[2]);
                Console.WriteLine("Division = " + result[3]);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}