﻿// See https://aka.ms/new-console-template for more information



namespace ArrayComparison
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            string[] inputStr1 = { "Java", "CSharp", "Xamarin", "Windows", "android", "iOS" };
            string[] inputStr2 = { "Java", "CSharp", "Xamarin", "Windows", "android", "iOS" };
            string[] inputStr3 = { "Java", "CSharp", "Xamarin", "Windows", "android", "Windows Phone" };


            Console.WriteLine("Comparison result of inputStr and input2 is " + Enumerable.SequenceEqual(inputStr1, inputStr2));
            Console.WriteLine("Comparison result of inputStr and input3 is " + Enumerable.SequenceEqual(inputStr1, inputStr3));

            Console.WriteLine("Comparison result of inputStr2 and input is " + Enumerable.SequenceEqual(inputStr2, inputStr1));
            Console.WriteLine("Comparison result of inputStr2 and input3 is " + Enumerable.SequenceEqual(inputStr2, inputStr3));

            Console.WriteLine("Comparison result of inputStr3 and input1 is " + Enumerable.SequenceEqual(inputStr3, inputStr1));
            Console.WriteLine("Comparison result of inputStr3 and input2 is " + Enumerable.SequenceEqual(inputStr3, inputStr2));
            Console.ReadLine();
        }
    }
}