// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AppConfiguration.Models
{
    /// <summary> Azure App Configuration error object. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="type"> The type of the error. </param>
        /// <param name="title"> A brief summary of the error. </param>
        /// <param name="name"> The name of the parameter that resulted in the error. </param>
        /// <param name="detail"> A detailed description of the error. </param>
        /// <param name="status"> The HTTP status code that the error maps to. </param>
        internal Error(string type, string title, string name, string detail, int? status)
        {
            Type = type;
            Title = title;
            Name = name;
            Detail = detail;
            Status = status;
        }

        /// <summary> The type of the error. </summary>
        public string Type { get; internal set; }
        /// <summary> A brief summary of the error. </summary>
        public string Title { get; internal set; }
        /// <summary> The name of the parameter that resulted in the error. </summary>
        public string Name { get; internal set; }
        /// <summary> A detailed description of the error. </summary>
        public string Detail { get; internal set; }
        /// <summary> The HTTP status code that the error maps to. </summary>
        public int? Status { get; internal set; }
    }
}
