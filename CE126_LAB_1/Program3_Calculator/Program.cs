using System;

class Calculator
{
    static void Main()
    {
        int choice;
        double num1, num2;

        Console.WriteLine("===== Calculator =====");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");

        Console.Write("Enter your choice (1-5): ");
        choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter First Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + (num1 + num2));
                break;

            case 2:
                Console.WriteLine("Result = " + (num1 - num2));
                break;

            case 3:
                Console.WriteLine("Result = " + (num1 * num2));
                break;

            case 4:
                if (num2 != 0)
                    Console.WriteLine("Result = " + (num1 / num2));
                else
                    Console.WriteLine("Division by zero is not allowed.");
                break;

            case 5:
                if (num2 != 0)
                    Console.WriteLine("Result = " + (num1 % num2));
                else
                    Console.WriteLine("Modulus by zero is not allowed.");
                break;

            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }
}
