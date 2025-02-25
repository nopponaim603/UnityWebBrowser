using UnityEngine;
using UnityWebBrowser.Communication.Pipes.Base;
using VoltRpc.Communication;

namespace UnityWebBrowser.Communication.Pipes
{
    /// <summary>
    ///     <see cref="CommunicationLayer"/> using <see cref="PipesHost"/> and <see cref="PipesClient"/>
    /// </summary>
    [CreateAssetMenu(fileName = "Pipes Communication Layer", menuName = "UWB/Pipes Communication Layer")]
    public sealed class PipesCommunicationLayer : CommunicationLayer
    {
        /// <summary>
        ///     What pipe name to communicate in
        /// </summary>
        public string inPipeName = "UnityWebBrowserIn";
        
        /// <summary>
        ///     What pipe name to communicate out
        /// </summary>
        public string outPipeName = "UnityWebBrowserOut";

        public override Client CreateClient()
        {
            return new PipesClient(inPipeName, connectionTimeout, Client.DefaultBufferSize);
        }

        public override Host CreateHost()
        {
            return new PipesHost(outPipeName);
        }

        public override void GetIpcSettings(out object outLocation, out object inLocation, out string assemblyLocation)
        {
            outLocation = outPipeName;
            inLocation = inPipeName;
            assemblyLocation = typeof(EnginePipesCommunicationLayer).Assembly.Location;
        }
    }
}