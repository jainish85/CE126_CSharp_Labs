using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> history = new Stack<string>();
        int choice;

        do
        {
            Console.WriteLine("\n Browser History ");
            Console.WriteLine("1. Visit Page");
            Console.WriteLine("2. Go Back");
            Console.WriteLine("3. Current Page");
            Console.WriteLine("4. Show History");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter webpage: ");
                    history.Push(Console.ReadLine());
                    break;

                case 2:
                    if (history.Count > 0)
                        Console.WriteLine("Going back from: " + history.Pop());
                    else
                        Console.WriteLine("No history!");
                    break;

                case 3:
                    if (history.Count > 0)
                        Console.WriteLine("Current page: " + history.Peek());
                    else
                        Console.WriteLine("No page opened!");
                    break;

                case 4:
                    Console.WriteLine("Browsing History:");
                    foreach (string page in history)
                        Console.WriteLine(page);
                    break;
            }

        } while (choice != 5);
    }
}