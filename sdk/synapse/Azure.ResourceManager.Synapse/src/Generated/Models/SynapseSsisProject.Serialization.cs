// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisProject
    {
        internal static SynapseSsisProject DeserializeSynapseSsisProject(JsonElement element)
        {
            Optional<long> folderId = default;
            Optional<long> version = default;
            Optional<IReadOnlyList<SynapseSsisEnvironmentReference>> environmentRefs = default;
            Optional<IReadOnlyList<SynapseSsisParameter>> parameters = default;
            SynapseSsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("environmentRefs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SynapseSsisEnvironmentReference> array = new List<SynapseSsisEnvironmentReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisEnvironmentReference.DeserializeSynapseSsisEnvironmentReference(item));
                    }
                    environmentRefs = array;
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SynapseSsisParameter> array = new List<SynapseSsisParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisParameter.DeserializeSynapseSsisParameter(item));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SynapseSsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseSsisProject(type, Optional.ToNullable(id), name.Value, description.Value, Optional.ToNullable(folderId), Optional.ToNullable(version), Optional.ToList(environmentRefs), Optional.ToList(parameters));
        }
    }
}
