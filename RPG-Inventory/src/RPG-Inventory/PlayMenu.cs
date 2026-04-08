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

        System.Console.WriteLine("Welcome to RPG-Inventory");

        while (isRunning)
        {
            System.Console.WriteLine("What do you want to do?");
            System.Console.WriteLine("1 - see hero's inventory");
            System.Console.WriteLine("2 - use item");
            System.Console.WriteLine("3 - sort hero's inventory");
            System.Console.WriteLine("4 - see hero's stats");
            System.Console.WriteLine("5 - exit");
            System.Console.WriteLine();

            var input = Console.ReadLine();
            System.Console.WriteLine();

            switch (input)
            {
                case "1": _hero.ShowInventory(); break;
                case "2": _hero.UseItem(); break;
                case "3": _hero.ShowSortedInventory(); break;
                case "4": _hero.ShowStats(); break;
                case "5": isRunning = false; break;
                default: System.Console.WriteLine("Wrong input."); break;
            }
            
            System.Console.WriteLine();
        }
    }

}
