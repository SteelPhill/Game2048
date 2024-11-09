using Game2048.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Game2048;

public static class Utile
{
    public static readonly Dictionary<CellValues, Brush> StateValueBackgroundColor = new()
    {
         { CellValues.Empty, Brushes.LightGray },
         { CellValues.Two, Brushes.White },
         { CellValues.Four, Brushes.White },
         { CellValues.Eight, Brushes.Orange },
         { CellValues.Sixteen, Brushes.OrangeRed },
         { CellValues.ThirtyTwo, Brushes.Red },
         { CellValues.SixtyFour, Brushes.Yellow },
         { CellValues.OneHundredTwentyEight, Brushes.SkyBlue },
         { CellValues.TwoHundredFiftySix, Brushes.DeepSkyBlue },
         { CellValues.FiveHundredTwelve, Brushes.Blue },
         { CellValues.OneThousandTwentyFour, Brushes.BlueViolet },
         { CellValues.TwoThousandFortyEight, Brushes.Green },
    };

    public static readonly Dictionary<CellValues, Brush> StateValueForegroundColor = new()
    {
         { CellValues.Empty, Brushes.Black },
         { CellValues.Two, Brushes.Black },
         { CellValues.Four, Brushes.Black },
         { CellValues.Eight, Brushes.White },
         { CellValues.Sixteen, Brushes.White },
         { CellValues.ThirtyTwo, Brushes.White },
         { CellValues.SixtyFour, Brushes.Black },
         { CellValues.OneHundredTwentyEight, Brushes.Black },
         { CellValues.TwoHundredFiftySix, Brushes.White },
         { CellValues.FiveHundredTwelve, Brushes.White },
         { CellValues.OneThousandTwentyFour, Brushes.White },
         { CellValues.TwoThousandFortyEight, Brushes.White },
    };

    public static readonly Random Random = new();
}