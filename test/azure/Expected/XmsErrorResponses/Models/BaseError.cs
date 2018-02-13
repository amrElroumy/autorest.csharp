// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.XmsErrorResponses.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BaseError
    {
        /// <summary>
        /// Initializes a new instance of the BaseError class.
        /// </summary>
        public BaseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseError class.
        /// </summary>
        public BaseError(string someBaseProp = default(string))
        {
            SomeBaseProp = someBaseProp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "someBaseProp")]
        public string SomeBaseProp { get; set; }

    }
}
