using System;
using System.ComponentModel;

namespace RPG_Inventory;

public class Hero
{
    private Inventory<Item> _inventory;
    public string Name {get; private set;}
    public double Health {get; set;}
    public int Attack {get; set;}
    public int Defence {get; set;}

    public const double MaxHealth = 100;
    public const double DefaultInventoryCapacity = 15;

    public Hero(string name, double inventoryCapacity)
    {
        Name = name;
        Health = 100;
        Attack = Random.Shared.Next(10, 81);
        Defence = Random.Shared.Next(10, 81);

        _inventory = new Inventory<Item>(inventoryCapacity);
    }

    public Hero(string name) : this(name, DefaultInventoryCapacity) {}

    public void AddToInventory(Item item)
    {
        _inventory.Add(item);
    }

    public void RemoveFromInventory(Item item)
    {
        _inventory.Remove(item);
    }

    public void ShowInventory()
    {
        if (_inventory.Count() == 0)
        {
            System.Console.WriteLine($"{Name}'s inventory is empty.");
            return;
        }

        System.Console.WriteLine($"{Name}'s inventory:");
        foreach (var item in _inventory)
            System.Console.WriteLine(item);
    }

    public void ShowStats()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"HP: {Health} | ATK: {Attack} | DEF: {Defence}");
        System.Console.WriteLine($"Inventory capacity: {_inventory.Capacity}");
    }

    public void UseItem()
    {
        System.Console.WriteLine("What element do you want to use?");
                        
        var toUse = Console.ReadLine();

        Item? item = _inventory.GetByName(toUse);

        if (!_inventory.Contains(item))
        {
            System.Console.WriteLine($"No {item.Title} in {Name}'s inventory.");
            return;
        }

        item.Use(this);
    }
}
