using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int[50];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                sum += numbers[i]; 
            }
            Console.WriteLine($"The total sum of the numbers is {sum}");
        }
    }
}
