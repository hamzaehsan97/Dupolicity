<<<<<<< HEAD
using System;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.TestRunner.TestLaunchers;

namespace UnityEditor.TestTools.TestRunner
{
    [Serializable]
    internal class RemoteTestResultReciever
    {
        public void RunStarted(MessageEventArgs messageEventArgs)
        {
        }

        public void RunFinished(MessageEventArgs messageEventArgs)
        {
            EditorConnection.instance.Send(PlayerConnectionMessageIds.quitPlayerMessageId, null, messageEventArgs.playerId);
            EditorConnection.instance.DisconnectAll();
        }
    }
}
=======
using System;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.TestRunner.TestLaunchers;

namespace UnityEditor.TestTools.TestRunner
{
    [Serializable]
    internal class RemoteTestResultReciever
    {
        public void RunStarted(MessageEventArgs messageEventArgs)
        {
        }

        public void RunFinished(MessageEventArgs messageEventArgs)
        {
            EditorConnection.instance.Send(PlayerConnectionMessageIds.quitPlayerMessageId, null, messageEventArgs.playerId);
            EditorConnection.instance.DisconnectAll();
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
