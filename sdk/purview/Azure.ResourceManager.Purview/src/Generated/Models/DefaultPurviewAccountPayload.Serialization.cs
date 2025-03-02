// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class DefaultPurviewAccountPayload : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName");
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName");
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ScopeTenantId))
            {
                writer.WritePropertyName("scopeTenantId");
                writer.WriteStringValue(ScopeTenantId.Value);
            }
            if (Optional.IsDefined(ScopeType))
            {
                writer.WritePropertyName("scopeType");
                writer.WriteStringValue(ScopeType.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId");
                writer.WriteStringValue(SubscriptionId);
            }
            writer.WriteEndObject();
        }

        internal static DefaultPurviewAccountPayload DeserializeDefaultPurviewAccountPayload(JsonElement element)
        {
            Optional<string> accountName = default;
            Optional<string> resourceGroupName = default;
            Optional<string> scope = default;
            Optional<Guid> scopeTenantId = default;
            Optional<PurviewAccountScopeType> scopeType = default;
            Optional<string> subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopeTenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scopeTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scopeType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scopeType = new PurviewAccountScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new DefaultPurviewAccountPayload(accountName.Value, resourceGroupName.Value, scope.Value, Optional.ToNullable(scopeTenantId), Optional.ToNullable(scopeType), subscriptionId.Value);
        }
    }
}
