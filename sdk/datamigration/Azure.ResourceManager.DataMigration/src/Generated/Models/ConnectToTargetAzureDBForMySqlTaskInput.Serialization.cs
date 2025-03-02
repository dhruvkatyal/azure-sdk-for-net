// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetAzureDBForMySqlTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            if (Optional.IsDefined(IsOfflineMigration))
            {
                writer.WritePropertyName("isOfflineMigration");
                writer.WriteBooleanValue(IsOfflineMigration.Value);
            }
            writer.WriteEndObject();
        }

        internal static ConnectToTargetAzureDBForMySqlTaskInput DeserializeConnectToTargetAzureDBForMySqlTaskInput(JsonElement element)
        {
            MySqlConnectionInfo sourceConnectionInfo = default;
            MySqlConnectionInfo targetConnectionInfo = default;
            Optional<bool> isOfflineMigration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("isOfflineMigration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOfflineMigration = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ConnectToTargetAzureDBForMySqlTaskInput(sourceConnectionInfo, targetConnectionInfo, Optional.ToNullable(isOfflineMigration));
        }
    }
}
