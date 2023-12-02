using System;
using Xunit;
using FluentAssertions;
using System.IO;

namespace AdventOfCode2023
{
    public class TestAoC1a
    {
        [Fact]
        public void Test1()
        {
            var input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n";
            var expected = 24000;

            var actual = new AoC1a().Solve(input);

            actual.Should().Be(expected);            
        }

        [Fact]
        public void Final()
        {
            var input = ReadFile("AoC1", "aoc1a.txt");
            var expected = 69912;

            var actual = new AoC1a().Solve(input);

            actual.Should().Be(expected);
        }

        private static string ReadFile(string filePath, string fileName)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath, fileName);

            return System.IO.File.ReadAllText(fullPath);
        }
    }
}
