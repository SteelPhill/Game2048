using Game2048.Entities;
using MahApps.Metro.Converters;
using System;
using System.Globalization;

namespace Game2048.Converters;

public class CellValuesToIntConverter : MarkupConverter
{
    protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not CellValues v)
            return default;

        switch (v)
        {
            case CellValues.Two:
                return 2;
            case CellValues.Four:
                return 4;
            case CellValues.Eight:
                return 8;
            case CellValues.Sixteen:
                return 16;
            case CellValues.ThirtyTwo:
                return 32;
            case CellValues.SixtyFour:
                return 64;
            case CellValues.OneHundredTwentyEight:
                return 128;
            case CellValues.TwoHundredFiftySix:
                return 256;
            case CellValues.FiveHundredTwelve:
                return 512;
            case CellValues.OneThousandTwentyFour:
                return 1024;
            case CellValues.TwoThousandFortyEight:
                return 2048;
            default:
                return default;
        }
    }

    protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}