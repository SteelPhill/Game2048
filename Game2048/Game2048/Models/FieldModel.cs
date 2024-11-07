using Game2048.Entities;
using System.Collections.ObjectModel;

namespace Game2048.Models;

public class FieldModel
{
    public ObservableCollection<ObservableCollection<Cell>> Field { get; set; }

    public FieldModel()
    {
        Initialize();
    }

    private void Initialize()
    {
        Field = new ObservableCollection<ObservableCollection<Cell>>();

        for (var i = 0; i < Constants.FieldSize; i++)
        {
            var row = new ObservableCollection<Cell>();

            for (var j = 0; j < Constants.FieldSize; j++)
                row.Add(new Cell(new Coordinates(i, j)));

            Field.Add(row);
        }
    }
}