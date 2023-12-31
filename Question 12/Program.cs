using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<P> Lineups = new List<P>
        {
            new P { PlayerId = 21, PlayerName = "Y. Chahal" },
            new P { PlayerId = 22, PlayerName = "Bhuvneshwar Kumar" },
            new P { PlayerId = 23, PlayerName = "Jasprit Bumrah" },
            new P { PlayerId = 24, PlayerName = "Hardik Pandya" },
            new P { PlayerId = 25, PlayerName = "Ravindra Jadeja" },
            new P { PlayerId = 26, PlayerName = "Mohammed Shami" }
        };

        List<BS> BowlingStats = new List<BS>
        {
            new BS { PlayerId = 21, Wickets = 2 },
            new BS { PlayerId = 22, Wickets = 1 },
            new BS { PlayerId = 23, Wickets = 3 },
            new BS { PlayerId = 26, Wickets = 1 }
        };

        //  players and the wickets they have taken.
        foreach (var player in Lineups)
        {
            var stats = BowlingStats.FirstOrDefault(b => b.PlayerId == player.PlayerId);
            int wickets = stats != null ? stats.Wickets : 0;

            Console.WriteLine($"{player.PlayerName}: Wickets - {wickets}");
        }
    }
}

class P
{
    public int PlayerId { get; set; }
    public string? PlayerName { get; set; }
}

class BS
{
    public int PlayerId { get; set; }
    public int Wickets { get; set; }
}