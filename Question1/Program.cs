using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
                int i = 0;
            string[] userName = new string [3]{"John", "David", "James"};
            string[] password = new string [3]{"pushing", "stepping", "mounting"};

            Console.WriteLine("Enter your username");
            string user = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string userP = Console.ReadLine();

            if (userName[i].Contains(user) && password[i].Contains(userP))
            {
                if (userName[i] == password[i])
                {
                    Console.WriteLine("Login successful!");
                }else{
                    Console.WriteLine("Check your details!");
                }
            }else{
                Console.WriteLine("User not found!");
            }
        }
    }
}
