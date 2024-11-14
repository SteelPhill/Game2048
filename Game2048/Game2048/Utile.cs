using Game2048.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Game2048;

public static class Utile
{
    public static readonly Dictionary<CellValue, (Brush Background, Brush Foreground)> StateValueColor = new()
    {
         { CellValue.Empty, (Brushes.LightGray, Brushes.LightGray) },
         { CellValue.Two, (Brushes.White, Brushes.Gray) },
         { CellValue.Four, (Brushes.Cornsilk, Brushes.Gray) },
         { CellValue.Eight, (Brushes.SandyBrown, Brushes.White) },
         { CellValue.Sixteen, (Brushes.Coral, Brushes.White) },
         { CellValue.ThirtyTwo, (Brushes.Tomato, Brushes.White) },
         { CellValue.SixtyFour, (Brushes.OrangeRed, Brushes.White) },
         { CellValue.OneHundredTwentyEight, (new SolidColorBrush(Color.FromRgb(255,200,80)), Brushes.White) },
         { CellValue.TwoHundredFiftySix, (new SolidColorBrush(Color.FromRgb(255,200,60)), Brushes.White) },
         { CellValue.FiveHundredTwelve, (new SolidColorBrush(Color.FromRgb(255,200,40)), Brushes.White) },
         { CellValue.OneThousandTwentyFour, (new SolidColorBrush(Color.FromRgb(255,200,20)), Brushes.White) },
         { CellValue.TwoThousandFortyEight, (new SolidColorBrush(Color.FromRgb(255,200,0)), Brushes.White) }
    };

    public static readonly Random Random = new();
}