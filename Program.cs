namespace RPGproj;

class Program
{
    static void Main(string[] args)
    {
        player player = new player("gabe", 100);
        player.Inventory = new Inventory();

        player.Inventory.AddItem("sword");

        player.DisplayPlayerInfo();
        player.Inventory.RemoveItem("sword");
        player.DisplayPlayerInfo();
    }
}
