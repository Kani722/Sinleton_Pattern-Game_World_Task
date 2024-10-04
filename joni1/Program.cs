using System;
using System.Collections.Generic;

public class GameWorld
{
	private static GameWorld instance;

	private GameWorld()
	{
		WorldMap = new string[50, 50];  
		NPCs = new List<NPC>();
		TimeOfDay = "Null";
		WeatherCondition = "Null";
	}

	public static GameWorld Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new GameWorld();
			}
			return instance;
		}
	}

	public string[,] WorldMap { get; private set; }

	public List<NPC> NPCs { get; private set; }

	public string TimeOfDay { get; set; }
	public string WeatherCondition { get; set; }

	// Display game state
	public void DisplayWorldState()
	{
		Console.WriteLine($"Time of Day: {TimeOfDay}");
		Console.WriteLine($"Weather Condition: {WeatherCondition}");
		Console.WriteLine($"NPC Count: {NPCs.Count}");
		Console.WriteLine();
	}
}

public class NPC
{
	public string Name { get; set; }
	public string Role { get; set; }
	public string Behavior { get; set; }

	public NPC(string name, string role, string behavior)
	{
		Name = name;
		Role = role;
		Behavior = behavior;
	}

	public void DisplayNPCInfo()
	{
		Console.WriteLine($"NPC Name: {Name}, Role: {Role}, Behavior: {Behavior}");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		GameWorld world = GameWorld.Instance;

		// Display the world state
		world.DisplayWorldState();

		// Modify game state
		world.TimeOfDay = "Night";
		world.WeatherCondition = "Rainy";

		// Add NPCs
		world.NPCs.Add(new NPC("Guard", "Protector", "Kind"));
		world.NPCs.Add(new NPC("Merchant", "Trader", "Innocent"));

		// Display the world state
		world.DisplayWorldState();

		// Display NPC info
		foreach (var npc in world.NPCs)
		{
			npc.DisplayNPCInfo();
		}
	}
}
