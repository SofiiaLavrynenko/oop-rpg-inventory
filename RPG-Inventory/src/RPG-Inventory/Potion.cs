using System;

namespace RPG_Inventory;

public class Potion: Item
{
    public Potion(string title, double weight)
        : base(title, weight) {}

    public override void Use(Hero hero)
    {
        hero.Health = Math.Min(hero.Health + Bonus, hero.Health);
        hero.RemoveFromInventory(this);
    }

    public override string ToString()
    {
        return $"[{Rarity}] {Title} (weight: {Weight}, HP: +{Bonus})";
    }
}
