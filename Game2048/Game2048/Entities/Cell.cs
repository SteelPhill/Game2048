using System.Collections.ObjectModel;

namespace Game2048.Entities;

public class Cell
{
    public Coordinates Coordinates { get; set; }
    public CellValues Value { get; set; }

    public Cell(Coordinates coordinates)
    {
        Coordinates = coordinates;
        Value = CellValues.None;
    }

    //public void Game()
    //{
    //    ObservableCollection<Cell> board = new ObservableCollection<Cell>()
    //    {
    //        new Cell(new Coordinates(0, 0)),
    //        new Cell(new Coordinates(0, 1)),
    //        new Cell(new Coordinates(0, 2)),
    //        new Cell(new Coordinates(0, 3))
    //    };

    //    Coordinates coor = new Coordinates(0, 2);

    //    foreach (var cell in board)
    //    {
    //        if (cell.Coordinates == coor && cell.Value == CellValues.None)
    //        {
    //            //Записываем значение
    //            break;
    //        }
    //    }
    //}
}