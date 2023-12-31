using System;
using System.Collections.Generic;

class Batsman
{
    public string? Name { get; set; }
    public int RunsScored { get; set; }
    public double StrikeRate { get; set; }

    public double BattingMomentum => RunsScored * StrikeRate;
}

class Program
{
    static void Main()
    {
        List<Batsman> Player = new List<Batsman>
        {
            new Batsman { Name = "Virat Kohli", RunsScored = 50, StrikeRate = 78.30 },
            new Batsman { Name = "M.S. Dhoni", RunsScored = 61, StrikeRate = 58.90 },
            new Batsman { Name = "Rohit Sharma", RunsScored = 13, StrikeRate = 124.0 }
        };

        Batsman batsman = GetBestBatsman(Player);

        Console.WriteLine($"Batsman with the best batting momentum: {batsman.Name}");
    }

    static Batsman GetBestBatsman(List<Batsman> batsmen)
    {
        if (batsmen.Count == 0)
        {
            throw new ArgumentException("List of batsmen is empty");
        }

        Batsman bestBatsman = batsmen[0];

        foreach (var b in batsmen)
        {
            if (b.BattingMomentum > bestBatsman.BattingMomentum)
            {
                bestBatsman = b;
            }
        }

        return bestBatsman;
    }
}