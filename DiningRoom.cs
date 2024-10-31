using System;

public class DiningRoom : Room
{
    int row, col;
    public DiningRoom(int row, int col) : base(row, col)
    {
        this.row = row;
        this.col = col;
        this.name = $"room{row}-{col}";
    }
}
