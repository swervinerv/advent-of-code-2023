using System;
namespace AdventOfCode2023.AoC2.Classes;

public class Cube
{
    private readonly int redMax = 12;
    private readonly int greenMax = 13;
    private readonly int blueMax = 14;

    public string Color { get; init; }
    public int Count { get; init; }

    public Cube(string input)
    {
        Color = input.Trim().Split(' ')[1];
        Count = int.Parse(input.Trim().Split(' ')[0]);
    }

    public bool IsValid()
    {
        return this.Color.ToLower() switch
        {
            "blue" => this.Count <= this.blueMax,
            "green" => this.Count <= this.greenMax,
            "red" => this.Count <= this.redMax,
            _ => false,
        };
    }
}

