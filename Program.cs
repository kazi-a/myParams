using System;

namespace myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("How many random integer numbers would you like to generate?");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1, 100); // Generating random numbers between 1 and 100
            }

            Console.WriteLine("Random numbers generated:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int addResult = Add(numbers);
            Console.WriteLine($"Total from the Add method: {addResult}");

            int multiplyResult = Multiply(numbers);
            Console.WriteLine($"Product from the Multiply method: {multiplyResult}");
        }

        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        static int Multiply(params int[] numbers)
        {
            int total = 1; // Initialize total to 1
            foreach (int num in numbers)
            {
                total *= num;
            }
            return total;
        }
    }
}
