namespace Game2048.Entities;

public class Coordinates
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Coordinates(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool operator ==(Coordinates left, Coordinates right)
    {
        return (left is null && right is null) || left?.Equals(right) == true;
    }

    public static bool operator !=(Coordinates left, Coordinates right)
    {
        return (left is not null || right is not null) && left?.Equals(right) != true;
    }

    public override bool Equals(object obj)
    {
        return obj is Coordinates coordinates && 
            Row == coordinates.Row && 
            Column == coordinates.Column;
    }

    public override int GetHashCode()
    {
        return (Row * 397) ^ Column;
    }
}