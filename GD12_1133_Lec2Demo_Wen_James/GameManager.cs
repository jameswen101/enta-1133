using System;

public class GameManager
{
    private bool againstComputer = true;

    public void PlayGame()
    {
        Console.WriteLine("Welcome to Die vs Die!");
        DieRoller dieRollerInstance;
        dieRollerInstance = new DieRoller(); //Create an instance of DieRoller
        Console.Write("This is a game about rolling dice with ");
        Console.Write(dieRollerInstance.numberOfSides);
        Console.Write(" sides! ");
        dieRollerInstance.Description();
        dieRollerInstance.Roll();
    }


}
