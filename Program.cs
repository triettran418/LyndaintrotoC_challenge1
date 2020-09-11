using System;
using System.Diagnostics.CodeAnalysis;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            var question1 = "What is your name?";
            var question2 = "How old are you?";
            var question3 = "what month were you born in?";
            Console.WriteLine(question1);
            var answer1 = Console.ReadLine();
            Console.WriteLine(question2);
            var answer2 = Console.ReadLine();
            Console.WriteLine(question3);
            var answer3 = Console.ReadLine();

            Console.WriteLine("your name is {0}",answer1);
            Console.WriteLine("your age is {0}",answer2);
            Console.WriteLine("your birth month is {0}",answer3);
        }
    }
}
