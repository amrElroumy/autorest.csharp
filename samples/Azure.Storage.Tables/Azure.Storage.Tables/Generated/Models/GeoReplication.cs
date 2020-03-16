// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Tables.Models
{
    /// <summary> The GeoReplication. </summary>
    public partial class GeoReplication
    {
        /// <summary> Initializes a new instance of GeoReplication. </summary>
        internal GeoReplication()
        {
        }

        /// <summary> Initializes a new instance of GeoReplication. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncTime"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        internal GeoReplication(GeoReplicationStatusType status, DateTimeOffset lastSyncTime)
        {
            Status = status;
            LastSyncTime = lastSyncTime;
        }

        /// <summary> The status of the secondary location. </summary>
        public GeoReplicationStatusType Status { get; internal set; }
        /// <summary> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </summary>
        public DateTimeOffset LastSyncTime { get; internal set; }
    }
}
