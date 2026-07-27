using System;

class StudentResult
{
    static void Main()
    {
        int[] marks = new int[5];
        int total = 0;
        double percentage;

        Console.WriteLine("Enter marks for 5 subjects (0-100):");

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());

                if (marks[i] >= 0 && marks[i] <= 100)
                    break;
                else
                    Console.WriteLine("Invalid marks! Please enter between 0 and 100.");
            }

            total += marks[i];
        }

        percentage = total / 5.0;

        string grade;

        if (percentage >= 90)
            grade = "A+";
        else if (percentage >= 80)
            grade = "A";
        else if (percentage >= 70)
            grade = "B";
        else if (percentage >= 60)
            grade = "C";
        else if (percentage >= 50)
            grade = "D";
        else
            grade = "F";

        Console.WriteLine("\n----- Student Result -----");
        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Percentage  : " + percentage + "%");
        Console.WriteLine("Grade       : " + grade);
    }
}
