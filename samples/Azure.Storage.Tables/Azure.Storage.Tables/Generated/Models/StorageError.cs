// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Tables.Models
{
    /// <summary> The StorageError. </summary>
    public partial class StorageError
    {
        /// <summary> Initializes a new instance of StorageError. </summary>
        internal StorageError()
        {
        }

        /// <summary> Initializes a new instance of StorageError. </summary>
        /// <param name="message"> . </param>
        internal StorageError(string message)
        {
            Message = message;
        }

        public string Message { get; internal set; }
    }
}
