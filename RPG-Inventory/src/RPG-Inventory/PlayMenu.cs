using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace RPG_Inventory;

public class PlayMenu
{
    private Hero _hero;

    public PlayMenu(Hero hero)
    {
        _hero = hero;
    }

    public void Play()
    {
        var isRunning = true;

        while (isRunning)
        {
            System.Console.WriteLine("OOP RPG-Inventory!");
            System.Console.WriteLine("What do you want to do?");
            System.Console.WriteLine("1 - see hero's inventory");
            System.Console.WriteLine("2 - use item");
            System.Console.WriteLine("3 - sort hero's inventory");
            System.Console.WriteLine("4 - see hero's stats");
            System.Console.WriteLine("5 - exit");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1": _hero.ShowInventory(); break;
                case "2": _hero.UseItem(); break;
            }
        }
    }

}
