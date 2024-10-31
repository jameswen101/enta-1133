using System;

public class CombatRoom: Room
{
    public int row, col;
    public bool eagleInRoom, alliInRoom, wolfInRoom, bearInRoom = false;

    public CombatRoom(int row, int col): base(row, col)
	{
        this.row = row;
        this.col = col;
        this.name = $"room{row}-{col}";
    }
}
