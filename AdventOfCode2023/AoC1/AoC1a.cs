using System;
using System.Linq;

namespace AdventOfCode2023
{
    class AoC1a
    {
        public int Solve(string input)
        {
            var inputs = ParseInput(input);

            var currVal = 0;
            var maxVal = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == -1)
                {
                    maxVal = Math.Max(currVal, maxVal);
                    currVal = 0;
                } 
                else
                {
                    currVal += inputs[i];
                }
            }

            return maxVal;
        }

        private static int[] ParseInput(string input)
        {
            return input.ReplaceLineEndings().Split(Environment.NewLine).Select(_ => _ == "" ? "-1" : _).Select(_ => int.Parse(_)).ToArray();
        }
    }
}
