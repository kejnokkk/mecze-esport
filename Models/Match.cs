namespace site_blazor.Models;

public class Match
{
    public string GameImage { get; set; } = "";
    public string GameName { get; set; } = "";
    public string Tournament { get; set; } = "";
    public MatchStatus Status { get; set; }
    public Team Team1 { get; set; } = new();
    public Team Team2 { get; set; } = new();
    public string? Score { get; set; }
    public string Date { get; set; } = "";
    public string Time { get; set; } = "";
    public string ButtonLabel { get; set; } = "Szczegóły";
}

public class Team
{
    public string Logo { get; set; } = "";
    public string Name { get; set; } = "";
    public string Tag { get; set; } = "";
}

public enum MatchStatus { Live, Upcoming, Finished }