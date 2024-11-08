using Game2048.Entities;
using System.Collections.Generic;
using System.Windows.Media;

namespace Game2048;

public static class Utile
{
    public static readonly Dictionary<CellValues, Brush> stateValueColor = new()
    {
         { CellValues.None, Brushes.Gray },
         { CellValues.Two, Brushes.White },
         { CellValues.Four, Brushes.White },
         { CellValues.Eight, Brushes.Orange },
         { CellValues.SixtyFour, Brushes.OrangeRed },
         { CellValues.ThirtyTwo, Brushes.Red },
         { CellValues.SixtyFour, Brushes.Yellow },
         { CellValues.OneHundredTwentyEight, Brushes.Yellow },
         { CellValues.TwoHundredFiftySix, Brushes.Yellow },
         { CellValues.FiveHundredTwelve, Brushes.Yellow },
         { CellValues.OneThousandTwentyFour, Brushes.Yellow },
         { CellValues.TwoThousandFortyEight, Brushes.Yellow },
    };
}