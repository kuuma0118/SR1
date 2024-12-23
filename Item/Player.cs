using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Player
{
    // プライベートフィールド
    private Item item;

    // コンストラクタ
    public Player(Item item)
    {
        this.item = item;
    }

    // メソッド
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
        else
        {
            Console.WriteLine("アイテムを持っていません。");
        }
    }
}

