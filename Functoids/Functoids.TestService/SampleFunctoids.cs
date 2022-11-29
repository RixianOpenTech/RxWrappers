using Functoids.Common;

namespace Functoids.TestService;

public static partial class SampleFunctoids
{
    [Functoid]
    public static int Add(int x, int y)
    {
        return x + y;
    }

    [Functoid]
    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    // ========================
    // Sync
    // ========================
    [Functoid]
    public static int MulitipleParam_SingleReturn_Sync(int x, int y)
    {
        return x + y;
    }

    [Functoid]
    public static int SingleParam_SingleReturn_Sync(int x)
    {
        return 2 * x;
    }

    [Functoid]
    public static int ZeroParam_SingleReturn_Sync()
    {
        return 42;
    }

    [Functoid]
    public static (int a, int b) MulitipleParam_MulitipleReturn_Sync(int x, int y)
    {
        return (x, y);
    }

    [Functoid]
    public static (int a, int b) SingleParam_MulitipleReturn_Sync(int x)
    {
        return (1 * x, 2 * x);
    }

    [Functoid]
    public static (int a, int b) ZeroParam_MulitipleReturn_Sync()
    {
        return (1, 2);
    }

    [Functoid]
    public static void MulitipleParam_ZeroReturn_Sync(int x, int y)
    {
        Console.WriteLine($"[MulitipleParam_ZeroReturn_Sync](x: {x}, y: {y}) Executed");
    }

    [Functoid]
    public static void SingleParam_ZeroReturn_Sync(int x)
    {
        Console.WriteLine($"[SingleParam_ZeroReturn_Sync](x: {x}) Executed");
    }

    [Functoid]
    public static void ZeroParam_ZeroReturn_Sync()
    {
        Console.WriteLine($"[ZeroParam_ZeroReturn_Sync] Executed");
    }

    // ========================
    // Async
    // ========================
    [Functoid]
    public static async Task<int>? MulitipleParam_SingleReturn_Async(int x, int y)
    {
        return x + y;
    }

    [Functoid]
    public static async Task<int>? SingleParam_SingleReturn_Async(int x)
    {
        return 2 * x;
    }

    [Functoid]
    public static async Task<int>? ZeroParam_SingleReturn_Async()
    {
        return 42;
    }

    [Functoid]
    public static async Task<(int a, int b)>? MulitipleParam_MulitipleReturn_Async(int x, int y)
    {
        return (x, y);
    }

    [Functoid]
    public static async Task<(int a, int b)>? SingleParam_MulitipleReturn_Async(int x)
    {
        return (1 * x, 2 * x);
    }

    [Functoid]
    public static async Task<(int a, int b)>? ZeroParam_MulitipleReturn_Async()
    {
        return (1, 2);
    }

    [Functoid]
    public static async Task? MulitipleParam_ZeroReturn_Async(int x, int y)
    {
        Console.WriteLine($"[MulitipleParam_ZeroReturn_Async](x: {x}, y: {y}) Executed");
    }

    [Functoid]
    public static async Task? SingleParam_ZeroReturn_Async(int x)
    {
        Console.WriteLine($"[SingleParam_ZeroReturn_Async](x: {x}) Executed");
    }

    [Functoid]
    public static async Task? ZeroParam_ZeroReturn_Async()
    {
        Console.WriteLine($"[ZeroParam_ZeroReturn_Async] Executed");
    }
}
