using System;

namespace GithubCrispyChainsaw
{
    class Program
    {

        static void Main()
        {
            string temp;
            int total = 0, correct = 25, answer;

            Console.WriteLine("Welcome to the Question Game");

            do
            {
                Console.WriteLine("What is 5x5?");
                temp = Console.ReadLine();
                answer = Convert.ToInt32(temp);

                if (answer!=correct)
                {
                    Console.WriteLine("You are wrong!");
                }

                total += 1;

                Question2();
                Question3();

            } while (total < 3);
       
        static void Question2()
        {
            Random rand = new Random();
            
            Console.WriteLine(rand);

        }

        static void Question3()
        {
            string temp;
            Console.WriteLine("What is the original name for Myanmar?");
            temp = Console.ReadLine();
    


            
        }
    }
}
