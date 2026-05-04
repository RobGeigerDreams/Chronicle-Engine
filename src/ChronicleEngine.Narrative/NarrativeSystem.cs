using ChronicleEngine.Core;

namespace ChronicleEngine.Narrative;

public static class NarrativeSystem
{
    public static string Generate(WorldState state)
    {
        var lines = new List<string>();

        lines.Add($"Day {state.Tick} | State: {DescribeState(state)}");
        lines.Add("");

        var grouped = state.EventLog
            .GroupBy(e => e)
            .OrderByDescending(g => g.Count());

        foreach (var group in grouped.Take(3))
        {
            lines.Add(group.Key);
        }

        return string.Join("\n", lines);
    }

    private static string DescribeState(WorldState state)
    {
        if (state.Mood.Tension > 0.7f) return "Controlled Chaos";
        if (state.Mood.Tension > 0.5f) return "Uneasy Order";
        return "Stable";
    }
}