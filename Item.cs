using System;

public abstract class Item
{
	public String itemName;
	public int row, column;
	public String description;
	public String asciiArt;

	public abstract void useItem(User user, Enemy enemy);

	public Item(String itemName)
	{
		this.itemName = itemName;
	}
}
