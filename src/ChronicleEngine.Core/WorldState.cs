namespace ChronicleEngine.Core;

public class WorldState
{
    public int Tick { get; set; }

    public MoodState Mood { get; set; } = new();
    public Dictionary<string, float> Factions { get; set; } = new();

    public List<string> EventLog { get; set; } = new();
}
