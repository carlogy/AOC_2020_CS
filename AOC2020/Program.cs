// See https://aka.ms/new-console-template for more information

using AOC2020;
using AOC2020.Days.Day_1;

Console.WriteLine("AOC 2020");
Console.WriteLine("What day do you want to solve?");
var day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Solving Puzzle for day: {day}");


// To do 
// Convert to caller instead of hard coding day to solve. 
var puzzleInput = new PuzzleInputReader(Convert.ToInt32(day));

var Day = new Day1(puzzleInput.GetInput());
var solution = Day.Solve();

Console.WriteLine(solution.ToString());
