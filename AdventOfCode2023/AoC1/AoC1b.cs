using AdventOfCode2023.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023;

public class AoC1b
{
    public static int Solve(string input)
    {
        int returnValue = 0;

        char[] intNumbersArray = "0123456789".ToCharArray();
        string[] stringNumberArray = "one two three four five six seven eight nine".Split(' ').ToArray();

        var inputs = input.ParseToArrayByNewLine();
        foreach (var line in inputs)
        {
            var indexes = new Dictionary<int, int>();

            for (var x = 0; x < stringNumberArray.Length; x++)
            {
                var num = stringNumberArray[x];
                var numberIndex = line.IndexOf(num);
                if (numberIndex != -1)
                {
                    indexes.Add(numberIndex, x + 1);
                }

                numberIndex = line.LastIndexOf(num);
                if (numberIndex != -1 && !indexes.ContainsKey(numberIndex))
                {
                    indexes.Add(numberIndex, x + 1);
                }
            }

            for (var y = 0; y < intNumbersArray.Length; y++)
            {
                var num = intNumbersArray[y];
                var numberIndex = line.IndexOf(num);
                if (numberIndex != -1)
                {
                    indexes.Add(numberIndex, y);
                }

                numberIndex = line.LastIndexOf(num);
                if (numberIndex != -1 && !indexes.ContainsKey(numberIndex))
                {
                    indexes.Add(numberIndex, y);
                }
            }

            var digit1 = indexes.GetValueOrDefault(indexes.Min(_ => _.Key));
            var digit2 = indexes.GetValueOrDefault(indexes.Max(_ => _.Key));

            returnValue += int.Parse($"{digit1}{digit2}");
        }

        return returnValue;
    }
}
