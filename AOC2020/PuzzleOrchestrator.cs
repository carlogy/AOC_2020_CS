using AOC2020.Days;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOC2020;

    internal static class PuzzleOrchestrator
    {
        public static int GetPuzzleDay() {

            Console.WriteLine("AOC 2020");
            Console.WriteLine("What day do you want to solve?");
            var day = Convert.ToInt32(Console.ReadLine());

            if (day > 26 || day < 1) {
                Console.WriteLine($"You selected {day}, only days 1-25 have puzzles to solve. Please try again.");
            }
            return day;
        }

        public static string[] GetPuzzleInput(int day) {
            Console.WriteLine("Getting puzzle input...");
            var puzzleInput = PuzzleInputReader.GetInput(day);
            return puzzleInput;
        }
        
        public static (string Part1, string Part2) SolvePuzzle(IPuzzleDay day)
        {
            return day.Solve();
        }

        public static void PrintSolution((string, string) solution) {
             Console.WriteLine($"Part 1:\t{solution.Item1}\nPart 2:\t{solution.Item2}");
        }

        public static IPuzzleDay CreatePuzzleDay(int day, string[] puzzleinput) {

            if (day < 0 || day > 25) 
            {
                throw new ArgumentOutOfRangeException($"The day provided ({day}) is not a puzzle day");
            }

            switch (day) 
            {
                case 1: return new Day1(puzzleinput);
                default: throw new NotImplementedException("Day not solved yet try again!"); 
            
            }
        }
    }