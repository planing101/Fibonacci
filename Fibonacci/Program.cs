using Fibonacci.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
