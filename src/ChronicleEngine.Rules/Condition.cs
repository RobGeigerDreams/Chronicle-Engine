using ChronicleEngine.Core;

namespace ChronicleEngine.Rules;

public class Condition
{
    public string Type { get; set; } // "mood" or "faction"
    public string Key { get; set; }
    public float GreaterThan { get; set; }

    public bool Evaluate(WorldState state)
    {
        if (Type == "mood")
        {
            return Key switch
            {
                "tension" => state.Mood.Tension > GreaterThan,
                "absurdity" => state.Mood.Absurdity > GreaterThan,
                "decay" => state.Mood.Decay > GreaterThan,
                _ => false
            };
        }

        if (Type == "faction")
        {
            return state.Factions.TryGetValue(Key, out var val) && val > GreaterThan;
        }

        return false;
    }
}