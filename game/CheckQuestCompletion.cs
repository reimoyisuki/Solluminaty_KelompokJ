public static void CheckQuestCompletion(Character hero, QuestManager questManager)
{
    // Example of checking quest conditions
    if (hero.Inventory.HasItem("Mystic Herb") && hero.Inventory.HasItem("Dragonroot"))
    {
        questManager.CompleteQuest("The Herbalist’s Request");
    }
}

// In your game loop or event handling
if (currentEvent == "Found Mystic Herb")
{
    hero.Inventory.AddItem("Mystic Herb");
    Console.WriteLine("Mystic Herb found and added to inventory.");
    CheckQuestCompletion(hero, questManager);
}
