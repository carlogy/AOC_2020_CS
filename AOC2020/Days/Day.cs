namespace AOC2020.Days;

public abstract class Day(string[] puzzleInput) : IPuzzleDay
{
        private readonly string[]  _PuzzleInput = puzzleInput;
        public string[] PuzzleInput { get { return _PuzzleInput; }}
        private DailySolutions Solutions { get; set; } = new DailySolutions();
        public abstract (string Part1, string Part2) Solve();
        
    protected void AddSolution(int part, string solution)
    {
        if (part < 1 || part > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(part));
        }

        switch (part)
        {
            case 1: this.Solutions.Part1 = solution; break;
            case 2: this.Solutions.Part2 = solution; break;
        }
    }

    public (string Part1, string Part2) GetSolutions()
    {

        if (Solutions == null)
        {
            throw new InvalidOperationException("Solutions not set");
        }
        var part1 = Solutions.Part1 ?? "";
        var part2 = Solutions.Part2 ?? "";
        return (Part1: part1, Part2: part2);
    }

   
}

   

