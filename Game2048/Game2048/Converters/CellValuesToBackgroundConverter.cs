﻿using Game2048.Entities;
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
                return Utile.StateValueBackgroundColor[CellValues.Empty];
            case CellValues.Two:
                return Utile.StateValueBackgroundColor[CellValues.Two];
            case CellValues.Four:
                return Utile.StateValueBackgroundColor[CellValues.Four];
            case CellValues.Eight:
                return Utile.StateValueBackgroundColor[CellValues.Eight];
            case CellValues.Sixteen:
                return Utile.StateValueBackgroundColor[CellValues.Sixteen];
            case CellValues.ThirtyTwo:
                return Utile.StateValueBackgroundColor[CellValues.ThirtyTwo];
            case CellValues.SixtyFour:
                return Utile.StateValueBackgroundColor[CellValues.SixtyFour];
            case CellValues.OneHundredTwentyEight:
                return Utile.StateValueBackgroundColor[CellValues.OneHundredTwentyEight];
            case CellValues.TwoHundredFiftySix:
                return Utile.StateValueBackgroundColor[CellValues.TwoHundredFiftySix];
            case CellValues.FiveHundredTwelve:
                return Utile.StateValueBackgroundColor[CellValues.FiveHundredTwelve];
            case CellValues.OneThousandTwentyFour:
                return Utile.StateValueBackgroundColor[CellValues.OneThousandTwentyFour]; 
            case CellValues.TwoThousandFortyEight:
                return Utile.StateValueBackgroundColor[CellValues.TwoThousandFortyEight];
            default:
                return default;
        }
    }

    protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}