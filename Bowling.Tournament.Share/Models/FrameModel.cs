
namespace Bowling.Tournament.Share.Models;

[Flags]
public enum FrameStatusEnum
{
    Normal = 0x00,
    Foul = 0x01,
    Edited = 0x02,
    Split = 0x04,
}

public class FrameModel
{
    public ushort[]? StandingPins { get; set; }
    public int[]? RollScores { get; set; }
    public string[]? RollView { get; set; }
    public int[]? BallSpeed { get; set; }
    public FrameStatusEnum Status { get; set; } 
    public int Score { get; set; }
}

public class GameModel
{
    public int GameNumber { get; set; }
    public int LaneNumber { get; set; }
    public int ScratchScore { get; set; }
    public int Handicap { get; set; }
    public int HadicapTotal { get; set; }
    public bool IsComplete { get; set; }
    public List<FrameModel>? Frames { get; set; }
}

public enum BowlerStatus
{
    Normal,
    Forfeit,
    Bye,
}

public class BowlerScoreModel
{
    public int Id { get; set; }
    public BowlerStatus Status { get; set; }
    public string? Name { get; set; }
    public int? TeamId { get; set; }
    public bool IsComplete { get; set; }
    public List<GameModel>? Games { get; set; }
}

public class EventScoreModel
{
    public int Id { get; set; }
    public List<BowlerScoreModel>? Bowlers { get; set; }
}
