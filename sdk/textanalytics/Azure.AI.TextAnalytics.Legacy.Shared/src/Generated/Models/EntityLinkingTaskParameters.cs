// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.AI.TextAnalytics.Legacy;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The EntityLinkingTaskParameters. </summary>
    internal partial class EntityLinkingTaskParameters
    {
        /// <summary> Initializes a new instance of EntityLinkingTaskParameters. </summary>
        public EntityLinkingTaskParameters()
        {
        }

        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
