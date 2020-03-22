using System;

namespace C.Net_learning
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var Name = Console.ReadLine();
            Console.WriteLine("Your name is: {0}", Name);

            Console.WriteLine("How old are you?");
            var Age = Console.ReadLine();
            Console.WriteLine("So your name is: {0} and your age is: {1}", Name, Age);

            Console.WriteLine("What month did you born in?");
            var Month = Console.ReadLine();

            if (Month == "March")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (Month == "April")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (Month == "May")
            {
                Console.WriteLine("You are a Gemini");
            }

            var password = "";
            while (password != "secret")
            {
                Console.WriteLine("Please enter the password");
                password = Console.ReadLine();
                if (password != "secret")
                {
                    Console.WriteLine("The password is incorrect");
                }

            }
            Console.WriteLine("Password is correct");



            for (int count = 1; count <= 10; count++)
            {
                Console.WriteLine("Count: {0}", count);
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(j);

                }
                for (int k = 9; k >= 1; k--)
                {
                    Console.WriteLine(k);
                }
            }

        }
    }
}