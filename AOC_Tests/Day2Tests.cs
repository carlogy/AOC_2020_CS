using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AOC2020.Days;
using AOC2020;

namespace AOC_Tests;

    public class Day2
    {
        internal string[] SampleInput { get; set; } = ["1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc"];

        [Fact]
        public  void Part1SampleTest() {
            var day = PuzzleOrchestrator.CreatePuzzleDay(2, SampleInput);
            var expected = "2";
            var results = day.Solve();
            Assert.Equal(expected, results.Part1);
        }

        [Fact]
    public void Part2SampleTest()
    {
        var day = PuzzleOrchestrator.CreatePuzzleDay(2, SampleInput);
        var expected = "1";
        var results = day.Solve();
        Console.WriteLine(results);
        Assert.Equal(expected, results.Part2);
    }
    }

