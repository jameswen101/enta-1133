using System.Xml.Linq;

public class GameManager
{
    public void PlayGame()
    {
        //Game setup
        Console.WriteLine("__        __   _                            _               \r\n\\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___         \r\n \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\        \r\n  \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |       \r\n _ \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  _     \r\n| | | |_   _ _ __ | |_(_)_ __   __ _  __      _(_) |_| |__  \r\n| |_| | | | | '_ \\| __| | '_ \\ / _` | \\ \\ /\\ / / | __| '_ \\ \r\n|  _  | |_| | | | | |_| | | | | (_| |  \\ V  V /| | |_| | | |\r\n|_|_|_|\\__,_|_| |_|\\__|_|_| |_|\\__, |   \\_/\\_/ |_|\\__|_| |_|\r\n|  _ \\(_) ___ ___| |           |___/                        \r\n| | | | |/ __/ _ \\ |                                        \r\n| |_| | | (_|  __/_|                                        \r\n|____/|_|\\___\\___(_)                                        ");
        //Welcome to Hunting with Dice!
        Console.WriteLine("__        ___           _   _                              \r\n\\ \\      / / |__   __ _| |_( )___   _   _  ___  _   _ _ __ \r\n \\ \\ /\\ / /| '_ \\ / _` | __|// __| | | | |/ _ \\| | | | '__|\r\n  \\ V  V / | | | | (_| | |_  \\__ \\ | |_| | (_) | |_| | |   \r\n   \\_/\\_/  |_| |_|\\__,_|\\__|_|___/  \\__, |\\___/ \\__,_|_|   \r\n _ __   __ _ _ __ ___   __|__ \\     |___/                  \r\n| '_ \\ / _` | '_ ` _ \\ / _ \\/ /                            \r\n| | | | (_| | | | | | |  __/_|                             \r\n|_| |_|\\__,_|_| |_| |_|\\___(_)                             ");
        //What's your name?
        String userName = " ";
        userName = Console.ReadLine();
        User user = new User(userName); //declaring player object for user
        Eagle cpu1 = new Eagle("Eagle"); //declaring player objects for cpu
        Alligator cpu2 = new Alligator("Alligator"); //declaring player objects for cpu
        Wolf cpu3 = new Wolf("Wolf"); //declaring player objects for cpu
        Bear cpu4 = new Bear("Bear"); //declaring player objects for cpu
        Room[,] map = new Room[5, 5];
        Room currentRoom = new Room(user.row, user.col);
        List<Item> items = new List<Item>();
        List<Meat> meats = new List<Meat>();
        List<Enemy> enemies = new List<Enemy>();
        Item deadSquirrel = new DeadSquirrel("Dead Squirrel");
        Meat steak = new Steak("Steak", 20);
        Item taser = new Taser("Taser");
        Item shield = new Shield("Shield");
        Item bloodyBlade = new BloodyBlade("Bloody Blade");
        Item fire = new Fire("Fire");
        Meat porkRibs = new PorkRibs("Pork Ribs", 10);
        Item camouflage = new Camouflage("Camouflage");
        Meat drumstick = new Drumstick("Drumstick", 5);
        Meat salmon = new Salmon("Salmon", 15);

        items.Add(fire);
        items.Add(shield);
        items.Add(camouflage);
        items.Add(taser);
        items.Add(deadSquirrel);
        items.Add(bloodyBlade);
        meats.Add(porkRibs);
        meats.Add(steak);
        meats.Add(drumstick);
        meats.Add(salmon);
        enemies.Add(cpu1);
        enemies.Add(cpu2);
        enemies.Add(cpu3);
        enemies.Add(cpu4);

        //let user freely enter the die sizes they want + cpu uses the same dice
        int number = 0;
        Console.WriteLine("                                                                                               -%@@-\r\n                                                                                          ..*@@@@@@@\r\n                                                                                      .-#@@@@@@@#-..\r\n                                                                                ...=#@@@@@@@*-...   \r\n                                                                             .:+%@@@@@@@+:..        \r\n                    ........:...                                       ...-*@@@@@@@%=:..            \r\n                  ..=@@@@@@@@@@#.                                   .:+%@@@@@@@@*..                 \r\n                .-@@@@@@@@@@@@@@@+.                           ...-*@@@@@@@@@*.....                  \r\n               :@@@@@@@@@@@@@@@@@@#..                     ..:=%@@@@@@@@@@@+:.                       \r\n             .=@@@@@@@@@@@@@@@@@@@@@:........       ...:=#@@@@@@@@@@@@@*..                          \r\n            ..@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%.    ..#@@@@@@@@@@@@@@@@@#.                            \r\n            .#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@...*#@@@@@@@@@@@@@@@@@@#-..                            \r\n           .:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%. .-@@@@@@@@@@@@@@@@@@@*.                               \r\n           .#@@@@@@@@@@@@@@@@@@@@@@@*.....#@#.%@@@@@@@#:=@@@@@@@@@@#.                               \r\n           ..*@@@@@@@@@@@@@@@@@@@@@@..  .@@@@@@@@@@@+%-:@@@@@@@@%=...                               \r\n            .:@@@@@@@@@@@@@@@@@@@@@@@...*@@@@@@@@@%@-+=+@@@@@@:.                                    \r\n          ..:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-:.:@@@@@@:.                                     \r\n        .:@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-. .#@@@@@#.                                      \r\n        .#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*...-@@@@@@=.                                      \r\n       ..%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-   -@@@@@@#.                                       \r\n      .=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%:.=@@@@@+.:@@@@@@@-                                        \r\n     .*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+  .:@@@@@@@@@@@@@@%.                                        \r\n  ..:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*. .-@@@@@@@@@@@@@@@-                                         \r\n  .*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:+:#@@@@@@@@@@@@@@@#.                                         \r\n .=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-.                                         \r\n .%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#.                                         \r\n :@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=.                                         \r\n.%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-.                                         \r\n-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=.                                          \r\n=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#.                                           \r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+..                                           \r\n=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:.                                             \r\n:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*:                                               \r\n.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#=:...                                                \r\n.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%*+-..                                                         \r\n.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*.                                                             \r\n.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=                                                             \r\n.%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:                                                            \r\n.#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%..                                                          \r\n.+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%.                                                          ");
        //show picture of a hunter
        Console.WriteLine("You are a hunter who loves meat but has no money, and hunting is your only solution for feeding yourself. However, you will be facing four hungry apex predators that will attack you. \n But first, you will choose the size of the four dice that decide how much you and the predators can attack each other:");
        for (int count = 0; count < 4; count++)
        {
            if (count == 0)
            {
                do
                {
                    Console.WriteLine("How many sides do you want in this die?");
                    number = int.Parse(Console.ReadLine());
                    if (number < 6)
                    { //in the case of Dice[0], the only limit is that the # of sides must be 6+
                        Console.WriteLine("Please enter a number not smaller than 6.");
                    } //if code ends
                } while (number < 6); //do-while loop code ends
            }

            else
            {
                do
                {
                    Console.WriteLine("How many sides do you want in this die?");
                    number = int.Parse(Console.ReadLine());
                    if (number < 6 || number <= user.Dice[count - 1].numberOfSides)
                    { //the number of sides in this die must be larger than the last die
                        Console.WriteLine("Please enter a number not smaller than 6 or your previous die."); //the size of each next die the user inputs must be larger than the last one
                    } //if code ends
                } while (number < 6 || number <= user.Dice[count - 1].numberOfSides); //do-while loop code ends
            }
            user.Dice.Add(new DieRoller(number)); //add die to user's dice list
        } //for loop code ends
        cpu1.Dice.Add(user.Dice[0]);
        cpu2.Dice.Add(user.Dice[1]);
        cpu3.Dice.Add(user.Dice[2]);
        cpu4.Dice.Add(user.Dice[3]);
        user.health = user.Dice[0].numberOfSides + user.Dice[1].numberOfSides + user.Dice[2].numberOfSides + user.Dice[3].numberOfSides;
        cpu1.health = cpu1.Dice[0].numberOfSides * 2;
        cpu2.health = cpu2.Dice[0].numberOfSides * 2;
        cpu3.health = cpu3.Dice[0].numberOfSides * 2;
        cpu4.health = cpu4.Dice[0].numberOfSides * 2;

        setUpMap(map, user, cpu1, cpu2, cpu3, cpu4);
        user.row = 0; //put user and enemies in starting positions
        user.col = 0;
        cpu1.row = 1;
        cpu2.row = 2;
        cpu3.row = 3;
        cpu4.row = 4;
        cpu1.col = 1; cpu2.col = 2;
        cpu3.col = 3; cpu4.col = 4;

        void setUpMap(Room[,] map, User user, Enemy cpu1, Enemy cpu2, Enemy cpu3, Enemy cpu4)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {

                    if ((row == 2 || col == 2) && !(row == 2 && col == 2) && !(row == 2 && col == 4) && !(row == 4 && col == 2)) //excludes (2,2), (2,4), (4,2)
                    {
                        map[row, col] = new TreasureRoom(row, col);
                        map[row, col].hasItem = true; //put items in rows and columns 2
                    }
                    else if ((row == 0 && col == 4) || (row == 4 && col == 0) || (row == 2 && col == 4) || (row == 4 && col == 2)) //for (0,4), (4,0), (2,4), and (4,2)
                    {
                        map[row, col] = new DiningRoom(row, col);
                        map[row, col].hasMeat = true; //meat in rooms with both 2 and 4
                    }
                    else if (row == col && row > 0 && col > 0)
                    {
                        map[row, col] = new CombatRoom(row, col);
                        map[row, col].hasEnemy = true; //enemies' starting positions are doubles
                    }
                    else
                    {
                        map[row, col] = new Room(row, col); //make new normal rooms for each space in the map
                    }
                }
            }

        }

        //Game officially begins here
        while (user.health > 0 && cpu1.health > 0 || cpu2.health > 0 || cpu3.health > 0 || cpu4.health > 0)
        {
            checkRoomMatch(map, user, cpu1, cpu2, cpu3, cpu4);
            if (user.health > 0 && cpu1.health > 0 || cpu2.health > 0 || cpu3.health > 0 || cpu4.health > 0)
            {
                currentRoom.OnRoomExit(user);
                currentRoom.row = user.row;
                currentRoom.col = user.col;
            }
        }
        //Game ends
        endOfGame(user, cpu1, cpu2, cpu3, cpu4);

        void checkRoomMatch(Room[,] map, User user, Enemy cpu1, Enemy cpu2, Enemy cpu3, Enemy cpu4)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    if (row == user.row && col == user.col)
                    {
                        Console.WriteLine($"{user.name} is in room at {map[row, col].name} at [{row}, {col}]");

                        if (map[row, col].hasItem)
                        {
                            Random itemRandom = new Random();
                            int itemNum = itemRandom.Next(0, items.Count);
                            Console.WriteLine($"Congratulations! You have received the item {items[itemNum].itemName}! \n{items[itemNum].asciiArt} \n{items[itemNum].description} \nGood luck fighting off the apex predators!");
                            user.ItemInventory.Add(items[itemNum]);
                            user.noItems = false;
                        }
                        else if (map[row, col].hasMeat)
                        {
                            Random meatRandom = new Random();
                            int meatNum = meatRandom.Next(0, meats.Count);
                            Console.WriteLine($"Congratulations! You have received the item {meats[meatNum].meatName}! \n {meats[meatNum].asciiArt} \n{meats[meatNum].description} \nGood luck fighting off the apex predators!");
                            user.health += meats[meatNum].healthBoost;
                            Console.WriteLine($"Your health is now {user.health}."); //health may be more than the initial amount
                        }
                        else if (map[row, col].hasEnemy)
                        {
                            foreach (Enemy enemy in enemies)
                            {
                                if (user.row == enemy.row && user.col == enemy.col)
                                {
                                    if (enemy.health > 0)
                                    {
                                        enemyApproaching(); //show enemy approaching message
                                        Console.WriteLine(enemy.asciiArt); //show ASCII art of the enemy
                                        Console.WriteLine($"Enemy's health: {enemy.health}");
                                        exchangeAttack(user, enemy);
                                    }
                                    if (enemy.health <= 0)
                                    {
                                        enemy.enemyIsDead();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("This room is safe.");
                        }
                    }
                }
            }
        }
        void enemyApproaching()
        {
            Console.WriteLine(" _____ _   _ _____ __  ____   __                             \r\n| ____| \\ | | ____|  \\/  \\ \\ / /                             \r\n|  _| |  \\| |  _| | |\\/| |\\ V /                              \r\n| |___| |\\  | |___| |  | | | |                               \r\n|_____|_|_\\_|_____|_| _|_| |_|    ____ _   _ ___ _   _  ____ \r\n   / \\  |  _ \\|  _ \\ / _ \\  / \\  / ___| | | |_ _| \\ | |/ ___|\r\n  / _ \\ | |_) | |_) | | | |/ _ \\| |   | |_| || ||  \\| | |  _ \r\n / ___ \\|  __/|  _ <| |_| / ___ \\ |___|  _  || || |\\  | |_| |\r\n/_/   \\_\\_|   |_| \\_\\\\___/_/   \\_\\____|_| |_|___|_| \\_|\\____|");
            //ENEMY APPROACHING
        }

        void exchangeAttack(User user, Enemy enemy)
        {
            bool rightChoice = false;
            if (!user.noItems)
            {
                String response = " ";
                do
                {
                    Console.WriteLine("Do you wish to use any items?");
                    response = Console.ReadLine();
                    if (response.ToUpper() != "YES" && response.ToUpper() != "NO")
                    {
                        Console.WriteLine("Please enter yes or no.");
                    }
                } while (response.ToUpper() != "YES" && response.ToUpper() != "NO");

                if (response.ToUpper() == "YES")
                {
                    String itemChoice = " ";
                    do
                    {
                        Console.WriteLine("Which item would you like to use?");
                        foreach (Item item in user.ItemInventory)
                        {
                            Console.WriteLine(item.itemName);
                        }
                        itemChoice = Console.ReadLine();
                        foreach (Item item in user.ItemInventory)
                        {
                            if (itemChoice.ToUpper() == item.itemName.ToUpper())
                            {
                                rightChoice = true;
                            }
                        }
                        if (!rightChoice)
                        {
                            Console.WriteLine("Please enter the right item name.");
                        }
                    } while (!rightChoice);

                    for (int itemNum = 0; itemNum < user.ItemInventory.Count; itemNum++) //foreach loop will cause an invalid operation exception here

                    {
                        if (itemChoice.ToUpper() == user.ItemInventory[itemNum].itemName.ToUpper())
                        {
                            Console.WriteLine(user.ItemInventory[itemNum].asciiArt);
                            user.ItemInventory[itemNum].useItem(user, enemy);
                            user.ItemInventory.RemoveAt(itemNum);
                            if (user.ItemInventory.Count == 0)
                            {
                                user.noItems = true;
                            }
                        }
                    }
                }
                else
                {
                    normalRoll(user, enemy);
                }
            }
            else
            {
                normalRoll(user, enemy);
            }
        }

        void normalRoll(User user, Enemy enemy)
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
                        Console.WriteLine($"{user.name} rolled a {die.numberOfSides} sided die for a result of {die.roll}. Above average");
                    }
                    else if (die.roll == die.numberOfSides / 2)
                    {
                        Console.WriteLine($"{user.name} rolled a {die.numberOfSides} sided die for a result of {die.roll}. Average");
                    }
                    else
                    {
                        Console.WriteLine($"{user.name} rolled a {die.numberOfSides} sided die for a result of {die.roll}. Below average");
                    }
                    enemy.health -= die.roll;
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
                    if (enemy.health <= 0)
                    {
                        enemy.enemyIsDead();
                    }
                }
            }
        }

        void endOfGame(User user, Enemy cpu1, Enemy cpu2, Enemy cpu3, Enemy cpu4)
        {
            Console.WriteLine(" _____ _            _____           _ \r\n|_   _| |__   ___  | ____|_ __   __| |\r\n  | | | '_ \\ / _ \\ |  _| | '_ \\ / _` |\r\n  | | | | | |  __/ | |___| | | | (_| |\r\n  |_| |_| |_|\\___| |_____|_| |_|\\__,_|");
            //THE END
            if (user.health > 0 && cpu1.health <= 0 && cpu2.health <= 0 && cpu3.health <= 0 && cpu4.health <= 0)
            {
                Console.WriteLine($"Congratulations {user.name}! You have won with {user.health} health points remaining and have successfully defeated all apex predators! Time to cook up a nice feast with all your prey!");
                Console.WriteLine("_          _\r\n                           (c)___c____(c)\r\n                            \\ ........../\r\n                             |.........|\r\n                              |.......|\r\n                              |.......|\r\n                              |=======|\r\n                              |=======|\r\n                             __o)\"\"\"\"::?\r\n                            C__    c)::;\r\n                               >--   ::     /\\\r\n                               (____/      /__\\\r\n                               } /\"\"|      |##|\r\n                    __/       (|V ^ )\\     |##|\r\n                    o | _____/ |#/ / |     |##|\r\n           @        o_|}|_____/|/ /  |     |##|\r\n                          _____/ /   |     !!\r\n              ======ooo}{|______)#   |     /`'\\\r\n          ~~ ;    ;          ###---|8     \"\"\r\n        __;_____;____        ###====     /:|\\\r\n       (///0///@///@///)       ###@@@@|\r\n       |~~~~~~~~~~~~~~~|       ###@@@@|\r\n        \\             /        ###@@@@|               +\r\n         \\___________/         ###xxxxx      /\\      //\r\n           H H   H  H          ###|| |      /  \\    //\r\n           H H   H  H           | || |     /____\\  /~^\r\n           H H   H  H           C |C |     |@@| /__|#|_\r\n           H H   H  H            || ||    /_|@@|_/___|#|/|\r\n v    \\/   H(o) (o) H            || ::   |:::::::::::::|#|\r\n ~    ~~  (o)      (o)        Ccc__)__)  |ROMAN CANDLES|#|\r\n  \\|/      ~   @* & ~                    |:::::::::::::|/  \\|/\r\n   ~           \\|/        !!        \\ !/  ~~~~~~~~~~~    ~\r\n               ~        ~         ~           ~~\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (user.health <= 0 && cpu1.health > 0 || cpu2.health > 0 || cpu3.health > 0 || cpu4.health > 0)
            {
                Console.WriteLine("_  /)\r\n                 mo / )\r\n                 |/)\\)\r\n                  /\\_\r\n                  \\__|=\r\n                 (    )\r\n                 _)(_\r\n           ____/      \\\\____\r\n          |                  ||\r\n          |  _     _   _   ||\r\n          | | \\     |   | \\  ||\r\n          | |  |    |   |  | ||\r\n          | |_/     |   |_/  ||\r\n          | | \\     |   |    ||\r\n          | |  \\    |   |    ||\r\n          | |   \\. |. | .  ||\r\n          |                  ||\r\n  *       | *   *    * *   |**      **\r\n   \\))ejm96/.,(//,,..,,\\||(,,.,\\\\,.((//");
                //Show picture of tombstone
                Console.WriteLine($"Congratulations apex predators! The 4 of you have officially hunted {user.name} and you can enjoy them for dinner! \n Who is still alive to eat the remains of {user.name}?");
                foreach (Enemy enemy in enemies)
                {
                    if (enemy.health > 0)
                    {
                        Console.WriteLine($"{enemy.asciiArt}");
                    }
                    Console.WriteLine($"{enemy.name} has won with {enemy.health} remaining.");
                }
            }
            else
            {
                Console.WriteLine($"Seems like both you and all 4 apex predators have succumbed to your respective injuries. \nR.I.P. {user.name} and all apex predators...");
            }
            Console.WriteLine(" _____ _                 _                           __            \r\n|_   _| |__   __ _ _ __ | | __  _   _  ___  _   _   / _| ___  _ __ \r\n  | | | '_ \\ / _` | '_ \\| |/ / | | | |/ _ \\| | | | | |_ / _ \\| '__|\r\n  | | | | | | (_| | | | |   <  | |_| | (_) | |_| | |  _| (_) | |   \r\n  |_| |_| |_|\\__,_|_| |_|_|\\_\\  \\__, |\\___/ \\__,_| |_|  \\___/|_|   \r\n       _             _          |___/                              \r\n _ __ | | __ _ _   _(_)_ __   __ _| |                              \r\n| '_ \\| |/ _` | | | | | '_ \\ / _` | |                              \r\n| |_) | | (_| | |_| | | | | | (_| |_|                              \r\n| .__/|_|\\__,_|\\__, |_|_| |_|\\__, (_)                              \r\n|_|            |___/         |___/                                 ");
            //show picture of person cooking dinner

        }


    }
}
