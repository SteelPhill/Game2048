using Game2048.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Game2048;

public static class Utile
{
    public static readonly Dictionary<CellValues, Color> stateValueColor = new()
    {
         { CellValues.None, Colors.Gray },
         { CellValues.Two, Colors.White },
         { CellValues.Four, Colors.White },
         { CellValues.Eight, Colors.Orange },
         { CellValues.SixtyFour, Colors.OrangeRed },
         { CellValues.ThirtyTwo, Colors.Red },
         { CellValues.SixtyFour, Colors.Yellow },
         { CellValues.OneHundredTwentyEight, Colors.Yellow },
         { CellValues.TwoHundredFiftySix, Colors.Yellow },
         { CellValues.FiveHundredTwelve, Colors.Yellow },
         { CellValues.OneThousandTwentyFour, Colors.Yellow },
         { CellValues.TwoThousandFortyEight, Colors.Yellow },
    };
}