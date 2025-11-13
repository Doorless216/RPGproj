using System.Net.ServerSentEvents;

namespace RPGproj;

class Inventory
{
    public List<string> Items { get; set; }

    //constructor for new inventory
    public Inventory()
    {
        this.Items = new List<string>();
    }
    //Add and item
    public void AddItem(string item)
    {
        this.Items.Add(item);
    }
    //Remove an item
    public void RemoveItem(string item)
    {
        this.Items.Remove(item);
    }
    //Display the inventory for test purposes
    public void DisplayInventory()
    {
        Console.WriteLine("inventory: ");
        foreach (string item in Items)
        {
            Console.WriteLine(item);
        }
    }

}