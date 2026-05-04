using System.Text.Json;

namespace ChronicleEngine.Core;

public static class WorldLoader
{
    public static WorldState Load(string path)
    {
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<WorldState>(json)!;
    }
}