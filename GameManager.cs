using System;
using System.Collections;
using System.Reflection.Emit;

public class GameManager
{
    public void PlayGame()
    {

        DieRoller fiftySidedDie = new DieRoller(50); //die only used for deciding turn order
        Console.WriteLine("__        __   _                            _          ____  _      \r\n\\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___   |  _ \\(_) ___ \r\n \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\  | | | | |/ _ \\\r\n  \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | |  __/\r\n   \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  |____/|_|\\___|\r\n__   _____  |  _ \\(_) ___| |                                        \r\n\\ \\ / / __| | | | | |/ _ \\ |                                        \r\n \\ V /\\__ \\ | |_| | |  __/_|                                        \r\n  \\_/ |___/ |____/|_|\\___(_)                                        ");
        Console.WriteLine("What is your name?");
        String userName = " ";
        userName = Console.ReadLine();
        String cpuName = "CPU";
        Player user = new Player(userName); //declaring player object for user
        Player cpu = new Player(cpuName); //declaring player object for cpu
        Player firstTurn = user; //holds the player who gets to go first

        //let user freely enter the die sizes they want + cpu uses the same dice
         int number = 0;
        Console.WriteLine("In this game, you will take turns rolling 4 dice of any size you like with the CPU. But first, I need to know how big are your desired dice:");
         for (int count = 1; count <= 4; count++) {
         do {
         Console.WriteLine("How many sides do you want in this die?");
         number = int.Parse(Console.ReadLine());
         if (number < 6) {
         Console.WriteLine("Please enter a number not smaller than 6.");
         } //if code ends
         } while (number < 6); //do-while loop code ends
         user.Dice.Add(new DieRoller(number));
         } //for loop code ends
         cpu.Dice = user.Dice; 
       

        Console.WriteLine("Who's going first? Let's use a really big die to decide.\n Roll evens and you get to go first!");
        if (fiftySidedDie.Roll() % 2 == 1)
        {
            firstTurn = cpu;
            Console.WriteLine($"The number rolled was {fiftySidedDie.roll}. CPU goes first"); //if the result is odd
        }
        else
        {
            firstTurn = user;
            Console.WriteLine($"The number rolled was {fiftySidedDie.roll}. User goes first"); //if the result is even
        }

        if (firstTurn == user)
        {
            for (int i = 1; i < 5; i++)
            {
                userTurn(user, cpu);
                cpuTurn(user, cpu);
                showRoundWinner(user, cpu);
            }
            endOfGame(user, cpu);
        }
        if (firstTurn == cpu)
        {
            for (int i = 1; i < 5; i++)
            {
                cpuTurn(user, cpu);
                userTurn(user, cpu);
                showRoundWinner(user, cpu);
            }
            endOfGame(user, cpu);
        }

    }
    public void userTurn(Player user, Player cpu) //UserTurn different from CPUTurn since one requires input and one doesn't
    {
        bool isCurrentTurn = true;
        int num = 0;
         
        while (user.turnsTaken < 5 && isCurrentTurn == true)
        {
            
            Console.WriteLine("__   __                 _____                 \r\n\\ \\ / /__  _   _ _ __  |_   _|   _ _ __ _ __  \r\n \\ V / _ \\| | | | '__|   | || | | | '__| '_ \\ \r\n  | | (_) | |_| | |      | || |_| | |  | | | |\r\n  |_|\\___/ \\__,_|_|      |_| \\__,_|_|  |_| |_|");
            while (num != user.Dice[0].numberOfSides && num != user.Dice[1].numberOfSides && num != user.Dice[2].numberOfSides && num != user.Dice[3].numberOfSides)
            {
            Console.WriteLine("Which die would you like to roll?");
                num = int.Parse(Console.ReadLine());
            } //while loop code ends
                if (num == user.Dice[0].numberOfSides)
                {
                    if (user.Dice[0].userRolled == true)
                    {
                        Console.WriteLine("Already rolled"); //asks user to choose die again
                    while (num != user.Dice[1].numberOfSides && num != user.Dice[2].numberOfSides && num != user.Dice[3].numberOfSides)
                    {
                        Console.WriteLine("Which die would you like to roll?");
                        num = int.Parse(Console.ReadLine());
                    } //while loop code ends
                }
                    else
                    {
                       user.Dice[0].Roll();
                       if (user.Dice[0].roll > (user.Dice[0].numberOfSides/2)) {
                       Console.WriteLine($"{user.name} rolled a {user.Dice[0].numberOfSides} sided die for a result of {user.Dice[0].roll}. Above average");
                       }
                       else if (user.Dice[0].roll == (user.Dice[0].numberOfSides/2)) {
                       Console.WriteLine($"{user.name} rolled a {user.Dice[0].numberOfSides} sided die for a result of {user.Dice[0].roll}. Average");
                       }
                       else {
                       Console.WriteLine($"{user.name} rolled a {user.Dice[0].numberOfSides} sided die for a result of {user.Dice[0].roll}. Below Average");
                       }
                    user.Dice[0].userRolled = true;
                        user.roundScore = user.Dice[0].roll;
                        user.totalScore += user.roundScore;
                        Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                        user.turnsTaken += 1;
                        Console.WriteLine($"Turns taken: {user.turnsTaken}"); //shows how many turns are taken
                        isCurrentTurn = false; //breaks the loop
                    }
                }
                else if (num == user.Dice[1].numberOfSides)
                {
                    if (user.Dice[1].userRolled == true)
                    {
                        Console.WriteLine("Already rolled"); //asks user to choose die again
                    while (num != user.Dice[0].numberOfSides && num != user.Dice[2].numberOfSides && num != user.Dice[3].numberOfSides)
                    {
                        Console.WriteLine("Which die would you like to roll?");
                        num = int.Parse(Console.ReadLine());
                    } //while loop code ends
                }
                    else
                    {
                        user.Dice[1].Roll();
                    if (user.Dice[1].roll > (user.Dice[1].numberOfSides / 2))
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[1].numberOfSides} sided die for a result of {user.Dice[1].roll}. Above average");
                    }
                    else if (user.Dice[1].roll == (user.Dice[1].numberOfSides / 2))
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[1].numberOfSides} sided die for a result of {user.Dice[1].roll}. Average");
                    }
                    else
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[1].numberOfSides} sided die for a result of {user.Dice[1].roll}. Below Average");
                    }
                    user.Dice[1].userRolled = true;
                    user.roundScore = user.Dice[1].roll;
                    user.totalScore += user.roundScore;
                    Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                    user.turnsTaken += 1;
                        Console.WriteLine($"Turns taken: {user.turnsTaken}"); //shows how many turns are taken
                        isCurrentTurn = false; //breaks the loop
                    }
                }
                else if (num == user.Dice[2].numberOfSides)
                {
                    if (user.Dice[2].userRolled == true)
                    {
                        Console.WriteLine("Already rolled"); //asks user to choose die again
                    while (num != user.Dice[0].numberOfSides && num != user.Dice[1].numberOfSides && num != user.Dice[3].numberOfSides)
                    {
                        Console.WriteLine("Which die would you like to roll?");
                        num = int.Parse(Console.ReadLine());
                    } //while loop code ends
                }
                    else
                    {
                        user.Dice[2].Roll();
                    if (user.Dice[2].roll > (user.Dice[2].numberOfSides / 2))
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[2].numberOfSides} sided die for a result of {user.Dice[2].roll}. Above average");
                    }
                    else if (user.Dice[2].roll == (user.Dice[2].numberOfSides / 2))
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[2].numberOfSides} sided die for a result of {user.Dice[2].roll}. Average");
                    }
                    else
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[2].numberOfSides} sided die for a result of {user.Dice[2].roll}. Below Average");
                    }
                    user.Dice[2].userRolled = true;
                    user.roundScore = user.Dice[2].roll;
                    user.totalScore += user.roundScore;
                    Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                    user.turnsTaken += 1;
                        Console.WriteLine($"Turns taken: {user.turnsTaken}"); //shows how many turns are taken
                        isCurrentTurn = false; //breaks the loop
                    }
                }
                else if (num == user.Dice[3].numberOfSides)
                {
                    if (user.Dice[3].userRolled == true)
                    {
                        Console.WriteLine("Already rolled"); //asks user to choose die again
                    while (num != user.Dice[0].numberOfSides && num != user.Dice[1].numberOfSides && num != user.Dice[2].numberOfSides)
                    {
                        Console.WriteLine("Which die would you like to roll?");
                        num = int.Parse(Console.ReadLine());
                    } //while loop code ends
                }
                    else
                    {
                        user.Dice[3].Roll();
                    if (user.Dice[3].roll > (user.Dice[3].numberOfSides / 2))
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[3].numberOfSides} sided die for a result of {user.Dice[3].roll}. Above average");
                    }
                    else if (user.Dice[3].roll == (user.Dice[3].numberOfSides / 2))
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[3].numberOfSides} sided die for a result of {user.Dice[3].roll}. Average");
                    }
                    else
                    {
                        Console.WriteLine($"{user.name} rolled a {user.Dice[3].numberOfSides} sided die for a result of {user.Dice[3].roll}. Below Average");
                    }
                    user.Dice[3].userRolled = true;
                    user.roundScore = user.Dice[3].roll;
                    user.totalScore += user.roundScore;
                    Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                    user.turnsTaken += 1;
                        Console.WriteLine($"Turns taken: {user.turnsTaken}"); //shows how many turns are taken
                        isCurrentTurn = false; //breaks the loop
                    }
                }
                else
                {
                    Console.WriteLine("Dice unavailable"); //asks user to choose die again
                }
        }
    }
    public void cpuTurn(Player user, Player cpu)
    {
        Random random = new Random();
        bool isCurrentTurn = true;

        while (cpu.turnsTaken < 5 && isCurrentTurn == true)
        {
            Console.WriteLine("  ____ ____  _   _ _       _____                 \r\n / ___|  _ \\| | | ( )___  |_   _|   _ _ __ _ __  \r\n| |   | |_) | | | |// __|   | || | | | '__| '_ \\ \r\n| |___|  __/| |_| | \\__ \\   | || |_| | |  | | | |\r\n \\____|_|    \\___/  |___/   |_| \\__,_|_|  |_| |_|");
            int dieChoice = random.Next(0, cpu.Dice.Count+1);
            if (dieChoice == 0) 
            {
                cpu.Dice[0].Roll();
                if (cpu.Dice[0].roll > (cpu.Dice[0].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[0].numberOfSides} sided die for a result of {cpu.Dice[0].roll}. Above average");
                }
                else if (cpu.Dice[0].roll == (cpu.Dice[0].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[0].numberOfSides} sided die for a result of {cpu.Dice[0].roll}. Average");
                }
                else
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[0].numberOfSides} sided die for a result of {cpu.Dice[0].roll}. Below Average");
                }
                cpu.Dice[0].cpuRolled = true;
                cpu.roundScore = cpu.Dice[0].roll;
                cpu.totalScore += cpu.roundScore;
                Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                cpu.turnsTaken += 1;
                Console.WriteLine($"Turns taken: {cpu.turnsTaken}"); //shows how many turns are taken
                isCurrentTurn = false; //breaks the loop
            }
            else if (dieChoice == 1) 
            {
                cpu.Dice[1].Roll();
                if (cpu.Dice[1].roll > (cpu.Dice[1].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[1].numberOfSides} sided die for a result of {cpu.Dice[1].roll}. Above average");
                }
                else if (cpu.Dice[1].roll == (cpu.Dice[1].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[1].numberOfSides} sided die for a result of {cpu.Dice[1].roll}. Average");
                }
                else
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[1].numberOfSides} sided die for a result of {cpu.Dice[1].roll}. Below Average");
                }
                cpu.Dice[1].cpuRolled = true;
                cpu.roundScore = cpu.Dice[1].roll;
                cpu.totalScore += cpu.roundScore;
                Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                cpu.turnsTaken += 1;
                Console.WriteLine($"Turns taken: {cpu.turnsTaken}"); //shows how many turns are taken
                isCurrentTurn = false; //breaks the loop
            }
            else if (dieChoice == 2) 
            {
                cpu.Dice[2].Roll();
                if (cpu.Dice[2].roll > (cpu.Dice[2].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[2].numberOfSides} sided die for a result of {cpu.Dice[2].roll}. Above average");
                }
                else if (cpu.Dice[2].roll == (cpu.Dice[2].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[2].numberOfSides} sided die for a result of {cpu.Dice[2].roll}. Average");
                }
                else
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[2].numberOfSides} sided die for a result of {cpu.Dice[2].roll}. Below Average");
                }
                cpu.Dice[2].cpuRolled = true;
                cpu.roundScore = cpu.Dice[2].roll;
                cpu.totalScore += cpu.roundScore;
                Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                cpu.turnsTaken += 1;
                Console.WriteLine($"Turns taken: {cpu.turnsTaken}"); //shows how many turns are taken
                isCurrentTurn = false; //breaks the loop
            }
            else if (dieChoice == 3) 
            {
                cpu.Dice[3].Roll();
                if (cpu.Dice[3].roll > (cpu.Dice[3].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[3].numberOfSides} sided die for a result of {cpu.Dice[3].roll}. Above average");
                }
                else if (cpu.Dice[3].roll == (cpu.Dice[3].numberOfSides / 2))
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[3].numberOfSides} sided die for a result of {cpu.Dice[3].roll}. Average");
                }
                else
                {
                    Console.WriteLine($"{cpu.name} rolled a {cpu.Dice[3].numberOfSides} sided die for a result of {cpu.Dice[3].roll}. Below Average");
                }
                cpu.Dice[3].cpuRolled = true;
                cpu.roundScore = cpu.Dice[3].roll;
                cpu.totalScore += cpu.roundScore;
                Console.WriteLine($"{user.totalScore} vs {cpu.totalScore}");
                cpu.turnsTaken += 1;
                Console.WriteLine($"Turns taken: {cpu.turnsTaken}"); //shows how many turns are taken
                isCurrentTurn = false; //breaks the loop
            }
        }
    }
    public void showRoundWinner(Player user, Player cpu)
    {
        Console.WriteLine($"This round's score: {user.roundScore} vs {cpu.roundScore}");
        if (user.roundScore > cpu.roundScore)
        {
            Console.WriteLine($"{user.name} is in the lead this round!");
            user.roundsWon++;
        }
        else if (user.roundScore == cpu.roundScore)
        {
            Console.WriteLine($"Both of you are tied this round!");
        }
        else
        {
            Console.WriteLine($"{cpu.name} is in the lead this round!");
            cpu.roundsWon++;
        }
        Console.WriteLine($"Rounds won: {user.roundsWon} vs {cpu.roundsWon}");
    }
    public void endOfGame(Player user, Player cpu)
    {
        Console.WriteLine(" _____ _            _____           _ \r\n|_   _| |__   ___  | ____|_ __   __| |\r\n  | | | '_ \\ / _ \\ |  _| | '_ \\ / _` |\r\n  | | | | | |  __/ | |___| | | | (_| |\r\n  |_| |_| |_|\\___| |_____|_| |_|\\__,_|");
        if (user.totalScore > ((user.Dice[0].numberOfSides + user.Dice[1].numberOfSides + user.Dice[2].numberOfSides + user.Dice[3].numberOfSides) / 2))
        {
            Console.WriteLine($"Final score of {user.name}: {user.totalScore}- Above average");
        }
        else if (user.totalScore == ((user.Dice[0].numberOfSides + user.Dice[1].numberOfSides + user.Dice[2].numberOfSides + user.Dice[3].numberOfSides) / 2))
        {
            Console.WriteLine($"Final score of {user.name}: {user.totalScore}- Average");
        }
        else
        {
            Console.WriteLine($"Final score of {user.name}: {user.totalScore}- Below average");
        }
        if (cpu.totalScore > ((cpu.Dice[0].numberOfSides + cpu.Dice[1].numberOfSides + cpu.Dice[2].numberOfSides + cpu.Dice[3].numberOfSides) / 2))
        {
            Console.WriteLine($"Final score of {cpu.name}: {cpu.totalScore}- Above average");
        }
        else if (cpu.totalScore == ((cpu.Dice[0].numberOfSides + cpu.Dice[1].numberOfSides + cpu.Dice[2].numberOfSides + cpu.Dice[3].numberOfSides) / 2))
        {
            Console.WriteLine($"Final score of {cpu.name}: {cpu.totalScore}- Average");
        }
        else
        {
            Console.WriteLine($"Final score of {cpu.name}: {cpu.totalScore}- Below average");
        }
        Console.WriteLine($"Rounds won: {user.roundsWon} vs {cpu.roundsWon}");
        if (user.totalScore > cpu.totalScore)
        {
            Console.WriteLine($"Congratulations {user.name}! You have won with {user.totalScore} points and won {user.roundsWon} rounds!");
        }
        else if (cpu.totalScore > user.totalScore)
        {
            Console.WriteLine($"Congratulations {cpu.name}! They have won with {cpu.totalScore} points and won {user.roundsWon} rounds!");
        }
        else
        {
            Console.WriteLine($"Congratulations to the both of you! You two are tied at {user.totalScore} points. {user.name} won {user.roundsWon} rounds and {cpu.name} won {cpu.roundsWon} rounds");
        }
        Console.WriteLine(" _____ _                 _                           __            \r\n|_   _| |__   __ _ _ __ | | __  _   _  ___  _   _   / _| ___  _ __ \r\n  | | | '_ \\ / _` | '_ \\| |/ / | | | |/ _ \\| | | | | |_ / _ \\| '__|\r\n  | | | | | | (_| | | | |   <  | |_| | (_) | |_| | |  _| (_) | |   \r\n  |_| |_| |_|\\__,_|_| |_|_|\\_\\  \\__, |\\___/ \\__,_| |_|  \\___/|_|   \r\n       _             _          |___/                              \r\n _ __ | | __ _ _   _(_)_ __   __ _| |                              \r\n| '_ \\| |/ _` | | | | | '_ \\ / _` | |                              \r\n| |_) | | (_| | |_| | | | | | (_| |_|                              \r\n| .__/|_|\\__,_|\\__, |_|_| |_|\\__, (_)                              \r\n|_|            |___/         |___/                                 ");
    }
}


