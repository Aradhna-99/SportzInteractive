using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Player> players = new List<Player>
        {
            new Player { PlayerName = "Virat Kohli", IsRetired = 1 },
            new Player { PlayerName = "M.S. Dhoni", IsRetired = 1 },
            new Player { PlayerName = "Hardik Pandya", IsRetired = 1 },
            new Player { PlayerName = "Rohit Sharma", IsRetired = 1 },
            new Player { PlayerName = "Sachin Tendulkar", IsRetired = 0 },
            new Player { PlayerName = "Rahul Dravid", IsRetired = 0 },
            new Player { PlayerName = "Sourav Ganguly", IsRetired = 0 },
            new Player { PlayerName = "VVS Laxman", IsRetired = 0 }
        };


        players.ForEach(player => player.IsRetired = player.IsRetired == 1 ? 0 : 1);   // Update IsRetired flag inversely using LINQ

        Console.WriteLine("Updated Player List:"); // Display the updated player list
        players.ForEach(player => Console.WriteLine($"{player.PlayerName}: IsRetired = {player.IsRetired}"));
    }
}

class Player
{
    public string? PlayerName { get; set; }
    public int IsRetired { get; set; }
}