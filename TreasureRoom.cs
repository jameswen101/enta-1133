using System;

public class TreasureRoom: Room
{
    int row, col;
    public TreasureRoom(int row, int col): base(row, col)
	{
        this.row = row;
        this.col = col;
        this.name = $"room{row}-{col}";
    }
}
