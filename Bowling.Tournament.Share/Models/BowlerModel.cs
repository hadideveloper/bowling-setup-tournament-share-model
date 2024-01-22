namespace Bowling.Tournament.Share.Models;

/// <summary>
/// Bowler model
/// </summary>
public class BowlerModel
{
    /// <summary>
    /// Scoring system will return all scores or other information with this ID
    /// So, this ID helps the API to identify the bowler
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// If the bowler is part of a team, this is the team Id
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Bowler name to display on the scoring monitor
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Bowler member number to display on the scoring monitor
    /// </summary>
    public string? BowlerNumber { get; set; }

    /// <summary>
    /// Optional Bowler average to display on scoring monitor 
    /// Scoring will not change it, it is just for display
    /// </summary>
    public int? Average { get; set; }

    /// <summary>
    /// Optional Bowler book average to display on scoring monitor
    /// Scoring will not change it, it is just for display
    /// </summary>
    public int? BookAverage { get; set; }

    /// <summary>
    /// Actual Handicap of the bowler
    /// Scoring shows and uses this value to calculate the total score
    /// </summary>
    public int Handicap { get; set; }

    /// <summary>
    /// Optional bowler performance based on their history
    /// </summary>
    public BowlerPerformanceModel? Performance { get; set; }
}
