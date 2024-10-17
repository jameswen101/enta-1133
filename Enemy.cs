using System;

public class Enemy : Player
{
	public String asciiArt;
	public Enemy(String name) : base(name)
	{
		this.name = name;
	}

	public void enemyIsDead()
	{
		if (health <= 0)
		{
			if (health < 0)
			{
				health = 0;
			}
			Console.WriteLine("                  _  /)\r\n                 mo / )\r\n                 |/)\\)\r\n                  /\\_\r\n                  \\__|=\r\n                 (    )\r\n                 __)(__\r\n           _____/      \\\\_____\r\n          |                  ||\r\n          |  _     ___   _   ||\r\n          | | \\     |   | \\  ||\r\n          | |  |    |   |  | ||\r\n          | |_/     |   |_/  ||\r\n          | | \\     |   |    ||\r\n          | |  \\    |   |    ||\r\n          | |   \\. _|_. | .  ||\r\n          |                  ||\r\n  *       | *   **    * **   |**      **\r\n   \\))ejm96/.,(//,,..,,\\||(,,.,\\\\,.((//\r\n");
			//Show picture of tombstone
			Console.WriteLine($"The {name}'s health is currently at {health} and is already dead. Keep fighting other apex predators before cooking them for dinner!");
		}
	}

}
