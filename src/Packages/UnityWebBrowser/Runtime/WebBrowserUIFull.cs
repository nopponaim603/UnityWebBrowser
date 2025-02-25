using UnityEngine;
using UnityWebBrowser.Core;

namespace UnityWebBrowser
{
    /// <summary>
    ///     Full fat version of UWB, has fullscreen controls.
    /// </summary>
    [AddComponentMenu("UWB/Web Browser Full")]
    [HelpURL("https://github.com/Voltstro-Studios/UnityWebBrowser")]
    public sealed class WebBrowserUIFull : RawImageUwbClientInputHandler
    {
        public FullscreenHandler fullscreenHandler = new();

        protected override void OnStart()
        {
            base.OnStart();
            fullscreenHandler.graphicComponent = image;
            browserClient.OnFullscreen += fullscreenHandler.OnEngineFullscreen;
        }

        protected override void OnDestroyed()
        {
            base.OnDestroyed();
            browserClient.OnFullscreen -= fullscreenHandler.OnEngineFullscreen;
        }
    }
}