using System;

namespace GithubCrispyChainsaw
{
    class Program
    {
        private static int Score = 0, total = 0;

        public static void Main() //main
        {


            Console.WriteLine("Welcome to the Question Game"); //title

            do
            {
                Question1();
                Question2();
                Question3();
                Question4();

            } while (total < 5);

            Console.WriteLine($"{Score}");
            Console.ReadLine();


        }

        public static void Question1() //actual question
        {
            string temp;
            Console.WriteLine("What is 5x5?");
            temp = Console.ReadLine();

            if (temp == "25")
            {
                Console.WriteLine("You are correct!");
                Console.ReadLine();
                Score = Score + 1;
            }
            else
            {
                Console.WriteLine("Sorry you are incorrect.");
            }
            total += 1;
        }
        public static void Question2() //actual question
        {
            string temp;
            Console.WriteLine("What is the original name for the country of Myanmar?");
            temp = Console.ReadLine();

            if (temp == "Burma" || temp == "burma")
            {
                Console.WriteLine("You are correct!");
                Console.ReadLine();
                Score = Score + 1;
            }
            else
            {
                Console.WriteLine("Sorry you are incorrect.");
            }
            total += 1;
        }

        public static void Question3() //actual question
        {
            string temp;
            Console.WriteLine("What is the highest peak in New Zealand?");
            temp = Console.ReadLine();

            if (temp == "Mount Cook" || temp == "Mt Cook" || temp == "mount cook" || temp == "Mt cook" || temp == "mt cook")
            {
                Console.WriteLine("You are correct!");
                Console.ReadLine();
                Score = Score + 1;
            }
            else
            {
                Console.WriteLine("Sorry you are incorrect.");
            }
            total += 1;
        }

        public static void Question4() //for a laugh
        {
            string emotion;

            Console.WriteLine("How are you feeling?");
            emotion = Console.ReadLine();

            Console.WriteLine($"I do not care that you are feeling {emotion}");
            Console.ReadLine();
        }



    }
}
