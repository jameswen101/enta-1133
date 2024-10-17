using System;

public class Room
{
	public bool hasItem, hasMeat, hasEnemy, userInRoom, eagleInRoom, alliInRoom, wolfInRoom, bearInRoom = false;
	public int row, col;
	public String name;

	public Room(int row, int col)
	{
		this.row = row;
		this.col = col;
		this.name = $"room{row}-{col}";
	}

    public void OnRoomExit(User user) //OnRoomEntered and OnRoomExit merged into one function
    {
        String directionChoice = " ";
        bool validDirection = false; //initialize them here as the value restarts every time the function is called
        List<String> Directions = new List<string>();
        do
        {
            Console.WriteLine("Which direction would you like to go for your next room?");
            if (row > 0)
            {
                Console.WriteLine("North");
                Directions.Add("North");
            }
            if (col > 0)
            {
                Console.WriteLine("West");
                Directions.Add("West");
            }
            if (row < 4)
            {
                Console.WriteLine("South");
                Directions.Add("South");
            }
            if (col < 4)
            {
                Console.WriteLine("East");
                Directions.Add("East");
            }
            directionChoice = Console.ReadLine();
            foreach (String direction in Directions)
            {
                if (directionChoice.ToUpper() == direction.ToUpper())
                {
                    validDirection = true;
                } //if code ends
            } //foreach loop code ends
            if (!validDirection)
            {
                Console.WriteLine("Please enter a valid direction.");
            } //if code ends
        } while (!validDirection); //do-while code ends

        switch (directionChoice.ToUpper()) //if input is valid
        {
            case "WEST":
                Console.WriteLine("Moving west...");
                user.col -= 1;
                Console.WriteLine($"You're currently in room ({user.row},{user.col}). \nLet's search this room for items and enemies!");
                showSearch();
                break;

            case "NORTH":
                Console.WriteLine("Moving north...");
                user.row -= 1;
                Console.WriteLine($"You're currently in room ({user.row},{user.col}). \nLet's search this room for items and enemies!");
                showSearch();
                break;

            case "SOUTH":
                Console.WriteLine("Moving south...");
                user.row += 1;
                Console.WriteLine($"You're currently in room ({user.row},{user.col}). \nLet's search this room for items and enemies!");
                showSearch();
                break;

            case "EAST":
                Console.WriteLine("Moving east...");
                user.col += 1;
                Console.WriteLine($"You're currently in room ({user.row},{user.col}). \nLet's search this room for items and enemies!");
                showSearch();
                break;
        } //switch code ends



    }

    void showSearch()
    {
        Console.WriteLine("                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                  ....................                                              \r\n                               ....-*@@@@@@@@@@@@@@@@%=:...                                         \r\n                            ..:+%@@@@@@@@@@@@@@@@@@@@@@@@@#-.....                                   \r\n                          .-*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%+:.......                             \r\n                       ..=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.....                             \r\n                     ..+@@@@@@@@@@@@@@@#=:.......-+%@@@@@@@@@@@@@@%:...                             \r\n                   ..=%@@@@@@@@@@@#=..................:+%@@@@@@@@@@@#:..                            \r\n                  ..*@@@@@@@@@@#:.........................=#@@@@@@@@@@=......                       \r\n                ..:%@@@@@@@@@+:.......:+++:. ...............-%@@@@@@@@@*.....                       \r\n               ..-%@@@@@@@@#.......=%@@@@@@. ............ ....-@@@@@@@@@#.....                      \r\n               .-%@@@@@@@@=......#@@@@@@@@*. ............  .....*@@@@@@@@*...                       \r\n               :#@@@@@@@%-.....+@@@@@@@@%=..                  ...*@@@@@@@@=..                       \r\n              .+@@@@@@@@-.....#@@@@@@@%=....                  ....*@@@@@@@@:.                       \r\n             ..@@@@@@@@=.....%@@@@@@*:.....                   .....%@@@@@@@*.                       \r\n             .+@@@@@@@#.....#@@@@@#:.......                   .....:@@@@@@@@.                       \r\n             .@@@@@@@@=.  .-@@@@@=.........                   ......#@@@@@@@-..                     \r\n             :@@@@@@@@-....#@@@@-..........                   ......+@@@@@@@#..                     \r\n             :@@@@@@@%-....#@@@+...........                   ......=@@@@@@@#.                      \r\n             :@@@@@@@%-....#@@*......                         ......=@@@@@@@#..                     \r\n             .@@@@@@@@-....#@%=......                         ......*@@@@@@@+..                     \r\n             .#@@@@@@@+....*@#.......                         .....:%@@@@@@@:.                      \r\n             .-@@@@@@@@:...:#:.......                         .....=@@@@@@@@.                       \r\n             ..%@@@@@@@%.......                               ....:@@@@@@@@=.                       \r\n               -@@@@@@@@*......                               ...:@@@@@@@@#:.                       \r\n               .+@@@@@@@@*....                                ..-%@@@@@@@%-..                       \r\n               ..*@@@@@@@@#:..                               ..=%@@@@@@@@=...                       \r\n                ..#@@@@@@@@@*...                           ..:%@@@@@@@@@-....                       \r\n                ...+@@@@@@@@@%+.......                  ...:#@@@@@@@@@@@%-..........                \r\n                ....-%@@@@@@@@@@#=......................:+%@@@@@@@@@@@@@@@#:........                \r\n                ......+@@@@@@@@@@@@%*=..............:+*%@@@@@@@@@@@@@@@@@@@@*.......                \r\n                ........+@@@@@@@@@@@@@@@%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@+....                 \r\n                ..........=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-...                \r\n                .............*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-:#@@@@@@@@@@@@@@@@@@-.......          \r\n                       .........=+%@@@@@@@@@@@@@@@@@@@@@#+:.....-%@@@@@@@@@@@@@@@@@#-.....          \r\n                       ..............:-=*#%@@@@@%#+--:............=@@@@@@@@@@@@@@@@@@#.....         \r\n                       ..................................  .........+@@@@@@@@@@@@@@@@@@*..          \r\n                                                       ..     ........*@@@@@@@@@@@@@@@@@*:          \r\n                                                              .........:*@@@@@@@@@@@@@@@@-          \r\n                                                              ...........-#@@@@@@@@@@@@@@-          \r\n                                                              .............-@@@@@@@@@@@@*:          \r\n                                                                     ........+%@@@@@@@@+..          \r\n                                                                     ..........-+***+-....          \r\n                                                                     .....................          \r\n                                                                     .....................          \r\n                                                                                                    \r\n                                                                                                    ");
        //shows magnifying glass
    }

}
        