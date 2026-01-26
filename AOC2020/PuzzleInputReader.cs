using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace AOC2020
{
    internal class PuzzleInputReader
    {
        private int _day;
        public int Day { get { return _day; } set { _day = value; } }

        public PuzzleInputReader(int day) {

            if (day < 0) {
                throw new ArgumentOutOfRangeException($"Day: {day} must be between 1 and 25");
                    }
            Day = day; 
        }

        public string[] GetInput() {

            var path = GetPathOfFile(this._day);
            var contents = ReadTheFile(path);
            return contents;
        }
        private string GetPathOfFile(int day) {
            var path = $"Z:\\Documents\\WinDev\\Learning\\AOC\\AOC2020\\InputFiles\\Day{day}Input.txt";
            return path ;
        }

        private string[] ReadTheFile(string path) {

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
