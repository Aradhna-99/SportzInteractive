using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        CT team = new CT
        {
            Name_Full = "Sunrisers Hyderabad",
            Name_Short = "SRH",
            Players = new Team
            {
                { "5380", new Player { Position = "1", Name_Full = "David Warner", IsCaptain = true } },
                { "3722", new Player { Position = "2", Name_Full = "Shikhar Dhawan", IsCaptain = false } }
            }
        };

        string jsonResult = JsonConvert.SerializeObject(team, Formatting.Indented);
        Console.WriteLine(jsonResult);
    }
}

class CT
{
    public string? Name_Full { get; set; }
    public string? Name_Short { get; set; }
    public Team Players { get; set; } = new Team();
}

class Team : System.Collections.Generic.Dictionary<string, Player> { }

class Player
{
    public string? Position { get; set; }
    public string? Name_Full { get; set; }
    public bool IsCaptain { get; set; }
}