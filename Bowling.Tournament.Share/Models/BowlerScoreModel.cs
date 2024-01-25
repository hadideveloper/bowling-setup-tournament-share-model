
namespace Bowling.Tournament.Share.Models;

/// <summary>
/// Score model for a bowler
/// </summary>
public class BowlerScoreModel
{
    /// <summary>
    /// Bowler Id
    /// <see cref="BowlerModel.Id"/>
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Bowler status
    /// </summary>
    public BowlerStatus Status { get; set; }

    ///<summary>
    /// True means bowler name is changed during the event
    ///</summary>
    public bool IsNameChanged { get; set; }

    /// <summary>
    /// Bowler name (in case bowler chanes name during the event this name can be different from the initial name)
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Team Id that this belongs to
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// True means this bowler finished the their games
    /// </summary>
    public bool IsComplete { get; set; }

    /// <summary>
    /// List of games
    /// </summary>
    public List<GameScoreModel>? Games { get; set; }
}
