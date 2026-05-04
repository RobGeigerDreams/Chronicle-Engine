﻿using ChronicleEngine.Core;
using ChronicleEngine.Rules;
using ChronicleEngine.Narrative;

var world = WorldLoader.Load("content/world.json");

var rules = new List<Rule>
{
    new Rule
    {
        Id = "goblin_unrest",
        Priority = 0.7f,
        Conditions =
        {
            new Condition { Type = "mood", Key = "tension", GreaterThan = 0.5f }
        },
        Actions =
        {
            new ActionDef
            {
                Type = "log_event",
                EventText = "Goblin workers quietly refuse assignments."
            },
            new ActionDef
            {
                Type = "modify_mood",
                Key = "tension",
                Delta = 0.05f
            }
        }
    }
};

var engine = new SimulationEngine(rules);

for (int i = 0; i < 20; i++)
{
    engine.Tick(world);
}

var narrative = NarrativeSystem.Generate(world);

Console.WriteLine(narrative);