// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Response from a List Indexers request. If successful, it includes the full definitions of all indexers. </summary>
    public partial class ListIndexersResult
    {
        /// <summary> Initializes a new instance of ListIndexersResult. </summary>
        internal ListIndexersResult()
        {
        }

        /// <summary> Initializes a new instance of ListIndexersResult. </summary>
        /// <param name="indexers"> The indexers in the Search service. </param>
        internal ListIndexersResult(IList<Indexer> indexers)
        {
            Indexers = indexers;
        }

        /// <summary> The indexers in the Search service. </summary>
        public IList<Indexer> Indexers { get; internal set; }
    }
}
