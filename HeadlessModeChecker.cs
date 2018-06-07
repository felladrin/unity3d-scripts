public static class HeadlessModeChecker
{
    public static bool IsInHeadlessMode()
    {
        var condition1 = System.Environment.CommandLine.Contains("-batchmode");
        var condition2 = System.Environment.CommandLine.Contains("-nographics");
        var condition3 = (UnityEngine.SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Null);
        return (condition1 || condition2 || condition3);
    }
}
