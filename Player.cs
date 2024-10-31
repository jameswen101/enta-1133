using System;

public class Player
{
    public List<DieRoller> Dice = new List<DieRoller>();
    public int health = 0, row = 0, col = 0;
    public String name;

    public Player(String name) //constructor
    {
        this.name = name;
    }
}
