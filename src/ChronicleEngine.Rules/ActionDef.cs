using ChronicleEngine.Core;

namespace ChronicleEngine.Rules;

public class ActionDef
{
    public string Type { get; set; }
    public string Key { get; set; }
    public float Delta { get; set; }
    public string EventText { get; set; }

    public void Execute(WorldState state)
    {
        switch (Type)
        {
            case "modify_mood":
                if (Key == "tension") state.Mood.Tension += Delta;
                if (Key == "absurdity") state.Mood.Absurdity += Delta;
                if (Key == "decay") state.Mood.Decay += Delta;
                break;

            case "log_event":
                state.EventLog.Add(EventText);
                break;
        }
    }
}