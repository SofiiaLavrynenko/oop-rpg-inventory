using System;
using System.Runtime.InteropServices.Marshalling;

namespace RPG_Inventory;

public abstract class Item
{
    public string Title {get; protected set;}
    public double Weight {get; protected set;}
    public Rarity Rarity {get; protected set;}

    public Item(string title, double weight)
    {
        Title = title;
        Weight = weight;
        Rarity = (Rarity)Random.Shared.Next(0, 4);
    }

    public abstract void Use();

    public override string ToString()
    {
        return $"Title: {Title} | Weight: {Weight} | Rarity: {Rarity}";
    }
}
