using System.Text.Json;
using System.Text.Json.Nodes;

namespace Functoids.Common;

public sealed class FileObservableLoader<T> : ObservableLoader<T>
{
    private readonly string path;

    public FileObservableLoader(string filename)
    {
        path = Path.Combine(@"C:\temp\Functoids\demo", filename);
    }

    protected override async ValueTask<bool> HasValue()
    {
        return File.Exists(path);
    }

    protected override async Task<T> ReadLatestAsync()
    {
        return JsonNode.Parse(File.ReadAllText(path)).Deserialize<T>();
    }

    protected override async Task SaveValueAsync(T value)
    {
        File.WriteAllText(path, JsonSerializer.SerializeToNode(value).ToJsonString());
    }
}