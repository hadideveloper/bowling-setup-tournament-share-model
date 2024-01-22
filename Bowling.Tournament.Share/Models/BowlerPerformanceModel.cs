namespace Bowling.Tournament.Share.Models;

/// <summary>
/// Bowler performance model based on their history
/// </summary>
public class BowlerPerformanceModel
{
    public int? HighScore { get; set; }
    public int? FirstBallStrikePercentage { get; set; }
    public int? FirstBallLeavesPercentage { get; set; }
    public int? FirstBallSplitPercentage { get; set; }
    public int? NumberOfGames { get; set; }
    public List<FirstBallPinLeavesModel>? FirstBallPinLeaves { get; set; }
}
