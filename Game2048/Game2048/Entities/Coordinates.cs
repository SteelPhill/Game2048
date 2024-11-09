namespace Game2048.Entities;

public class Coordinates
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Coordinates() : this(0, 0) { }

    public Coordinates(int row, int column)
    {
        Row = row;
        Column = column;
    }
}