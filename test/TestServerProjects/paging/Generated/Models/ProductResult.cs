// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace paging.Models
{
    /// <summary> The ProductResult. </summary>
    public partial class ProductResult
    {
        /// <summary> Initializes a new instance of ProductResult. </summary>
        internal ProductResult()
        {
        }

        /// <summary> Initializes a new instance of ProductResult. </summary>
        /// <param name="values"> . </param>
        /// <param name="nextLink"> . </param>
        internal ProductResult(IList<Product> values, string nextLink)
        {
            Values = values;
            NextLink = nextLink;
        }

        public IList<Product> Values { get; internal set; }
        public string NextLink { get; internal set; }
    }
}
