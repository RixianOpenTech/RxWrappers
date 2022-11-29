using Functoids.Common;

namespace Functoids.Blobs;
public static partial class BLobFunctoids
{
    [Functoid]
    public static string ReadFileAsText(string path)
    {
        return File.ReadAllText(path);
    }
}
