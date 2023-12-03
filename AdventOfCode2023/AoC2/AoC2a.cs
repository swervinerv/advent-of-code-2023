using AdventOfCode2023.AoC2.Classes;
using AdventOfCode2023.Helpers;

namespace AdventOfCode2023;

class AoC2a
{
    public static int Solve(string input)
    {
        int returnValue = 0;

        var lines = input.ParseToArrayByNewLine();
        foreach (var line in lines)
        {
            Game game = new(line);

            if (game.IsValid())
            {
                returnValue += game.GameValue;
            }
        }

        return returnValue;
    }
}
