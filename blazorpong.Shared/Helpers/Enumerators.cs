//From https://github.com/exceptionnotfound/BattleshipModellingPractice
using System.ComponentModel;

namespace blazorpong.Shared.Helpers
{
    public enum OccupationType
    {
        [Description(" ")]
        Empty,
        [Description("P")]
        Paddle,
        [Description("B")]
        Ball
    }


}