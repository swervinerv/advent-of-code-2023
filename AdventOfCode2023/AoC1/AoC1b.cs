using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023
{
    class AoC1b
    {
        public int Solve(string input)
        {
            var inputs = ParseInput(input);

            var currVal = 0;

            var vals = new List<int>();

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == -1)
                {
                    vals.Add(currVal);
                    currVal = 0;
                }
                else
                {
                    currVal += inputs[i];
                }
            }

            return vals.OrderByDescending(_ => _).Take(3).Sum();
        }

        private static int[] ParseInput(string input)
        {
            return input.ReplaceLineEndings().Split(Environment.NewLine).Select(_ => _ == "" ? "-1" : _).Select(_ => int.Parse(_)).ToArray();
        }
    }
}
