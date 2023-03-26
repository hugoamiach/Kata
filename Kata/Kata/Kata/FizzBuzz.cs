using System;

namespace Kata.Kata
{
    public class FizzBuzz : IKata
    {
        public void Run()
        {
            Console.WriteLine("Entrer the number for FizzBuzz");
            if (!int.TryParse(Console.ReadLine(), out var number)) throw new Exception("Invalid parameter");

            for (var i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} -> {GetFizzBuzzForIndex(i)}");
            }
        }

        private string GetFizzBuzzForIndex(int number)
        {
            var result = "";
            if (number % 3 != 0 && number % 5 != 0) return number.ToString();
            if (number % 3 == 0) result = "Fizz";
            if (number % 5 == 0) result += "Buzz";
            return result;
        }
    }
}