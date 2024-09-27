using System;
using System.Security.Cryptography;

public class GameManager
{
   
    public void PlayGame()
    {

        DieRoller fiftySidedDie = new DieRoller(50); //die only used for deciding turn order
        Console.WriteLine("Welcome to Die vs Die!");
        Player user = new Player(); //declaring player object for user
        Player cpu = new Player(); //declaring player object for cpu
        Player currentTurn = user; //setting the current turn to the user

        Console.WriteLine("Who's going first? Let's use a really big die to decide.\n Roll evens and you get to go first!");
        if (fiftySidedDie.Roll() % 2 == 1)
        {
            currentTurn = cpu;
            Console.WriteLine($"The number rolled was {fiftySidedDie.roll}. CPU goes first"); //if the result is odd
        }
        else
        {
            currentTurn = user;
            Console.WriteLine($"The number rolled was {fiftySidedDie.roll}. User goes first"); //if the result is even
        }

        if (currentTurn == user)
        {
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
        }
        if (currentTurn == cpu) 
        {
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
            cpuTurn(user, cpu, currentTurn);
            userTurn(user, cpu, currentTurn);
        }

            if (user.turnsTaken == 4 && cpu.turnsTaken == 4) //show final score + winner after all turns have been taken
            {
            endOfGame(user, cpu);
            }
        }
    public void userTurn(Player user, Player cpu, Player currentTurn)
    {
        DieRoller sixSidedDie = new DieRoller(6); //Create an instance of DieRoller
        DieRoller eightSidedDie = new DieRoller(8); //Create an instance of DieRoller
        DieRoller twelveSidedDie = new DieRoller(12); //Create an instance of DieRoller
        DieRoller twentySidedDie = new DieRoller(20); //Create an instance of DieRoller
        Console.WriteLine("User's turn");
        Console.WriteLine("Which die would you like to roll? Please choose from the 6, 8, 12, and the 20-sided die. Enter the number of sides of the die you wish to roll. Remember, each die can only be rolled once.");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number == 6)
            {
                if (user.sixRolled == true)
                {
                    Console.WriteLine("Already rolled"); //no way to go back as while loop can't be used
                }
                else
                {
                    sixSidedDie.Roll();
                    Console.WriteLine($"Rolled a {sixSidedDie.numberOfSides} sided die for a result of {sixSidedDie.roll}.");
                    user.sixRolled = true;
                    user.score += sixSidedDie.roll;
                    Console.WriteLine($"{user.score} vs {cpu.score}");
                    user.turnsTaken += 1;
                    currentTurn = cpu; //switches turns to the other player; current turn ends
                }
            }
            else if (number == 8)
            {
                if (user.eightRolled == true) 
                {
                    Console.WriteLine("Already rolled"); //no way to go back as while loop can't be used
                }
                else
                {
                    eightSidedDie.Roll();
                    Console.WriteLine($"Rolled a {eightSidedDie.numberOfSides} sided die for a result of {eightSidedDie.roll}.");
                    user.eightRolled = true;
                    user.score += eightSidedDie.roll;
                    Console.WriteLine($"{user.score} vs {cpu.score}");
                    user.turnsTaken += 1;
                    currentTurn = cpu; //switches turns to the other player; current turn ends
                }
            }
            else if (number == 12)
            {
                if (user.twelveRolled == true)
                {
                    Console.WriteLine("Already rolled"); //no way to go back as while loop can't be used
                }
                else
                {
                    twelveSidedDie.Roll();
                    Console.WriteLine($"Rolled a {twelveSidedDie.numberOfSides} sided die for a result of {twelveSidedDie.roll}.");
                    user.twelveRolled = true;
                    user.score += twelveSidedDie.roll;
                    Console.WriteLine($"{user.score} vs {cpu.score}");
                    user.turnsTaken += 1;
                    currentTurn = cpu; //switches turns to the other player; current turn ends
                }
            }
            else if (number == 20)
            {
                if (user.twentyRolled == true)
                {
                    Console.WriteLine("Already rolled"); //no way to go back as while loop can't be used
                }
                else
                {
                    twentySidedDie.Roll();
                    Console.WriteLine($"Rolled a {twentySidedDie.numberOfSides} sided die for a result of {twentySidedDie.roll}.");
                    user.twentyRolled = true;
                    user.score += twentySidedDie.roll;
                    Console.WriteLine($"{user.score} vs {cpu.score}");
                    user.turnsTaken += 1;
                    currentTurn = cpu; //switches turns to the other player; current turn ends
                }
            }
            else
            {
                Console.WriteLine("Dice unavailable"); //no way to go back as while loop can't be used
            }
        }
        else
        {
            Console.WriteLine("Error! Please enter a number!"); //no way to go back as while loop can't be used
        }
    }
    public void cpuTurn(Player user, Player cpu, Player currentTurn)
    {
        DieRoller sixSidedDie = new DieRoller(6); //Create an instance of DieRoller
        DieRoller eightSidedDie = new DieRoller(8); //Create an instance of DieRoller
        DieRoller twelveSidedDie = new DieRoller(12); //Create an instance of DieRoller
        DieRoller twentySidedDie = new DieRoller(20); //Create an instance of DieRoller
        Console.WriteLine("CPU's turn");
        if (cpu.sixRolled == false)
        {
            sixSidedDie.Roll();
            Console.WriteLine($"Rolled a {sixSidedDie.numberOfSides} sided die for a result of {sixSidedDie.roll}.");
            cpu.sixRolled = true;
            cpu.score += sixSidedDie.roll;
            Console.WriteLine($"{user.score} vs {cpu.score}");
            cpu.turnsTaken += 1;
            currentTurn = user; //switches turns to the other player; current turn ends
        }
        else if (cpu.sixRolled == true && cpu.eightRolled == false)
        {
            eightSidedDie.Roll();
            Console.WriteLine($"Rolled a {eightSidedDie.numberOfSides} sided die for a result of {eightSidedDie.roll}.");
            cpu.eightRolled = true;
            cpu.score += eightSidedDie.roll;
            Console.WriteLine($"{user.score} vs {cpu.score}");
            cpu.turnsTaken += 1;
            currentTurn = user; //switches turns to the other player; current turn ends
        }
        else if (cpu.sixRolled == true && cpu.eightRolled == true && cpu.twelveRolled == false)
        {
            twelveSidedDie.Roll();
            Console.WriteLine($"Rolled a {twelveSidedDie.numberOfSides} sided die for a result of {twelveSidedDie.roll}.");
            cpu.twelveRolled = true;
            cpu.score += twelveSidedDie.roll;
            Console.WriteLine($"{user.score} vs {cpu.score}");
            cpu.turnsTaken += 1;
            currentTurn = user; //switches turns to the other player; current turn ends
        }
        else if (cpu.sixRolled == true && cpu.eightRolled == true && cpu.twelveRolled == true && cpu.twentyRolled == false)
        {
            twentySidedDie.Roll();
            Console.WriteLine($"Rolled a {twentySidedDie.numberOfSides} sided die for a result of {twentySidedDie.roll}.");
            cpu.twentyRolled = true;
            cpu.score += twentySidedDie.roll;
            Console.WriteLine($"{user.score} vs {cpu.score}");
            cpu.turnsTaken += 1;
            currentTurn = user; //switches turns to the other player; current turn ends
        }
    }
    public void endOfGame(Player user, Player cpu)
    {
        Console.WriteLine($"Final score of user: {user.score}");
        Console.WriteLine($"Final score of CPU: {cpu.score}");
        if (user.score > cpu.score)
        {
            Console.WriteLine($"Congratulations user! You have won with {user.score} points!");
        }
        else if (cpu.score > user.score)
        {
            Console.WriteLine($"Congratulations CPU! They have won with {cpu.score} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations to the both of you! You two are tied at {user.score} points.");
        }
        Console.WriteLine("Thank you for playing!");
    }
    }



