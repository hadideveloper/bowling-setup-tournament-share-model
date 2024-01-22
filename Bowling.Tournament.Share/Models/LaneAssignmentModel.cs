namespace Bowling.Tournament.Share.Models;

/// <summary>
/// Lane assignment model
/// </summary>
public class LaneAssignmentModel
{
    /// <summary>
    /// Lane number
    /// </summary>
    public int Lane { get; set; }

    /// <summary>
    /// List of bowlers assigned to this lane, Max 9 bowlers
    /// </summary>
    public List<int> BowlersId { get; set; }
}
