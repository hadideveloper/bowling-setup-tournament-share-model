namespace Bowling.Tournament.Share.Models;

/// <summary>
/// Team model
/// </summary>
public class TeamModel
{
    /// <summary>
    /// Should be unique in the tournament
    /// If this is a team tournament, this Id will be used to add bowlers to this team
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Team name to display on the scoring monitor
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Team member number to display on the scoring monitor
    /// </summary>
    public string? TeamNumber { get; set; }

    /// <summary>
    /// Team Average to display on scoring monitor
    /// </summary>
    public int? Average { get; set; }

    /// <summary>
    /// Team book average to display on scoring monitor
    /// </summary>
    public int? BookAverage { get; set; }
}
