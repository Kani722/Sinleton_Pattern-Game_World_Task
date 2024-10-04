# GameWorld Singleton Pattern Example
This project demonstrates the Singleton Design Pattern in C#. The GameWorld class ensures that only one instance of the game world exists throughout the application, maintaining global state variables like a map, list of NPCs, time of day, and weather conditions. NPCs (Non-Player Characters) are dynamically added to the game world and their behavior can be customized.

## Overview
In this example, the game world maintains the following:

+ A 2D array representing the game map.
+ A list of NPCs, each with specific roles and behaviors.
+ Time of day and weather conditions, which can be updated to simulate changes in the game environment.

### Classes
1. GameWorld (Singleton)
The GameWorld class ensures that there is only one instance of the game world available. It manages:

+ WorldMap: A 50x50 map represented by a 2D array.
+ NPCs: A list of NPC objects.
+ TimeOfDay and WeatherCondition: Global game state variables that are modifiable and reflect the current game environment.
### Methods:

+ DisplayWorldState(): Displays the current state of the game, including time of day, weather conditions, and the count of NPCs.
2. NPC
The NPC class represents a Non-Player Character in the game. Each NPC has:

+ Name: The name of the NPC.
+ Role: The function or duty the NPC plays in the game world (e.g., Guard, Merchant).
+ Behavior: Describes the personality or actions of the NPC (e.g., Kind, Innocent).
### Methods:

+ DisplayNPCInfo(): Displays detailed information about the NPC.
3. Program
The Program class contains the Main method, where:

+ The game world is initialized using the Singleton pattern.
+ Time of day and weather are set.
+ NPCs are added to the game world.
+ The game world state and NPC details are printed to the console.

### How the Singleton Pattern is Implemented
The Singleton pattern is implemented in the GameWorld class:

+ A private static variable instance holds the single instance of the game world.
+ The constructor is private to prevent direct instantiation.
+ The Instance property ensures that the GameWorld is lazily initialized. If the instance doesn't exist, it creates one; otherwise, it returns the existing instance.
### Running the Example
1. Initialize the game world using GameWorld.Instance.
2. Set the global state variables (like time of day and weather condition).
3. Add NPCs to the game world with their roles and behaviors.
4. Display the current state of the game world and detailed information about each NPC.

### Benefits of Using Singleton Pattern
+ Ensures that only one instance of the GameWorld class exists.
+ Centralized control of global game states.
+ Simplifies the design by providing global access to the game world instance.
