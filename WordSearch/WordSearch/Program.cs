using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            string word1 = "cat";
            string word2 = "hello";
            string word3 = "code";
            string word4 = "jump";

            int points = 0;

            bool exit = false;
            Console.WriteLine("'o','p','r','i','h'\n" +
                              "'t','a','m','e','s',\n" +
                              "'a','d','l','u','j',\n" +
                              "'c','l','q','o','j'\n" +
                              "'o','e','d','o','c' ");

            while (exit == false)
            {
                Console.WriteLine("Enter the word you found:");
                string userWord = Console.ReadLine();

                if (userWord == word1 || userWord == word2 || userWord == word3 || userWord == word4)
                {
                    Console.WriteLine("You found 1 word");
                    points += 1;
                }
                else
                {
                    Console.WriteLine("You have enter an invalid word!\nPlease try again!");
                }
                if (points == 4)
                {
                    Console.WriteLine("You have found all the words! Good Job!");
                    exit = true;

                }

            }


        }
    }
}
