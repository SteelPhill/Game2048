using System.Collections.ObjectModel;

namespace Game2048.Models;

public class FieldModel
{
    public ObservableCollection<ObservableCollection<CellModel>> Field { get; set; }

    public FieldModel()
    {
        Initialize();
    }

    private void Initialize()
    {
        Field = new ObservableCollection<ObservableCollection<CellModel>>();

        for (var i = 0; i < Constants.FieldSize; i++)
        {
            var row = new ObservableCollection<CellModel>();

            for (var j = 0; j < Constants.FieldSize; j++)
                row.Add(new CellModel());

            Field.Add(row);
        }
    }
}