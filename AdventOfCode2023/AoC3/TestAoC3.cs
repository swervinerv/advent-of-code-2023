using System;
using AdventOfCode2023.AoC3;
using AdventOfCode2023.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2023;

public class TestAoC3
{
    [Fact]
    public void AnswerOne()
    {
        var input = FileHelper.ReadFile("AoC3", "input.txt");
        var expected = 532828;

        var actual = AoC3a.Solve(input);

        actual.Should().Be(expected);
    }

    [Fact]
    public void AnswerTwo()
    {
        var input = FileHelper.ReadFile("AoC3", "input.txt");
        var expected = 77607;

        var actual = AoC2b.Solve(input);

        actual.Should().Be(expected);
    }
}

