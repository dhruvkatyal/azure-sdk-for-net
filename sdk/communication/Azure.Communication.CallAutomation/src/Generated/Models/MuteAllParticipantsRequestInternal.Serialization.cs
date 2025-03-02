// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class MuteAllParticipantsRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext");
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(RequestInitiator))
            {
                writer.WritePropertyName("requestInitiator");
                writer.WriteObjectValue(RequestInitiator);
            }
            writer.WriteEndObject();
        }
    }
}
