using System;

public class User: Player
{
    public List<Item> ItemInventory = new List<Item>();
    public bool noItems = true;
    public User(String name): base(name)
	{
	}
}
