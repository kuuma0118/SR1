using System;

namespace pj09_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Itemクラスのインスタンスを作成
            Item item = new Item("つるはし");

            // Useメソッドを呼び出し
            item.Use();

            Console.ReadLine();
        }
    }

}