using System;

namespace RPG_Inventory;

public class Weapon: Item
{
    public Weapon(string title, double weight)
        : base(title, weight) {}

    public override void Use(Hero hero)
    {
        hero.Attack += Bonus;
        System.Console.WriteLine($"ATK: +{Bonus}");
    }

    public override string ToString()
    {
        return $"[{Rarity}] {Title} (weight: {Weight}, ATK: +{Bonus})";
    }
}
