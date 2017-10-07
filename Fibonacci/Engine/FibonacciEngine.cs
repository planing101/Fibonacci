﻿using System;
using System.Collections.Generic;

namespace Fibonacci.Engine
{
    public class FibonacciEngine
    {
        public int MaxIterations { get; set; } = 87;

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

            GetInput();
        }

        public void OutputSequence(List<ulong> seq)
        {
            int index = 1;

            foreach (ulong num in seq)
                Console.WriteLine(String.Format("{0}: {1}", index++, num.ToString("#,##0")));
        }

        private void GetInput()
        {
            var input = Console.ReadLine();

            MaxIterations = String.IsNullOrEmpty(input) ? MaxIterations : Convert.ToInt32(input);
        }
    }
}
