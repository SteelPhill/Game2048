using Game2048.Entities;
using MahApps.Metro.Converters;
using System.Globalization;
using System;

namespace Game2048.Converters;

public class CellValuesToForegroundConverter : MarkupConverter
{
    protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not CellValues v)
            return default;

        switch (v)
        {
            case CellValues.Empty:
                return Utile.StateValueForegroundColor[CellValues.Empty];
            case CellValues.Two:
                return Utile.StateValueForegroundColor[CellValues.Two];
            case CellValues.Four:
                return Utile.StateValueForegroundColor[CellValues.Four];
            case CellValues.Eight:
                return Utile.StateValueForegroundColor[CellValues.Eight];
            case CellValues.Sixteen:
                return Utile.StateValueForegroundColor[CellValues.Sixteen];
            case CellValues.ThirtyTwo:
                return Utile.StateValueForegroundColor[CellValues.ThirtyTwo];
            case CellValues.SixtyFour:
                return Utile.StateValueForegroundColor[CellValues.SixtyFour];
            case CellValues.OneHundredTwentyEight:
                return Utile.StateValueForegroundColor[CellValues.OneHundredTwentyEight];
            case CellValues.TwoHundredFiftySix:
                return Utile.StateValueForegroundColor[CellValues.TwoHundredFiftySix];
            case CellValues.FiveHundredTwelve:
                return Utile.StateValueForegroundColor[CellValues.FiveHundredTwelve];
            case CellValues.OneThousandTwentyFour:
                return Utile.StateValueForegroundColor[CellValues.OneThousandTwentyFour];
            case CellValues.TwoThousandFortyEight:
                return Utile.StateValueForegroundColor[CellValues.TwoThousandFortyEight];
            default:
                return default;
        }
    }

    protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}