
namespace Bowling.Tournament.Share.Models;

public class FrameScoreModel
{
    /// <summary>
    /// Array of Standing Pins in Binary Format
    ///     <para>
    ///         MSB is pin 10, LSB is pin 1
    ///         1 means pin is standing, 0 means pin is down
    /// 
    ///               Pin 10
    ///                ⭣
    ///         0000 0000 0000 0000
    ///                           ⭡
    ///                          Pin 1
    ///     </para>
    ///     <para>
    ///         Length can be vary from 0 to 3
    ///     </para>
    ///     <para>
    ///         Index 0 is for the first ball
    ///         Index 1 is for the second ball
    ///         Index 2 is for the third ball (In last frame or duckpin games)
    ///     </para>
    /// </summary>
    public ushort[]? StandingPins { get; set; }

    /// <summary>
    /// Array of each roll score
    /// <para>
    ///     For example if the frame is [2 | 5], RollScores will be [2,5]
    ///     And if the frame is [8 | -], RollScores will be [8,0]
    ///     And if the frame is [X |  ], RollScores will be [10]
    /// </para>
    /// </summary>
    public int[]? RollScores { get; set; }

    /// <summary>
    /// Array of exact view on the scoring
    /// <para>
    ///     X is for Strike
    ///     / is for Spare
    ///     F is for Foul
    ///     - is for Miss
    ///     1~9 is for the number of standing pins
    ///     For example [X, 5, /] is a frame with 10 pins in first roll, 5 pins in second roll and 5 pins in third roll
    ///     And [-,/] is a frame with 0 pins in first roll and 10 pins in second roll
    /// </para>
    /// </summary>
    public string[]? RollView { get; set; }

    /// <summary>
    /// Ball speed in MPH
    /// </summary>
    public int[]? BallSpeed { get; set; }

    /// <summary>
    /// Frame status
    /// </summary>
    public FrameStatusEnum Status { get; set; } 

    /// <summary>
    /// Score of this frame, this is exactly the same as what you see on the score board
    /// </summary>
    public int Score { get; set; }
}
