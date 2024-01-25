namespace Bowling.Tournament.Share.Models;

[Flags]
public enum EventBowlerOptions
{
    CanEditScores = 0x0001,
    CanEditNames = 0x0002,
    CanEditTeamsName = 0x0004,
    CanEditHandicap = 0x0008,
    CanChangeBowlerPosition = 0x0010,
    CanAddBowler = 0x0020,
    CanRemoveBowler = 0x0040,
    CanBlindBowler = 0x0080,
}
