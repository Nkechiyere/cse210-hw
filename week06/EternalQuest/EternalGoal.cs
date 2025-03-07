namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
    
        }

        public override bool IsComplete()
        {
            return false; // Eternal goals are never complete
        }

        public override string GetDetailsString()
        {
            return $"{_shortName} - {_description} - Points: {_points}";
        }

        public override string GetStringRepresentation()
        {
            return $"Eternal,{_shortName},{_description},{_points}";
        }
    }
}