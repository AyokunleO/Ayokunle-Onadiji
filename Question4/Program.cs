using System;

namespace Question4
{
    class Program
    {
        int i = 0;
        int [] numbers = new int[50];
        static void Main(string[] args)
        {
           numbers = Sum(new int [50]);
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; 
            }
            Console.WriteLine($"The total sum of the numbers is {Sum}");
        }
        public int Sum(int [] num)
        {
            int Sum = 0;
            Sum += numbers[i];
            return Sum;
        }
    }
}
