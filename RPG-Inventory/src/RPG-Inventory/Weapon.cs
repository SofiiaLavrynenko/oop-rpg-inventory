using System;

namespace RPG_Inventory;

public class Weapon: Item
{
    public Weapon(string title, double weight)
        : base(title, weight) {}

    public override void Use()
    {
        //
    }
}
