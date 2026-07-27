using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();

        Dictionary<string, int> freq = new Dictionary<string, int>();

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
            {
                freq[word] = freq[word] + 1;
            }
            else
            {
                freq[word] = 1;
            }
        }

        Console.WriteLine("\nWord Count:");
        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " = " + item.Value);
        }

        Console.ReadLine();
    }
}