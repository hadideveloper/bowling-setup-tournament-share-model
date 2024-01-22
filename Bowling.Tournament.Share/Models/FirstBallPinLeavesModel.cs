namespace Bowling.Tournament.Share.Models;

/// <summary>
/// First ball pin leaves model
/// </summary>
public class FirstBallPinLeavesModel
{
    /// <summary>
    /// MSB is pin 10, LSB is pin 1
    /// 1 means pin is standing, 0 means pin is down
    /// 
    ///       Pin 10
    ///        ⭣
    /// 0000 0000 0000 0000
    ///                   ⭡
    ///                  Pin 1
    /// </summary>
    public ushort Pins { get; set; } // ** IF YOU HATE BINARY, we can change it to array of boolean or String or 1 and 0 **

    /// <summary>
    /// Number of times this specific pin leaves happened on the first ball
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Percentage of bowler could knock down this pin
    /// </summary>
    public int Percentage { get; set; }
}
