public class QuestManager
{
    private List<Quest> activeQuests = new List<Quest>();

    public void AddQuest(Quest quest)
    {
        activeQuests.Add(quest);
        Console.WriteLine($"New quest accepted: {quest.Title} - {quest.Description}");
    }

    public void CompleteQuest(string questTitle)
    {
        var quest = activeQuests.FirstOrDefault(q => q.Title == questTitle && !q.IsCompleted);
        if (quest != null)
        {
            quest.IsCompleted = true;
            Console.WriteLine($"{quest.Title} has been completed! Reward: {quest.RewardDescription}");
            ApplyQuestReward(quest);
        }
    }

    private void ApplyQuestReward(Quest quest)
    {
        // Implement rewards logic based on the quest specifics
    }
}

public class Quest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public string RewardDescription { get; set; }

    public Quest(string title, string description, string rewardDescription)
    {
        Title = title;
        Description = description;
        RewardDescription = rewardDescription;
        IsCompleted = false;
    }
}
