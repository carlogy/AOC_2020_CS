using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace AOC2020
{
    internal static class PuzzleInputReader
    {
        public static string[] GetInput(int day) {

            if (day < 0)
            {
                throw new ArgumentOutOfRangeException($"Day: {day} must be between 1 and 25");
            }

            var path = GetPathOfFile(day);
            var contents = ReadTheFile(path);
            return contents;
        }
        private static string GetPathOfFile(int day) {
            var path = $"Z:\\Documents\\WinDev\\Learning\\AOC\\AOC2020\\InputFiles\\Day{day}Input.txt";
            return path ;
        }

        private static string[] ReadTheFile(string path) {

            if (!File.Exists(path)) {
                throw new FileNotFoundException($"File not found at path:\t{path}");
            }

            string[] fileContents;
            try
            {
                fileContents = File.ReadAllLines(path);
                return fileContents;
            }
            catch (Exception e) {
                Console.Write(e.ToString());
                throw;
            }
        }
    }
}
