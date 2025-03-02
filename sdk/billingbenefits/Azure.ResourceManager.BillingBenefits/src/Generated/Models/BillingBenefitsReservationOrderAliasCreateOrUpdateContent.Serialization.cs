// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsReservationOrderAliasCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId");
                writer.WriteStringValue(BillingScopeId);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term");
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan");
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType");
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties");
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity");
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsDefined(IsRenewed))
            {
                writer.WritePropertyName("renew");
                writer.WriteBooleanValue(IsRenewed.Value);
            }
            if (Optional.IsDefined(ReservedResourceType))
            {
                writer.WritePropertyName("reservedResourceType");
                writer.WriteStringValue(ReservedResourceType.Value.ToString());
            }
            if (Optional.IsDefined(ReviewOn))
            {
                writer.WritePropertyName("reviewDateTime");
                writer.WriteStringValue(ReviewOn.Value, "O");
            }
            if (Optional.IsDefined(ReservedResourceProperties))
            {
                writer.WritePropertyName("reservedResourceProperties");
                writer.WriteObjectValue(ReservedResourceProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BillingBenefitsReservationOrderAliasCreateOrUpdateContent DeserializeBillingBenefitsReservationOrderAliasCreateOrUpdateContent(JsonElement element)
        {
            BillingBenefitsSku sku = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<ResourceIdentifier> billingScopeId = default;
            Optional<BillingBenefitsTerm> term = default;
            Optional<BillingBenefitsBillingPlan> billingPlan = default;
            Optional<BillingBenefitsAppliedScopeType> appliedScopeType = default;
            Optional<BillingBenefitsAppliedScopeProperties> appliedScopeProperties = default;
            Optional<int> quantity = default;
            Optional<bool> renew = default;
            Optional<BillingBenefitsReservedResourceType> reservedResourceType = default;
            Optional<DateTimeOffset> reviewDateTime = default;
            Optional<ReservationOrderAliasRequestPropertiesReservedResourceProperties> reservedResourceProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = BillingBenefitsSku.DeserializeBillingBenefitsSku(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingScopeId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("term"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            term = new BillingBenefitsTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingPlan = new BillingBenefitsBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            appliedScopeType = new BillingBenefitsAppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            appliedScopeProperties = BillingBenefitsAppliedScopeProperties.DeserializeBillingBenefitsAppliedScopeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("quantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quantity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("renew"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reservedResourceType = new BillingBenefitsReservedResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reviewDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reviewDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reservedResourceProperties = ReservationOrderAliasRequestPropertiesReservedResourceProperties.DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BillingBenefitsReservationOrderAliasCreateOrUpdateContent(id, name, type, systemData.Value, sku, Optional.ToNullable(location), displayName.Value, billingScopeId.Value, Optional.ToNullable(term), Optional.ToNullable(billingPlan), Optional.ToNullable(appliedScopeType), appliedScopeProperties.Value, Optional.ToNullable(quantity), Optional.ToNullable(renew), Optional.ToNullable(reservedResourceType), Optional.ToNullable(reviewDateTime), reservedResourceProperties.Value);
        }
    }
}
