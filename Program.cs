using System;

class Program
{
    static double CalculateAverage(int grade1, int grade2 , int grade3)
    {
        return ( grade1 + grade2 + grade3 ) / 3;
    }
    static void Main()
    {
        string studentName = "Ahmad";

        int grade1 = 85;
        int grade2 = 90;
        int grade3 = 80;

        double average = CalculateAverage(grade1 , grade2 , grade3);

        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Grade 1: " + grade1);
        Console.WriteLine("Grade 2: " + grade2);
        Console.WriteLine("Grade 3: " + grade3);

        Console.WriteLine("Average: " + average);


        Console.WriteLine("Name: Mohammed Nabeel Ali Taheer");
        Console.WriteLine("Sofware Engineer");
        Console.ReadKey();
    }

}