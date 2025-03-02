// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubGcmCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(GcmEndpoint))
            {
                writer.WritePropertyName("gcmEndpoint");
                writer.WriteStringValue(GcmEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(GcmApiKey))
            {
                writer.WritePropertyName("googleApiKey");
                writer.WriteStringValue(GcmApiKey);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NotificationHubGcmCredential DeserializeNotificationHubGcmCredential(JsonElement element)
        {
            Optional<Uri> gcmEndpoint = default;
            Optional<string> googleApiKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("gcmEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gcmEndpoint = null;
                                continue;
                            }
                            gcmEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("googleApiKey"))
                        {
                            googleApiKey = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NotificationHubGcmCredential(gcmEndpoint.Value, googleApiKey.Value);
        }
    }
}
