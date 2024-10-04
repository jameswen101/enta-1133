using System;

public class Player
{
    public int roundScore, totalScore = 0;
    public int turnsTaken = 0;
    public int roundsWon = 0;
    public List<DieRoller> Dice = new List<DieRoller>();
    public String name;

    public Player(String name) //constructor
    {
        this.name = name;
    }
}
