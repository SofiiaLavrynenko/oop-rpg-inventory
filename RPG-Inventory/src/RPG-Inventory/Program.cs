using RPG_Inventory;

var hero = new Hero("Kaelen Ashfall", 30);

var weaponOne = new Weapon("Star-Fall Bow", 1.5);
var weaponTwo = new Weapon("Widow’s Sting", 0.5);

var armorOne = new Armor("Whisper-Stalk Wraps", 2);
var armorTwo = new Armor("Void-Stitch Robes", 2.5);

var potionOne = new Potion("Essence of Phoenix Bloom", 0.5);
var potionTwo = new Potion("The Alchemist’s Miracle", 0.5);

hero.AddToInventory(weaponOne);
hero.AddToInventory(armorOne);
hero.AddToInventory(potionOne);

var menu = new PlayMenu(hero);

menu.Play();