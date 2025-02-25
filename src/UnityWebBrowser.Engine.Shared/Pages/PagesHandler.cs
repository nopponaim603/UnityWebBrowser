using System.IO;
using System.Reflection;

namespace UnityWebBrowser.Engine.Shared.Pages;

public static class PagesHandler
{
    private static readonly Assembly EngineSharedAssembly = typeof(PagesHandler).Assembly;

    public static Stream GetAboutPageCode()
    {
        Stream stream =
            EngineSharedAssembly.GetManifestResourceStream("UnityWebBrowser.Engine.Shared.Pages.About.html");
        return stream;
    }
}