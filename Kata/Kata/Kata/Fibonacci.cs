using System;

namespace Kata.Kata
{
    public class Fibonacci : IKata
    {
        public void Run()
        {
            Console.WriteLine("Enter the number n to display the n numbers of the Kata sequence");
            if (!int.TryParse(Console.ReadLine(), out int maxNumber))
                throw new Exception("Your entry must be a number");

            for (var i = 0; i <= maxNumber; i++) Console.WriteLine(RecursiveMethod(i));
        }

        private int RecursiveMethod(int number)
        {
            return number switch
            {
                0 => 0,
                1 or 2 => 1,
                _ => RecursiveMethod(number - 1) + RecursiveMethod(number - 2)
            };
        }
    }
}