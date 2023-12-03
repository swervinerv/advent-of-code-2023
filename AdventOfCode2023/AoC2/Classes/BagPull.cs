using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023.AoC2.Classes;

public class BagPull
{
    private readonly List<Cube> cubesPulled = new();

    public int BlueCount
        => this.cubesPulled.Where(_ => _.Color.ToLower() == "blue").Sum(_ => _.Count);

    public int GreenCount
        => this.cubesPulled.Where(_ => _.Color.ToLower() == "green").Sum(_ => _.Count);

    public int RedCount
        => this.cubesPulled.Where(_ => _.Color.ToLower() == "red").Sum(_ => _.Count);

    public BagPull(string cubes)
    {
        this.cubesPulled.AddRange(cubes.Split(',')
            .Select(_ => new Cube(_)));
    }

    public bool IsValid()
        => !this.cubesPulled.Any(_ => !_.IsValid());
}

