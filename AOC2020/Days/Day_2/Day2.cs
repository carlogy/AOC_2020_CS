namespace AOC2020.Days;

public class Day2(string[] puzzleInput) : Day(puzzleInput)
{
    public override (string Part1, string Part2) Solve()
    {
        var passwordsValidated = Convert.ToString(ValidatePasswordList(1));
        this.AddSolution(1, passwordsValidated);
        passwordsValidated = Convert.ToString(ValidatePasswordList(2));
        this.AddSolution(2, passwordsValidated);
        return GetSolutions();
    }
    private int ValidatePasswordList(int part)
    {
        int total = 0;
        foreach (var line in this.PuzzleInput)
        {
            var items = this.GetPolicyAndPassword(line);
            var passwordCheckPassed = ValidatePassword(items.Min, items.Max, items.Letter, items.Password, part);
            if (passwordCheckPassed) { total++; }
        }
        return total;
    }

    private (int Min, int Max, string Letter, string Password) GetPolicyAndPassword(string line) {

        int min = 0;
        int max = 0;
        string letter = "";
        string password = "";
        var temp = 0;

        for (var i = 0; i < line.Length; i++)
        {
            if (line[i] == '-')
            {
                min = Convert.ToInt32(line.Substring(0, i));
                temp = i;
                continue;
            }
            if (char.IsWhiteSpace(line[i]) && max == 0)
            {
                letter = line[i + 1].ToString();
                max = Convert.ToInt32(line.Substring(temp + 1, i - temp));
                password = line.Substring(i + 4);
                break;
            }
        }
        return (min, max, letter, password);
    }
    private (int Min, int Max, string Letter, string Password) OriginalGetPolicyAndPassword(string line)
    {

        var items = SplitIntoPolicyAndPassword(line);
        var password = items.Password;
        var policies = items.Policy.Split(" ");
        var letter = policies[1];
        var (min, max) = GetCounts(policies[0]);
        return (min, max, letter, password);
    }

    private (string Policy, string Password) SplitIntoPolicyAndPassword(string line)
    {
        var items = line.Split(":");
        return (items[0], items[1].Trim());
    }

    private (int Min, int Max) GetCounts(string policy)
    {
        var counts = policy.Trim().Split("-");
        var min = Convert.ToInt32(counts[0]);
        var max = Convert.ToInt32(counts[1]);
        return (min, max);
    }
    private static bool ValidatePassword(int min, int max, string letter, string password, int part)
    {
        switch (part) {
            case 1:
                int count = 0;
                for (var i = 0; i < password.Length; i++)
                {
                    if (Convert.ToString(password[i]) == letter)
                    {
                        count++;
                    }
                }
                return count >= min && count <= max;
                
            case 2:
                count = 0;
                if (letter == password[min-1].ToString()) { count++; }
                if (letter == password[max-1].ToString()) { count++; }
                return count == 1;
            default:
                throw new NotImplementedException("There are only two puzzle parts to solve.");
        }
    }
}
