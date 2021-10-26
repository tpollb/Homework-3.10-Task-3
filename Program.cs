using System;

namespace Homework_3._10_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int reminder;
            int i;

            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());

            for (i = 2; i < number; i++)
            {
                reminder = number % i;
                    if (reminder == 0)
                    {
                        Console.WriteLine($"Number {number} is NOT prime");
                        break;
                    } else if (i == number -1)
                        {
                            Console.WriteLine($"Number {number} is prime");
                        }
            }
            

            Console.ReadKey();
        }
    }
}
