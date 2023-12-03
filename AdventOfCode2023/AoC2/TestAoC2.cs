
using AdventOfCode2023.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2023;

public class TestAoC2
{
    [Fact]
    public void AnswerOne()
    {
        var input = FileHelper.ReadFile("AoC2", "input.txt");
        var expected = 2679;

        var actual = AoC2a.Solve(input);

        actual.Should().Be(expected);
    }

    [Fact]
    public void AnswerTwo()
    {
        var input = FileHelper.ReadFile("AoC2", "input.txt");
        var expected = 77607;

        var actual = AoC2b.Solve(input);

        actual.Should().Be(expected);
    }
}
