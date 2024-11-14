using Game2048.Entities;
using GalaSoft.MvvmLight;

namespace Game2048.Models;

public class CellModel : ObservableObject
{
    private CellValue _value;

    public CellValue Value
    {
        get => _value;
        set => Set(ref _value, value);
    }

    public CellModel(CellValue value)
    {
        Value = value;
    }

    public bool IsEmpty()
    {
        return Value == CellValue.Empty;
    }
}