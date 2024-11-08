using Game2048.Entities;
using GalaSoft.MvvmLight;
using System;

namespace Game2048.Models;

public class CellModel : ObservableObject, ICloneable
{
    private CellValues _value;

    public CellValues Value
    {
        get => _value;
        set => Set(ref _value, value);
    }

    public bool IsNone()
    {
        return Value == CellValues.None;
    }

    public object Clone()
    {
        var clone = (CellModel)MemberwiseClone();
        return clone;
    }
}