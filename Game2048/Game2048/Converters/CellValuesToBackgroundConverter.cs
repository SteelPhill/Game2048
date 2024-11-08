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

        switch (v)
        {
            case CellValues.Empty:
                return Utile.StateValueColor[CellValues.Empty];
            case CellValues.Two:
                return Utile.StateValueColor[CellValues.Two];
            case CellValues.Four:
                return Utile.StateValueColor[CellValues.Four];
            case CellValues.Eight:
                return Utile.StateValueColor[CellValues.Eight];
            case CellValues.Sixteen:
                return Utile.StateValueColor[CellValues.Sixteen];
            case CellValues.ThirtyTwo:
                return Utile.StateValueColor[CellValues.ThirtyTwo];
            case CellValues.SixtyFour:
                return Utile.StateValueColor[CellValues.SixtyFour];
            case CellValues.OneHundredTwentyEight:
                return Utile.StateValueColor[CellValues.OneHundredTwentyEight];
            case CellValues.TwoHundredFiftySix:
                return Utile.StateValueColor[CellValues.TwoHundredFiftySix];
            case CellValues.FiveHundredTwelve:
                return Utile.StateValueColor[CellValues.FiveHundredTwelve];
            case CellValues.OneThousandTwentyFour:
                return Utile.StateValueColor[CellValues.OneThousandTwentyFour]; 
            case CellValues.TwoThousandFortyEight:
                return Utile.StateValueColor[CellValues.TwoThousandFortyEight];
            default:
                return default;
        }
    }

    protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}