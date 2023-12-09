using AdventOfCode2023.AoC4.Classes;
using AdventOfCode2023.Helpers;

namespace AdventOfCode2023;

public class AoC4a
{
    public static int Solve(string input)
    {
        var returnValue = 0;

        var lines = input.ParseToArrayByNewLine();

        foreach (var line in lines)
        {
            var card = new Card(line);

            returnValue += card.Points();
        }

        return returnValue;
    }
}

