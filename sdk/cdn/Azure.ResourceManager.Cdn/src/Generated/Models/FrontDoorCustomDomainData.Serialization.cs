// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorCustomDomainData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TlsSettings))
            {
                writer.WritePropertyName("tlsSettings");
                writer.WriteObjectValue(TlsSettings);
            }
            if (Optional.IsDefined(DnsZone))
            {
                writer.WritePropertyName("azureDnsZone");
                JsonSerializer.Serialize(writer, DnsZone);
            }
            if (Optional.IsDefined(PreValidatedCustomDomainResource))
            {
                if (PreValidatedCustomDomainResource != null)
                {
                    writer.WritePropertyName("preValidatedCustomDomainResourceId");
                    writer.WriteObjectValue(PreValidatedCustomDomainResource);
                }
                else
                {
                    writer.WriteNull("preValidatedCustomDomainResourceId");
                }
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontDoorCustomDomainData DeserializeFrontDoorCustomDomainData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> profileName = default;
            Optional<FrontDoorCustomDomainHttpsContent> tlsSettings = default;
            Optional<WritableSubResource> azureDnsZone = default;
            Optional<FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId> preValidatedCustomDomainResourceId = default;
            Optional<FrontDoorProvisioningState> provisioningState = default;
            Optional<FrontDoorDeploymentStatus> deploymentStatus = default;
            Optional<DomainValidationState> domainValidationState = default;
            Optional<string> hostName = default;
            Optional<DomainValidationProperties> validationProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("profileName"))
                        {
                            profileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tlsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tlsSettings = FrontDoorCustomDomainHttpsContent.DeserializeFrontDoorCustomDomainHttpsContent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureDnsZone"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureDnsZone = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("preValidatedCustomDomainResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                preValidatedCustomDomainResourceId = null;
                                continue;
                            }
                            preValidatedCustomDomainResourceId = FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId.DeserializeFrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new FrontDoorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentStatus = new FrontDoorDeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("domainValidationState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            domainValidationState = new DomainValidationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validationProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validationProperties = DomainValidationProperties.DeserializeDomainValidationProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FrontDoorCustomDomainData(id, name, type, systemData.Value, profileName.Value, tlsSettings.Value, azureDnsZone, preValidatedCustomDomainResourceId.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus), Optional.ToNullable(domainValidationState), hostName.Value, validationProperties.Value);
        }
    }
}
