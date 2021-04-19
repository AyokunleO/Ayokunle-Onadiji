using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your illness(cancer or cold)");
            string illness = Console.ReadLine();
            Console.WriteLine("Enter your financial status(rich or poor)");
            string status = Console.ReadLine();
            if (illness.ToUpper() == "CANCER" && status.ToUpper() == "RICH")
            {
                Console.WriteLine("Surgery!");
            }else if(illness.ToUpper() == "CANCER" && status.ToUpper() == "POOR")
            {
                Console.WriteLine("Make a public call!");
            }else if(illness.ToUpper() == "COLD" && status.ToUpper() == "RICH")
            {
                Console.WriteLine("Take special care!");
            }else if(illness.ToUpper() == "COLD" && status.ToUpper() == "POOR")
            {
                Console.WriteLine("Send home!");
            }else{
                Console.WriteLine("There are no other possibilities!");
            }

        }
    }
}
