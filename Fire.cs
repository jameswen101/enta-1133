using System;

public class Fire : Item
{
    public Fire(String itemName) : base(itemName)
    {
        description = "Use this to multiply your die rolls by 1.5.";
        asciiArt = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                               ....                                                 \r\n                                               ..#-                                                 \r\n                                                 -@%..                                              \r\n                                                 .@@@-..                                            \r\n                                                 :@@@@-                                             \r\n                                                .=@@@@@..                                           \r\n                                        . .:.   .#@@@@@* .                                          \r\n                                        ..%+.  .=@@@@@@%..                                          \r\n                                        :@@:. .:@@@@@@@@..  .-.                                     \r\n                                      ..%@@+..*@@@@@@@@@...-@-.                                     \r\n                                      .=@@@@@@@@@@@@@@@@..-@@:.                                     \r\n                                      .+@@@@@@@@@@@@@@@%..#@@+.                                     \r\n                                      .*@@@@@@@@@@@@@@@@:.#@@%.                                     \r\n                                      .*@@@@@@@@@%=@@@@@@@@@@@+..                                   \r\n                                  .-  .#@@@@@@@@#.=@@@@@@@@@@@@-.                                   \r\n                                 .*#..:@@@@@@@@@..-@@@@@@@@@@@@@- .                                 \r\n                                 .@@@@@@@@@@@@@....%@@@@@@@@@@@@@:                                  \r\n                                 *@@@@@@@@@@@@%..  .%@@@@@@@@@@@@%..                                \r\n                               ..#@@@@@@@@@%@@#..  ..+@@@@@@@@@@@@+.                                \r\n                                .#@@@@@@@@:%@@%..     .%@@@@@@@@@@%..                               \r\n                               . *@@@@@@@%.=@@%.       .-@@@@@@@@@%..                               \r\n                                 .@@@@@@@#..-##..        .%@@@@@@@*.                                \r\n                                 .+@@@@@@%...  ..      .  .%@@@@@%..                                \r\n                                 ..+@@@@@@:.              .*@@@@@-.                                 \r\n                                   .:@@@@@@..             .%@@@@:.                                  \r\n                                   ...=@@@@%..          ..#@@@*.                                    \r\n                                        :#@@@-.        ..%@@+..                                     \r\n                                           .*@#.     ..*@*..                                        \r\n                                           ......     ...  .                                        \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";
        //shows a flame
    }

    public override void useItem(User user, Enemy enemy)
    {
        foreach (DieRoller die in user.Dice)
        {
            if (die.numberOfSides == enemy.Dice[0].numberOfSides)
            {
                Console.WriteLine("__   _____  _   _ ____    _____ _   _ ____  _   _ \r\n\\ \\ / / _ \\| | | |  _ \\  |_   _| | | |  _ \\| \\ | |\r\n \\ V / | | | | | | |_) |   | | | | | | |_) |  \\| |\r\n  | || |_| | |_| |  _ <    | | | |_| |  _ <| |\\  |\r\n  |_| \\___/ \\___/|_| \\_\\   |_|  \\___/|_| \\_\\_| \\_|");
                //YOUR TURN
                die.Roll();
                if (die.roll > die.numberOfSides / 2)
                {
                    Console.WriteLine($"{user.name} rolled a {die.numberOfSides} sided die for a result of {die.roll}, multiplied by 1.5 with {itemName}, with a total of {die.roll*1.5}. Above average");
                }
                else if (die.roll == die.numberOfSides / 2)
                {
                    Console.WriteLine($"{user.name} rolled a {die.numberOfSides} sided die for a result of {die.roll}, multiplied by 1.5 with {itemName}, with a total of {die.roll * 1.5}. Average");
                }
                else
                {
                    Console.WriteLine($"{user.name} rolled a {die.numberOfSides} sided die for a result of {die.roll}, multiplied by 1.5 with {itemName}, with a total of {die.roll * 1.5}. Below average");
                }
                enemy.health -= (die.roll + (die.roll/2));
                Console.WriteLine(" _____ _   _ _____ __  ____   ___ ____    _____ _   _ ____  _   _ \r\n| ____| \\ | | ____|  \\/  \\ \\ / ( ) ___|  |_   _| | | |  _ \\| \\ | |\r\n|  _| |  \\| |  _| | |\\/| |\\ V /|/\\___ \\    | | | | | | |_) |  \\| |\r\n| |___| |\\  | |___| |  | | | |    ___) |   | | | |_| |  _ <| |\\  |\r\n|_____|_| \\_|_____|_|  |_| |_|   |____/    |_|  \\___/|_| \\_\\_| \\_|");
                //ENEMY'S TURN
                enemy.Dice[0].Roll();
                if (enemy.Dice[0].roll > enemy.Dice[0].numberOfSides / 2)
                {
                    Console.WriteLine($"{enemy.name} rolled a {enemy.Dice[0].numberOfSides} sided die for a result of {enemy.Dice[0].roll}. Above average");
                }
                else if (die.roll == die.numberOfSides / 2)
                {
                    Console.WriteLine($"{enemy.name} rolled a {enemy.Dice[0].numberOfSides} sided die for a result of {enemy.Dice[0].roll}. Average");
                }
                else
                {
                    Console.WriteLine($"{enemy.name} rolled a {enemy.Dice[0].numberOfSides} sided die for a result of {enemy.Dice[0].roll}. Below average");
                }
                user.health -= enemy.Dice[0].roll;
                Console.WriteLine($"{user.health} vs {enemy.health}");
            }
        }
    }
}
