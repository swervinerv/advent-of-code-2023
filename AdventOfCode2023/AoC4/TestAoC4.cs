using AdventOfCode2023.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2023;

public class TestAoC4
{
    [Fact]
    public void AnswerOne()
    {
        var input = FileHelper.ReadFile("AoC4", "input.txt");
        var expected = 20107;

        var actual = AoC4a.Solve(input);

        actual.Should().Be(expected);
    }

    [Fact]
    public void AnswerTwo()
    {
        var input = FileHelper.ReadFile("AoC4", "input.txt");
        var expected = 8172507;

        var actual = AoC4b.Solve(input);

        actual.Should().Be(expected);
    }
}

