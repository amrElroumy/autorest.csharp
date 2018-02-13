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

    public partial class Pet : Animal
    {
        /// <summary>
        /// Initializes a new instance of the Pet class.
        /// </summary>
        public Pet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Pet class.
        /// </summary>
        /// <param name="name">Gets the Pet by id.</param>
        public Pet(string aniType = default(string), string name = default(string))
            : base(aniType)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Pet by id.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
