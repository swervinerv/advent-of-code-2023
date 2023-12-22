using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023.AoC5.Classes;

public class PlotMapping
{
    private readonly List<Tuple<long, long, int>> mappingInput = new();

	public string MappingName { get; init; }
	public int MappingIndex { get; init; }

    public PlotMapping() { }


    public PlotMapping(string mappingName, int index)
	{
        MappingName = mappingName;
        MappingIndex = index;
    }

    public void AddMappingInput(string input)
    {
        var rangeDetails = input.Split(' ');

        var rangeLength = int.Parse(rangeDetails[2]);
        var sourceStart = long.Parse(rangeDetails[1]);
        var destinationStart = long.Parse(rangeDetails[0]);

        this.mappingInput.Add(new(sourceStart, destinationStart, rangeLength));
    }

    public long GetMappedLocation(long currentLocation)
    {
        var matchingMapping = this.mappingInput
            .SingleOrDefault(_ => _.Item1 <= currentLocation && currentLocation < (_.Item1 + _.Item3));

        if (matchingMapping != null)
        {
            var mappingDiff = matchingMapping.Item1 - matchingMapping.Item2;

            return currentLocation - mappingDiff;
        }

        return currentLocation;
    }
}
