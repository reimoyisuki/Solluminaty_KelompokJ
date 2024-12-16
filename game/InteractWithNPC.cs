public void InteractWithNPC(NPC npc, Character hero, QuestManager questManager)
{
    Console.WriteLine($"{npc.Name} says: {npc.Dialog}");
    if (npc.Quests.Count > 0)
    {
        foreach (var quest in npc.Quests)
        {
            if (!quest.IsCompleted)
            {
                Console.WriteLine($"{npc.Name} has a quest for you: {quest.Description}");
                questManager.AddQuest(quest);  // Add quest to quest manager
                Console.WriteLine($"You have accepted the quest: {quest.Title}");
            }
        }
    }
}
