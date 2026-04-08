using System;
using System.ComponentModel;

namespace RPG_Inventory;

public class Hero
{
    private Inventory<Item> _inventory;
    public string Name {get; protected set;}
    public double Health {get; protected set;}
    public int Attack {get; protected set;}
    public int Defence {get; protected set;}

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
}
