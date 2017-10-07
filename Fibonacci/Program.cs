using Fibonacci.Engine;
using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new FibonacciEngine();

            fibonacci.Intro();

            var sequence = fibonacci.CalculateSequence(fibonacci.MaxIterations);

            fibonacci.OutputSequence(sequence);

            Console.ReadKey();
        }
    }
}
