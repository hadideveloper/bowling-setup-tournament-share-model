
namespace Bowling.Tournament.Share.Models;

/// <summary>
/// The game model
/// </summary>
public class GameScoreModel
{
    /// <summary>
    /// Game number starting from 1
    /// </summary>
    public int GameNumber { get; set; }

    /// <summary>
    /// The lane number that this game is played on. 
    /// If <see cref="EventSetupModel.LaneMovementType"/> is enabled, this lane number can be different for each game.
    /// </summary>
    public int LaneNumber { get; set; }

    /// <summary>
    /// Totcal score for this game without handicap
    /// </summary>
    public int ScratchScore { get; set; }

    /// <summary>
    /// The handicap value
    /// <see cref="BowlerModel.Handicap"/>
    /// </summary>
    public int Handicap { get; set; }

    /// <summary>
    /// Total score for this game plus handicap
    /// </summary>
    public int HadicapTotal { get; set; }

    /// <summary>
    /// True means this game is complete
    /// </summary>
    public bool IsComplete { get; set; }

    /// <summary>
    /// List of frames
    /// <see cref="EventSetupModel.NumberOfFrames"/>
    /// </summary>
    public List<FrameScoreModel>? Frames { get; set; }
}
