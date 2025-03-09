using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        int userNumber =-1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       
        while (userNumber !=0)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            } 
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average =((float)sum) / numbers.Count;

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average:F2}");
        Console.WriteLine($"The largest number is: {max} ");
    }
}
