
namespace Bowling.Tournament.Share.Models;

[Flags]
public enum FrameStatusEnum
{
    Normal = 0x00,
    Foul = 0x01,
    Edited = 0x02,
    Split = 0x04,
}
