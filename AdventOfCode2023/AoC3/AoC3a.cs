using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2023.AoC3.Classes;
using AdventOfCode2023.Helpers;

namespace AdventOfCode2023.AoC3;

public class AoC3a
{
    public static int Solve(string input)
    {
        var returnValue = 0;

        var lines = input.ParseToArrayByNewLine();

        var dataPoints = new List<DataPoint>();
        var symbolPoints = new List<Tuple<int, int>>();

        for (var y = 0; y < lines.Length; y++)
        {
            char[] characters = lines[y].ToCharArray();
            var numberString = "";

            for (var x = 0; x < characters.Length; x++)
            {
                var character = characters[x];

                if (char.IsDigit(character))
                {
                    numberString += $"{character}";

                    if (x == characters.Length - 1)
                    {
                        dataPoints.Add(new(int.Parse(numberString), new Tuple<int, int>(x - numberString.Length, y)));
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(numberString))
                    {
                        dataPoints.Add(new(int.Parse(numberString), new Tuple<int, int>(x - numberString.Length, y)));
                    }

                    numberString = "";

                    if (character != '.')
                    {
                        symbolPoints.Add(new(x, y));
                    }
                }
            }
        }

        foreach (var dataPoint in dataPoints)
        {
            if (dataPoint.IncludePartNumber(symbolPoints))
            {
                returnValue += dataPoint.Value;
            }
        }

        return returnValue;
    }
}

