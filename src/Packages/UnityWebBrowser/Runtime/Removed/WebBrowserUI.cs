#if UNITY_EDITOR

using System;
using System.ComponentModel;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace UnityWebBrowser
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("The WebBrowserUI is Obsolete now! Use WebBrowserUIBasic or WebBrowserUIFull.", true)]
    [HelpURL("https://github.com/Voltstro-Studios/UnityWebBrowser")]
    public sealed class WebBrowserUI : MonoBehaviour
    {
        private void Start()
        {
            Debug.LogError("You need to upgrade to the new WebBrowserUIBasic or WebBrowserUIFull script!");
        }
    }
}

#endif