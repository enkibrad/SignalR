using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNet.SignalR.Messaging;

namespace Microsoft.AspNet.SignalR.Infrastructure
{
    public class AckSubscriber : ISubscriber
    {
        public AckSubscriber(string connectionId)
        {
            EventKeys = new[] {
                PrefixHelper.GetConnectionId(connectionId),
                PrefixHelper.GetAck(connectionId)
            };

            Identity = "ack-" + connectionId;
        }

        public IList<string> EventKeys { get; private set; }

        public Action<TextWriter> WriteCursor { get; set; }

        public string Identity { get; private set; }

        public event Action<ISubscriber, string> EventKeyAdded
        {
            add { }
            remove { }
        }

        public event Action<ISubscriber, string> EventKeyRemoved
        {
            add { }
            remove { }
        }

        public Subscription Subscription { get; set; }
    }
}
