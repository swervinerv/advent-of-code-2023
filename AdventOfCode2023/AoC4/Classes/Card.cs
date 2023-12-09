using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023.AoC4.Classes;

public class Card
{
    private readonly List<int> winningNumbers = new();
    private readonly List<int> revealedNumbers = new();

    public int WinningNumberCount =>
        this.revealedNumbers.Intersect(winningNumbers).ToList().Count;

    public int Value { get; set; }

    public Card(string input)
	{
        var splitGameAndInputs = input.Split(':');
        var splitNumbers = splitGameAndInputs[1].Split('|');

        this.winningNumbers.AddRange(splitNumbers[0]
            .Split(' ')
            .Where(_ => _.Trim().Length > 0)
            .Select(_ => int.Parse(_.Trim())));

        this.revealedNumbers.AddRange(splitNumbers[1]
            .Split(' ')
            .Where(_ => _.Trim().Length > 0)
            .Select(_ => int.Parse(_.Trim())));
    }

    public int Points()
        => WinningNumberCount > 0 ? (int)Math.Pow(2, WinningNumberCount - 1) : 0;
}

