// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Management.Models
{
    /// <summary> The parameters used to regenerate the storage account key. </summary>
    public partial class StorageAccountRegenerateKeyParameters
    {
        /// <summary> Initializes a new instance of StorageAccountRegenerateKeyParameters. </summary>
        public StorageAccountRegenerateKeyParameters()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountRegenerateKeyParameters. </summary>
        /// <param name="keyName"> The name of storage keys that want to be regenerated, possible values are key1, key2, kerb1, kerb2. </param>
        internal StorageAccountRegenerateKeyParameters(string keyName)
        {
            KeyName = keyName;
        }

        /// <summary> The name of storage keys that want to be regenerated, possible values are key1, key2, kerb1, kerb2. </summary>
        public string KeyName { get; set; }
    }
}
