using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

using System.Text;

namespace AOC2020.Days.Day_1;

    internal class Day1(string[] puzzleInput) : Day(puzzleInput)
    {
        
        public override (string Part1, string Part2) Solve() {
            var solution1 = FixExpenseReport1();
            this.AddSolution(1, Convert.ToString(solution1));
            var solutions = GetSolutions();
            return solutions;
        }

        private int FixExpenseReport1() {

            var complements = GetComplements();
            return complements.Item1 * complements.Item2;
        }

        private Tuple<int, int> GetComplements() {

            var sumsHash = new Dictionary<int, int>();
            int summand1;
            int summand2;

            for (var i = 0; i < this.PuzzleInput.Length; i++)
                {
                    var num = Convert.ToInt32(this.PuzzleInput[i]);
                    var complement = 2020 - num;

                    if (!sumsHash.ContainsKey(complement))
                    {
                        sumsHash.Add(num, i);
                        continue;
                    }

                    summand1 = num;
                    summand2 = complement;
                    return Tuple.Create(summand1, summand2);
            }

            return Tuple.Create(0, 0);
        } 
    }

