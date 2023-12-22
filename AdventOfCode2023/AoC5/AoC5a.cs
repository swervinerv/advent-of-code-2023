using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2023.AoC5.Classes;
using AdventOfCode2023.Helpers;

namespace AdventOfCode2023;

public class AoC5a
{
    public static long Solve(string input)
    {
        var seeds = new List<long>();
        var mappings = new Dictionary<string, List<int>>();


        var lines = input.ParseToArrayByNewLine();
        seeds.AddRange(lines[0]
            .Split(':')[1]
            .Split(' ')
            .Where(_ => !string.IsNullOrWhiteSpace(_))
            .Select(long.Parse));

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
        foreach (var seed in seeds)
        {
            long seedLocation = seed;
            foreach (var mapping in plotMappings.OrderBy(_ => _.MappingIndex))
            {
                seedLocation = mapping.GetMappedLocation(seedLocation);
            }

            seedLocations.Add(seedLocation);
        }

        return seedLocations.Min();
    }
}

