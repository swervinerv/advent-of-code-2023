using AdventOfCode2023.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2023;

public class TestAoC5
{
    [Fact]
    public void AnswerOne()
    {
        var input = FileHelper.ReadFile("AoC5", "input.txt");
        //var expected = 35;
        var expected = 388071289;

        var actual = AoC5a.Solve(input);

        actual.Should().Be(expected);
    }

    [Fact]
    public void AnswerTwo()
    {
        var input = FileHelper.ReadFile("AoC5", "input.txt");
        var expected = 46;

        var actual = AoC5b.Solve(input);

        actual.Should().Be(expected);
    }
}

