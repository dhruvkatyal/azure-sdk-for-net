// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list of pipeline resources. </summary>
    internal partial class FactoryPipelineListResult
    {
        /// <summary> Initializes a new instance of FactoryPipelineListResult. </summary>
        /// <param name="value"> List of pipelines. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal FactoryPipelineListResult(IEnumerable<FactoryPipelineData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of FactoryPipelineListResult. </summary>
        /// <param name="value"> List of pipelines. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal FactoryPipelineListResult(IReadOnlyList<FactoryPipelineData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of pipelines. </summary>
        public IReadOnlyList<FactoryPipelineData> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
