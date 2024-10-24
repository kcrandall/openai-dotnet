// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeRequestResponseCancelCommand : InternalRealtimeRequestCommand
    {
        public InternalRealtimeRequestResponseCancelCommand()
        {
            Kind = InternalRealtimeRequestCommandType.ResponseCancel;
        }

        internal InternalRealtimeRequestResponseCancelCommand(InternalRealtimeRequestCommandType kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, eventId, serializedAdditionalRawData)
        {
        }
    }
}