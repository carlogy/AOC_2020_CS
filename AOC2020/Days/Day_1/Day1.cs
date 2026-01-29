using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit.Runner.Common;

namespace AOC2020.Days;

public class Day1(string[] puzzleInput) : Day(puzzleInput)
{
    public override (string Part1, string Part2) Solve()
    {
        var solution1 = FixExpenseReport1(2020);
        this.AddSolution(1, Convert.ToString(solution1));
        var solution2 = FixExpenseReport2(2020);
        this.AddSolution(2, Convert.ToString(solution2));
        return GetSolutions();
    }

    private int FixExpenseReport1(int target)
    {
        var complements = GetComplements1(target);
        return complements.Item1 * complements.Item2;
    }
    private int FixExpenseReport2(int target) {
        var complements = GetComplements2(target);
        return complements.Item1 * complements.Item2 * complements.Item3; 
    }

    private (int, int) GetComplements1(int target)
    {
        var sumsHash = new Dictionary<int, int>();
        for (var i = 0; i < this.PuzzleInput.Length; i++)
        {
            var num = Convert.ToInt32(this.PuzzleInput[i]);
            var complement = target - num;

            if (!sumsHash.ContainsKey(complement))
            {
                sumsHash.Add(num, i);
                continue;
            }
            return (num, complement);
        }
        return (0,0);
    }

    private (int, int, int) GetComplements2(int target)
    {
        var sortedArr = SortandConvertPuzzleInput();   
        for (var i = 0; i < sortedArr.Length - 1; i++) {
            var complement = target - sortedArr[i];
            var result = GetComplements1(complement);
            if (result == (0,0)) {
                continue;
            }
            return (sortedArr[i], result.Item1, result.Item2);
        }
        return (0, 0, 0);
    }

    private int[] SortandConvertPuzzleInput()
    {

        var sortedArr = new int[this.PuzzleInput.Length];
        for (var i = 0; i < this.PuzzleInput.Length; i++)
        {
            var num = Convert.ToInt32(this.PuzzleInput[i]);
            sortedArr[i] = num;
        }
        return sortedArr;
    }
}