
using AdventOfCode2023.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2023;

public class TestAoC1b
{
    [Fact]
    public void Answer()
    {
        var input = FileHelper.ReadFile("AoC1", "aoc1b.txt");
        var expected = 54591;

        var actual = AoC1b.Solve(input);

        actual.Should().Be(expected);
    }
}
