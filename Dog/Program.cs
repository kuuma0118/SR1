﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog pochi = new Dog();

            Console.WriteLine("空腹状態 : {0}", pochi.IsHungty());

            pochi.Eat();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungty());

            pochi.Run();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungty());

            Console.ReadLine();
        }
    }
}
