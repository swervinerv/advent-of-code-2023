using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023.AoC3.Classes;

public class DataPoint
{
	public Tuple<int, int> Location { get; init; }
	public int Value { get; init; }

	public DataPoint(int value, Tuple<int, int> location)
	{
		this.Value = value;
		this.Location = location;
	}

	public bool IncludePartNumber(List<Tuple<int, int>> symbols)
	{
		var startX = this.Location.Item1 - 1;
		var startY = this.Location.Item2 - 1;

		var middleY = startY + 1;

		var endX = startX + this.Value.ToString().Length + 1;
		var endY = middleY + 1;

		if (Value == 25)
		{

		}

        if (symbols.Any(_ => (_.Item1 == startX && _.Item2 == middleY) || (_.Item1 == endX && _.Item2 == middleY)))
        {
            return true;
        }

        for (var x = startX; x <= endX; x++)
		{
			if (symbols.Any(_ => _.Item1 == x && (_.Item2 == startY || _.Item2 == endY)))
			{
				return true;
			}
		}

        return false;
	}
}

