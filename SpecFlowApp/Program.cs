using System;

namespace SpecFlow.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator
            {
                FirstNumber = 50,
                SecondNumber = 10,
            };

            var result = calc.Add();

            Console.WriteLine($"{calc.FirstNumber} + {calc.SecondNumber} = {result}");
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
