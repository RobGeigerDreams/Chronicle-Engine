using ChronicleEngine.Rules;

namespace ChronicleEngine.Core;

public class SimulationEngine
{
    private readonly List<Rule> _rules;

    public SimulationEngine(List<Rule> rules)
    {
        _rules = rules;
    }

    public void Tick(WorldState state)
    {
        state.Tick++;

        foreach (var rule in _rules.OrderByDescending(r => r.Priority))
        {
            if (rule.Conditions.All(c => c.Evaluate(state)))
            {
                foreach (var action in rule.Actions)
                {
                    action.Execute(state);
                }
            }
        }
    }
}