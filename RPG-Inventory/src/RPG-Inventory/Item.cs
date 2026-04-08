using System;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;

namespace RPG_Inventory;

public abstract class Item: IComparable<Item>
{
    public string Title {get; protected set;}
    public double Weight {get; protected set;}
    public Rarity Rarity {get; protected set;}
    public int Bonus {get; protected set;}

    public Item(string title, double weight)
    {
        Title = title;
        Weight = weight;
        Rarity = (Rarity)Random.Shared.Next(0, 4);
        Bonus = Random.Shared.Next(10, 26);
    }

    public int CompareTo(Item? item)
    {
        if (item == null)
            return 1;
        
        var res = item.Rarity.CompareTo(Rarity);

        return res;
    }

    public abstract void Use(Hero hero);

    public override string ToString()
    {
        return $"[{Rarity}] {Title} (weight: {Weight})";
    }
}
