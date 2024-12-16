namespace game
{
    public class NPC
    {
        public string Name { get; }
        public string Dialog { get; set; }
        public List<Quest> Quests { get; }

        public NPC(string name)
        {
            Name = name;
            Quests = new List<Quest>();
        }

        public void Talk()
        {
            Console.WriteLine($"{Name} says: {Dialog}");
        }

        public void GiveQuest(Quest quest)
        {
            Quests.Add(quest);
            Console.WriteLine($"{Name} has given you a quest: {quest.Title}");
        }
    }
}
