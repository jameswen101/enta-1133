﻿using System;

public class DieRoller
{
    public int numberOfSides = 6; //only by changing privacy, numberOfSides can be accessible
    int score = 0;
    int roll;
    Random random = new Random(); //Create an instance of Random


    public void Description()
    {
        Console.WriteLine("Roll a six sided dice.");
        Console.WriteLine();
        Console.WriteLine("Min Roll: 1");
        Console.WriteLine("Max Roll: " + numberOfSides);
        Console.WriteLine();
    }

    public void Roll()
    {
        roll = random.Next(1, numberOfSides+1);
        Console.WriteLine("Your roll: " + roll);
        score += roll;
        roll = random.Next(1, numberOfSides+1);
        Console.WriteLine("Your roll: " + roll);
        score += roll;
        roll = random.Next(1, numberOfSides + 1);
        Console.WriteLine("Your roll: " + roll);
        score += roll;
        roll = random.Next(1, numberOfSides + 1);
        Console.WriteLine("Your roll: " + roll);
        score += roll;
        Console.WriteLine();
        Console.WriteLine("Your total score is " + score + ". Thanks for playing! This is James Wen from ENTA 1133.");
        Console.WriteLine();
        Console.WriteLine("+ is used when you want to add a number by another number in your code, such as if (num + 5 > 9).");
        Console.WriteLine("- is used when you want to subtract a number by another number in your code, such as if (num - 5 > 4).");
        Console.WriteLine("* is used when you want to multiply a number by another number in your code, such as if (num * 5 > 20).");
        Console.WriteLine("/ is used when you want to divide a number by another number in your code, such as if (num / 5 > 4).");
        Console.WriteLine("++ is a simpler way to type +1. If num was originally 5, then after num++, the value of num will be 6.");
        Console.WriteLine("-- is a simpler way to say -1. If num was originally 5, then after num--, the value of num will be 4.");
        Console.WriteLine("% is used for finding the remainder of a number when dividing it by a number (eg. 11 % 3 = 2).");
    }
}
