
using AdventOfCode2023.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2023;

public class TestAoC1a
{
    [Fact]
    public void Answer()
    {
        var input = FileHelper.ReadFile("AoC1", "aoc1a.txt");
        var expected = 54573;

        var actual = AoC1a.Solve(input);

        actual.Should().Be(expected);
    }
}
