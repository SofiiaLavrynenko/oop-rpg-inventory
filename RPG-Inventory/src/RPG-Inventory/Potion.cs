using System;

namespace RPG_Inventory;

public class Potion: Item
{
    public Potion(string title, double weight)
        : base(title, weight) {}

    public override void Use()
    {
        //
    }
}
