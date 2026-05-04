using ChronicleEngine.Core;

namespace ChronicleEngine.Timeline;

public class Timeline
{
    public List<WorldState> History { get; set; } = new();

    public void Record(WorldState state)
    {
        History.Add(new WorldState
        {
            Tick = state.Tick,
            Mood = new MoodState
            {
                Tension = state.Mood.Tension,
                Absurdity = state.Mood.Absurdity,
                Decay = state.Mood.Decay
            },
            Factions = new Dictionary<string, float>(state.Factions),
            EventLog = new List<string>(state.EventLog)
        });
    }
}