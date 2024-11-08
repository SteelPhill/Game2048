using Game2048.Entities;
using MahApps.Metro.Converters;
using System;
using System.Globalization;

namespace Game2048.Converters;

public class CellValuesToBackgroundConverter : MarkupConverter
{
    protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not CellValues v)
            return default;

        var x = Utile.stateValueColor.TryGetValue(CellValues.None, out var c);
        switch (v)
        {
            case CellValues.None:
                return Utile.stateValueColor[CellValues.None];
            case CellValues.Two:
                return Utile.stateValueColor[CellValues.Two];
            case CellValues.Four:
                return Utile.stateValueColor[CellValues.Four];
            case CellValues.Eight:
                return Utile.stateValueColor[CellValues.Eight];
            case CellValues.Sixteen:
                return Utile.stateValueColor[CellValues.Sixteen];
            case CellValues.ThirtyTwo:
                return Utile.stateValueColor[CellValues.ThirtyTwo];
            case CellValues.SixtyFour:
                return Utile.stateValueColor[CellValues.SixtyFour];
            case CellValues.OneHundredTwentyEight:
                return Utile.stateValueColor[CellValues.OneHundredTwentyEight];
            case CellValues.TwoHundredFiftySix:
                return Utile.stateValueColor[CellValues.TwoHundredFiftySix];
            case CellValues.FiveHundredTwelve:
                return Utile.stateValueColor[CellValues.FiveHundredTwelve];
            case CellValues.OneThousandTwentyFour:
                return Utile.stateValueColor[CellValues.OneThousandTwentyFour]; 
            case CellValues.TwoThousandFortyEight:
                return Utile.stateValueColor[CellValues.TwoThousandFortyEight];
            default:
                return default;
        }
    }

    protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}