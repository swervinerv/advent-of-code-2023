using System;
using System.Linq;

namespace AdventOfCode2023.Helpers;

public static class StringExtensions
{
	public static string[] ParseToArrayByNewLine(this string input)
		=> input.ReplaceLineEndings().Split(Environment.NewLine).ToArray();
}

