namespace Bowling.Tournament.Share.Models;

/// <summary>
/// This is the model that Tournament app will send to scoring system to start an event.
/// </summary>
public class EventSetupModel
{
    /// <summary>
    /// The Unique Id of this event. 
    /// Scoring software will return this Id to the API to identify the tournament.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Optional event id to display in the scoring system
    /// </summary>
    public int? EventId { get; set; }

    /// <summary>
    /// Optional name of the tournament
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Optional tournament register number
    /// </summary>
    public string? TournamentNumber { get; set; }

    /// <summary>
    /// Optional Squad Number
    /// </summary>
    public int? SquadNumber { get; set; }

    /// <summary>
    /// Start lane and end lane that the tournament will be played on.
    /// If StartLane or EndLane is null, Front desk will ask the secratary to select the lanes, and actual lanes will be returned in the response.
    /// </summary>
    public int? StartLane { get; set; }
    public int? EndLane { get; set; }

    /// <summary>
    /// Number of games for every match
    /// </summary>
    public int NumberOfGames { get; set; } = 3;

    /// <summary>
    /// Scoring system supports 3, 5, 7 and 10 frames per game.
    /// </summary>
    public int? NumberOfFrames { get; set; } = 10;

    /// <summary>
    /// Cross Lane or Dual Lane Mode
    /// </summary>
    public bool IsCrossLane { get; set; }

    /// <summary>
    /// Lane Movement Type
    /// </summary>
    public LaneMovementTypeEnum LaneMovementType { get; set; }

    /// <summary>
    /// Number of games bowlers should play before moving 
    /// <see cref="LaneMovementTypeEnum"/>
    /// </summary>
    public int NumberOfGamesBeforeMoving { get; set; } = 1;

    /// <summary>
    /// Number of lanes to move.
    /// <see cref="LaneMovementTypeEnum"/>
    /// </summary>
    public int NumberOfLanesToMove { get; set; } = 1;

    /// <summary>
    /// True means this is a scratch tournament
    /// False means this is a handicap tournament
    /// </summary>
    public bool IsScratch { get; set; }

    /// <summary>
    /// In case of Handicap tournament, this is the tournament base average
    /// Scoring will not change or use this value, it is just for display
    /// </summary>
    public int? BaseAverage { get; set; }

    /// <summary>
    /// In case of Handicap tournament, this is the handicap percentage
    /// Scoring will not change or use this value, it is just for display
    /// </summary>
    public int? HandicapPercentage { get; set; }

    /// <summary>
    /// Teams in the tournament if any
    /// </summary>
    public List<TeamModel>? Teams { get; set; }

    /// <summary>
    /// List of bowlers in the tournament
    /// </summary>
    public List<BowlerModel>? Bowlers { get; set; }

    /// <summary>
    /// List of lane assignments if tournament app handles the lane assignments
    /// Otherwise, scoring system will let the secretary to assign bowlers to lanes
    /// </summary>
    public List<LaneAssignmentModel>? LaneAssignments { get; set; }
}
