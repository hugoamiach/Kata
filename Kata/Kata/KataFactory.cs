using System;
using System.Collections.Generic;
using System.Linq;
using Kata.Kata;

namespace Kata
{
    public class KataFactory : IKataFactory
    {
        private readonly List<KataObject> _katas;

        public KataFactory()
        {
            _katas = new List<KataObject>
            {
                new()
                {
                    Id = 1,
                    Name = "Fibonacci",
                    Created = () => new Fibonacci()
                },
                new()
                {
                    Id = 2,
                    Name = "FizzBuzz",
                    Created = () => new FizzBuzz()
                }
            };
        }

        public IKata CreateKata()
        {
            Console.WriteLine("Enter the number of the kata to be executed :");

            _katas.ForEach(_ => Console.WriteLine($"{_.Id} - {_.Name}"));
            if (!int.TryParse(Console.ReadLine(), out int kataId))
                throw new Exception("Invalid argument - le numéro du kata doit être un nombre");

            var kata = _katas.FirstOrDefault(_ => _.Id == kataId);
            if (kata is null) throw new Exception("Kata is not found");
            return kata.Created.Invoke();
        }
    }
}