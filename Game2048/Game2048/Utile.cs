using Game2048.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Game2048;

public static class Utile
{
    public static readonly Dictionary<CellValues, (Brush Background, Brush Foreground)> StateValueColor = new()
    {
         { CellValues.Empty, (Brushes.LightGray, Brushes.LightGray) },
         { CellValues.Two, (Brushes.White, Brushes.Black) },
         { CellValues.Four, (Brushes.Cornsilk, Brushes.Black) },
         { CellValues.Eight, (Brushes.Orange, Brushes.White) },
         { CellValues.Sixteen, (Brushes.Coral, Brushes.White) },
         { CellValues.ThirtyTwo, (Brushes.Tomato, Brushes.White) },
         { CellValues.SixtyFour, (Brushes.Red, Brushes.White) },
         { CellValues.OneHundredTwentyEight, (new SolidColorBrush(Color.FromRgb(230,230,80)), Brushes.White) },
         { CellValues.TwoHundredFiftySix, (new SolidColorBrush(Color.FromRgb(230,230,60)), Brushes.White) },
         { CellValues.FiveHundredTwelve, (new SolidColorBrush(Color.FromRgb(230,230,40)), Brushes.White) },
         { CellValues.OneThousandTwentyFour, (new SolidColorBrush(Color.FromRgb(230,230,20)), Brushes.White) },
         { CellValues.TwoThousandFortyEight, (new SolidColorBrush(Color.FromRgb(230,230,0)), Brushes.White) }
    };

    public static readonly Random Random = new();
}