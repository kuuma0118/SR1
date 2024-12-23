using System;

namespace pj09_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Playerクラスのインスタンスを生成し、Itemクラスのインスタンスを渡す
            Player player = new Player(new Item("こん棒"));

            // UseItemメソッドを呼び出し
            player.UseItem();

            // コンソールがすぐ閉じないようにする
            Console.ReadLine();
        }
    }

}