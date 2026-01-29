// See https://aka.ms/new-console-template for more information

using AOC2020;

var dayToSolve = PuzzleOrchestrator.GetPuzzleDay();
var puzzleInput = PuzzleOrchestrator.GetPuzzleInput(dayToSolve);
var puzzleday = PuzzleOrchestrator.CreatePuzzleDay(dayToSolve, puzzleInput);
var solution = PuzzleOrchestrator.SolvePuzzle(puzzleday);
PuzzleOrchestrator.PrintSolution(solution);