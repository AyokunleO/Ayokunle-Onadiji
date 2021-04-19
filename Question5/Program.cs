using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number between 1 and 12");
            while (true)
            {
            int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 12)
                {
                switch (number)
                {
                    case 1:
                    Console.WriteLine("Month is January!");
                    break;
                    case 2:
                    Console.WriteLine("Month is February!");
                     break;
                    case 3:
                    Console.WriteLine("Month is March!");
                     break;
                    case 4:
                    Console.WriteLine("Month is April!");
                     break;
                    case 5:
                    Console.WriteLine("Month is May!");
                     break;
                    case 6:
                    Console.WriteLine("Month is June!");
                     break;
                    case 7:
                    Console.WriteLine("Month is July!");
                     break;
                    case 8:
                    Console.WriteLine("Month is August!");
                     break;
                    case 9:
                    Console.WriteLine("Month is September!");
                     break;
                    case 10:
                    Console.WriteLine("Month is October!");
                     break;
                    case 11:
                    Console.WriteLine("Month is November!");
                     break;
                    case 12:
                    Console.WriteLine("Month is December!");
                     break;
                    default:
                    Console.WriteLine("Number is out of range!");
                    break;
                }       
                }else{
                    Console.WriteLine("Number is out of range!");
                    break;      
                }
            }  
        }
    }
}
