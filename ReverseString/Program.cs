﻿namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a string reversal tool!\n\nEnter a string of characters and press enter. \n");

            string userInput = Console.ReadLine();
            Console.WriteLine($"You entered: {userInput}\n");

            string reversed = "";
            int length = userInput.Length;

            for (int letterCount = 0; letterCount < length; letterCount++)
            {
                reversed += Char.ToLower(userInput[length - letterCount - 1]);
            }

            Console.WriteLine($"\"{userInput}\" reversed is: {reversed}");
            if (reversed == userInput.ToLower())
            {
                Console.WriteLine($"{reversed} is a palindrome!");
            }
        }
    }
}