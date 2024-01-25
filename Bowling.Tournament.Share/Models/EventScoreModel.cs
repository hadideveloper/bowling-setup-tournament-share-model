
namespace Bowling.Tournament.Share.Models;

/// <summary>
/// Event score model
/// </summary>
public class EventScoreModel
{
    /// <summary>
    /// Event Id, this is the ID that the scoring system received once the event is started.
    /// <see cref="EventSetupModel.Id"/>
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// List of Bowlers' scores
    /// </summary>
    public List<BowlerScoreModel>? Bowlers { get; set; }
}
