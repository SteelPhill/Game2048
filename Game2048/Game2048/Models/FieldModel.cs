using Game2048.Entities;
using System.Collections.ObjectModel;

namespace Game2048.Models;

public class FieldModel
{
    public ObservableCollection<ObservableCollection<CellModel>> Field { get; }

    public FieldModel()
    {
        Field = [];

        for (var i = 0; i < Constants.FieldRowsNumber; i++)
        {
            var row = new ObservableCollection<CellModel>();

            for (var j = 0; j < Constants.FieldRowsNumber; j++)
                row.Add(new CellModel(CellValue.Empty));

            Field.Add(row);
        }
    }

    public void Clear()
    {
        foreach (var row in Field)
            foreach (var cell in row)
                cell.Value = CellValue.Empty;
    }
}