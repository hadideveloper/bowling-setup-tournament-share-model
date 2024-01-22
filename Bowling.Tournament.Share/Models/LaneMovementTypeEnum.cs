using System.ComponentModel.DataAnnotations;

namespace Bowling.Tournament.Share.Models;

public enum LaneMovementTypeEnum
{
    [Display(Name = "Same Lane")]
    SameLane,                   // Bowlers stay on the same lane even if it's a cross lane game

    [Display(Name = "Move Pairs To The Right And Swap")]
    MovePairsToTheRightAndSwap, // Pair of Lanes move to the right , for example Lane 3 & 4 will move to 5 & 6 and swap, so Lane 3 => 6 and Lane 4 => 5

    [Display(Name = "Move Pairs To The Left And Swap")]
    MovePairsToTheLeftAndSwap,  // Pair of Lanes move to the left , for example Lane 3 & 4 will move to 1 & 2 and swap, so Lane 3 => 2 and Lane 4 => 1

    [Display(Name = "Move Pairs To The Right")]
    MovePairsToTheRight,        // Pair of Lanes move to the right , for example Lane 3 & 4 will move to 5 & 6 but they don't swap, so Lane 3 => 5 and Lane 4 => 6

    [Display(Name = "Move Pairs To The Left")]
    MovePairsToTheLeft,         // Pair of Lanes move to the left , for example Lane 3 & 4 will move to 1 & 2 but they don't swap, so Lane 3 => 1 and Lane 4 => 2

    [Display(Name = "Swap Pairs")]
    SwapPairs,                  // Pair of Lanes swap, for example Lane 3 & 4 will swap, so Lane 3 => 4 and Lane 4 => 3

    [Display(Name = "Even To Right Odd To Left")]
    EvenToRightOddToLeft,       // Even Lanes move to the right and Odd Lanes move to the left, for example Lane 4 => 5 and Lane 5 => 4

    [Display(Name = "Single Lane Right")]
    SingleLaneRight,            // Single Lane move to the right, for example Lane 3 => 4

    [Display(Name = "Single Lane Left")]
    SingleLaneLeft,             // Single Lane move to the left, for example Lane 3 => 2
}
