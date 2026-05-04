namespace ChronicleEngine.Rules;

public class Rule
{
    public string Id { get; set; }
    public float Priority { get; set; }

    public List<Condition> Conditions { get; set; } = new();
    public List<ActionDef> Actions { get; set; } = new();
}