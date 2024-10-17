using System;

public class Meat
{
    public String meatName;
    public int row, column;
    public int healthBoost;
    public String description;
    public String asciiArt;
    public Meat(String meatName, int healthBoost)
    {
        this.meatName = meatName;
        this.healthBoost = healthBoost;
    }
}
