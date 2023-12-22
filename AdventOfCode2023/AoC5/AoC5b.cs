using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2023.AoC5.Classes;
using AdventOfCode2023.Helpers;

namespace AdventOfCode2023;

public class AoC5b
{
    public static long Solve(string input)
    {
        var seeds = new List<long>();
        var seedList = new List<Tuple<long, long>>();
        var mappings = new Dictionary<string, List<int>>();

        var lines = input.ParseToArrayByNewLine();
        var seedData = lines[0]
            .Split(':')[1]
            .Split(' ')
            .Where(_ => !string.IsNullOrWhiteSpace(_))
            .Select(long.Parse)
            .ToArray();

        for (var x = 0; x < seedData.Length; x += 2)
        {
            seedList.Add(new(seedData[x], seedData[x + 1]));

            //for (var y = 0; y < seedData[x + 1]; y++)
            //{
            //    seeds.Add(seedData[x] + y);
            //}
        }

        lines = lines.Skip(2).ToArray();

        var currentKey = "";
        var mappingRanges = new List<int>();

        var plotMapping = new PlotMapping();
        var plotMappings = new List<PlotMapping>();

        int mappingIndex = 0;

        foreach (var line in lines.Where(_ => !string.IsNullOrWhiteSpace(_)))
        {
            if (!char.IsDigit(line[0]))
            {
                currentKey = line.Split(' ')[0].Trim();

                plotMapping = new(currentKey, mappingIndex);

                plotMappings.Add(plotMapping);

                mappingIndex++;

                continue;
            }

            plotMapping.AddMappingInput(line);
        }

        var seedLocations = new List<long>();
        foreach (var seed in seedList)
        {
            long seedLocation = seed.Item1;
            while (seedLocation < seed.Item2)
            {
                long location = seed.Item1;
                foreach (var mapping in plotMappings.OrderBy(_ => _.MappingIndex))
                {
                    location = mapping.GetMappedLocation(seedLocation);
                }

                seedLocations.Add(location);

                seedLocation++;
            }
        }

        return seedLocations.Min();
    }
}

