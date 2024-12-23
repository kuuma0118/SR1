using System;

namespace pj09_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.AddItem(new Item("つるはし"));
            player.AddItem(new Item("巻き物"));
            player.AddItem(new Item("ポーション"));

            player.UseItems();

            Console.ReadLine();
        }
    }
}
