using System;

namespace Space
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Do you want linear calculator or nonlinear(1 or 2)");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Enter how many numbers are you gonna calculate the average sum");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter start of the numbers");
                float start = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the gap of each number");
                float gap = float.Parse(Console.ReadLine());
                float sum = 0;
                float num = number;

                while (number > 0)
                {
                    sum += start;
                    start += gap;
                    number--;
                }
                Console.WriteLine($"Average sum of entered numbers - {sum / num}");
            }

            else if (option == "2")
            {
                Console.WriteLine("Enter how many numbers are you gonna calculate");
                int number = int.Parse(Console.ReadLine());
                float sum = 0;

                while (number > 0)
                {
                    Console.WriteLine("Enter the number");
                    sum += float.Parse(Console.ReadLine());
                    number--;
                }
                Console.WriteLine($"Sum of the numbers is {sum}");
            }
            Console.WriteLine("Type 1 to continue or anything to quit");
            option = Console.ReadLine();
            if (option == "1")
                Main();
            else return;


        }
    }
}