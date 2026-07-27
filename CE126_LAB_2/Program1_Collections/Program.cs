using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.WriteLine("=== List ===");
        List<int> list = new List<int>() { 10, 20, 30, 40, 50 };

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\n=== Dictionary ===");
        Dictionary<int, int> dict = new Dictionary<int, int>()
        {
            {1, 100},
            {2, 200},
            {3, 300},
            {4, 400},
            {5, 500}
        };

        foreach (KeyValuePair<int, int> pair in dict)
        {
            Console.WriteLine("Key: " + pair.Key + " Value: " + pair.Value);
        }


        Console.WriteLine("\n=== Stack (LIFO) ===");
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\n=== Queue (FIFO) ===");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}