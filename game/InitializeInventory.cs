private static void InitializeInventory(Inventory inventory)
{
    var healthPotion = ItemsFactory.CreateItem("HealthPotion");
    var damagePotion = ItemsFactory.CreateItem("DamagePotion");
    inventory.AddItem(healthPotion);
    inventory.AddItem(damagePotion);
}
