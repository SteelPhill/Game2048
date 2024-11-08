using Game2048.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Game2048;

public static class Utile
{
    public static readonly Dictionary<CellValues, Brush> StateValueColor = new()
    {
         { CellValues.Empty, Brushes.LightGray },
         { CellValues.Two, Brushes.White },
         { CellValues.Four, Brushes.White },
         { CellValues.Eight, Brushes.Orange },
         { CellValues.Sixteen, Brushes.OrangeRed },
         { CellValues.ThirtyTwo, Brushes.Red },
         { CellValues.SixtyFour, Brushes.Yellow },
         { CellValues.OneHundredTwentyEight, Brushes.Yellow },
         { CellValues.TwoHundredFiftySix, Brushes.Yellow },
         { CellValues.FiveHundredTwelve, Brushes.Yellow },
         { CellValues.OneThousandTwentyFour, Brushes.Yellow },
         { CellValues.TwoThousandFortyEight, Brushes.Yellow },
    };

    public static readonly Random Random = new();
}