using System;
using System.Collections;

namespace PalindromGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string reversWord = "";
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversWord += word[i];
            }
            Console.WriteLine("");

            Console.WriteLine("Original word:");

            Console.WriteLine(word);

            Console.WriteLine(" ");

            Console.Write("Reversed word:");

            Console.Write(reversWord +"\n");


            Console.WriteLine(" ");

            if (reversWord.Equals(word))
            {
                Console.Write("This is a palindrom");
            }
            else
            {
                Console.Write("This is not a palindrom");

            }

        }
    }
}
