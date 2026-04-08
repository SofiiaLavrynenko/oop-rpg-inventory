using System;

namespace RPG_Inventory;

public class Armor: Item
{
    public Armor(string title, double weight)
        : base(title, weight) {}

    public override void Use(Hero hero)
    {
        hero.Defence += Bonus;
    }

    public override string ToString()
    {
        return $"[{Rarity}] {Title} (weight: {Weight}, DEF: +{Bonus})";
    }
}
