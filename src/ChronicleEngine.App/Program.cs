﻿using ChronicleEngine.Core;
using ChronicleEngine.Rules;
using ChronicleEngine.Narrative;

var root = Directory.GetCurrentDirectory();
var path = Path.Combine(root, "src", "ChronicleEngine.Content", "world.json");
var world = WorldLoader.Load(path);

var engine = new SimulationEngine();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("\n--------------------");
    engine.Tick(world);
    var summary = engine.GetTurnSummary(world);
    Console.WriteLine(summary);
}
Console.WriteLine("\n=== Simulation Complete ===");