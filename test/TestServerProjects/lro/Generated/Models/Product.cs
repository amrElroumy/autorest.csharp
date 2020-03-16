// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace lro.Models
{
    /// <summary> The Product. </summary>
    public partial class Product : Resource
    {
        /// <summary> Initializes a new instance of Product. </summary>
        public Product()
        {
        }

        /// <summary> Initializes a new instance of Product. </summary>
        /// <param name="provisioningState"> . </param>
        /// <param name="provisioningStateValues"> . </param>
        /// <param name="id"> Resource Id. </param>
        /// <param name="type"> Resource Type. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="name"> Resource Name. </param>
        internal Product(string provisioningState, ProductPropertiesProvisioningStateValues? provisioningStateValues, string id, string type, IDictionary<string, string> tags, string location, string name) : base(id, type, tags, location, name)
        {
            ProvisioningState = provisioningState;
            ProvisioningStateValues = provisioningStateValues;
        }

        public string ProvisioningState { get; set; }
        public ProductPropertiesProvisioningStateValues? ProvisioningStateValues { get; internal set; }
    }
}
