using ChronicleEngine.Core;

namespace ChronicleEngine.Rules;

public class SimulationEngine()
{
    private int _turn = 0;
    
    public void Tick(WorldState world)
    {
        world.Tick++;
        _turn++;

        world.Mood.Tension += 0.05f;
        world.Mood.Absurdity += 0.02f;

        world.Mood.Tension = Math.Clamp(world.Mood.Tension, 0, 1);
        world.Mood.Absurdity = Math.Clamp(world.Mood.Absurdity, 0, 1);
    }

    public string GetTurnSummary(WorldState world)
    {
        return $"Turn {_turn} | Tension={world.Mood.Tension:0.00} | Absurdity={world.Mood.Absurdity:0.00}";
    }
}