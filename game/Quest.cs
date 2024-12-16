namespace game
{
    public class Quest
    {
        public string Title { get; }
        public string Description { get; }
        public bool IsCompleted { get; private set; }

        public Quest(string title, string description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        public void CompleteQuest()
        {
            IsCompleted = true;
            Console.WriteLine($"Quest '{Title}' completed!");
        }
    }

    public class QuestManager
    {
        private List<Quest> quests = new List<Quest>();

        public void AddQuest(Quest quest)
        {
            quests.Add(quest);
            Console.WriteLine($"Quest '{quest.Title}' added.");
        }

        public void CompleteQuest(string title)
        {
            var quest = quests.FirstOrDefault(q => q.Title == title);
            if (quest != null && !quest.IsCompleted)
            {
                quest.CompleteQuest();
            }
        }

        public void ShowQuests()
        {
            foreach (var quest in quests)
            {
                string status = quest.IsCompleted ? "Completed" : "Active";
                Console.WriteLine($"Quest: {quest.Title} - {status}");
            }
        }
    }
}
