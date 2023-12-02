using System;
using System.IO;

namespace AdventOfCode2023.Helpers;

public static class FileHelper
{
	public static string ReadFile(string filePath, string fileName)
    {
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath, fileName);

        return File.ReadAllText(fullPath);
    }
}

