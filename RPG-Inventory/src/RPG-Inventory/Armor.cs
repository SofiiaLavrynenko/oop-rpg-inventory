using System;

namespace RPG_Inventory;

public class Armor: Item
{
    public Armor(string title, double weight)
        : base(title, weight) {}

    public override void Use()
    {
        //
    }

    public override string ToString()
    {
        return $"[{Rarity}] {Title} (weight: {Weight}, DEF: +{Bonus})";
    }
}
