using AdventOfCode2023.AoC2.Classes;
using AdventOfCode2023.Helpers;
using System.Collections.Generic;
using System.Linq;  

namespace AdventOfCode2023;

public class AoC2b
{
    public static int Solve(string input)
    {
        int returnValue = 0;

        var lines = input.ParseToArrayByNewLine();
        foreach (var line in lines)
        {
            Game game = new(line);

            returnValue += game.GetCubePowers();
        }

        return returnValue;
    }
}
