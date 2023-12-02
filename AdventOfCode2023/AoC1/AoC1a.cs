using AdventOfCode2023.Helpers;
using System.Linq;

namespace AdventOfCode2023;

class AoC1a
{
    public static int Solve(string input)
    {
        int returnValue = 0;

        var inputs = input.ParseToArrayByNewLine();
        foreach (var line in inputs)
        {
            var numbers = line.Where(char.IsDigit).ToArray();
            if (numbers.Length == 0)
            {
                continue;
            }

            var digit1 = numbers[0];
            var digit2 = numbers[^1];

            returnValue += int.Parse($"{digit1}{digit2}");
        }

        return returnValue;
    }
}
