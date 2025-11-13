using System.Net.ServerSentEvents;

namespace RPGproj;

class player
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Inventory Inventory { get; set; }

    // Constructor for player class
    public player(string name, int health)
    {
        this.Name = name;
        this.Health = health;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player health: {Health}");
        Console.WriteLine($"Player name: {Name}");
        Console.WriteLine("Player inventory: ");
        Inventory.DisplayInventory();
    }



}
