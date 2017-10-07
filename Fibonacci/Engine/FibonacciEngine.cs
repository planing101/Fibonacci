using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Engine
{
    public class FibonacciEngine
    {
        public int MaxIterations { get; set; }

        public List<ulong> CalculateSequence(int max)
        {
            ulong previous = 0;
            ulong current = 1;

            var sequence = new List<ulong>() { previous };

            for (var i = 0; i < (max - 1); i++)
            {
                current = current + previous;
                previous = current - previous;

                sequence.Add(current);
            }

            return sequence;
        }

        public void Intro()
        {
            Console.WriteLine(" Fibonacci Sequencer ");
            Console.WriteLine("=====================");
            Console.WriteLine("");
            Console.Write("Input max number of iterations: ");

            MaxIterations = Convert.ToInt32(Console.ReadLine());
        }

        public void OutputSequence(List<ulong> seq)
        {
            int index = 1;

            foreach (ulong num in seq)
                Console.WriteLine(String.Format("{0}: {1}", index++, num.ToString("#,##0")));
        }
    }
}
