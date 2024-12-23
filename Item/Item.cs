using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Item
{
    // プライベートフィールド
    private string name;

    // コンストラクタ
    public Item(string name)
    {
        this.name = name;
    }

    // メソッド
    public void Use()
    {
        Console.WriteLine($"{name} を使用しました。");
    }
}

