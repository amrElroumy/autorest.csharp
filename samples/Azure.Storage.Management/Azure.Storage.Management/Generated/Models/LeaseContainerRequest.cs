// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Management.Models
{
    /// <summary> Lease Container request schema. </summary>
    public partial class LeaseContainerRequest
    {
        /// <summary> Initializes a new instance of LeaseContainerRequest. </summary>
        public LeaseContainerRequest()
        {
        }

        /// <summary> Initializes a new instance of LeaseContainerRequest. </summary>
        /// <param name="action"> Specifies the lease action. Can be one of the available actions. </param>
        /// <param name="leaseId"> Identifies the lease. Can be specified in any valid GUID string format. </param>
        /// <param name="breakPeriod"> Optional. For a break action, proposed duration the lease should continue before it is broken, in seconds, between 0 and 60. </param>
        /// <param name="leaseDuration"> Required for acquire. Specifies the duration of the lease, in seconds, or negative one (-1) for a lease that never expires. </param>
        /// <param name="proposedLeaseId"> Optional for acquire, required for change. Proposed lease ID, in a GUID string format. </param>
        internal LeaseContainerRequest(LeaseContainerRequestAction action, string leaseId, int? breakPeriod, int? leaseDuration, string proposedLeaseId)
        {
            Action = action;
            LeaseId = leaseId;
            BreakPeriod = breakPeriod;
            LeaseDuration = leaseDuration;
            ProposedLeaseId = proposedLeaseId;
        }

        /// <summary> Specifies the lease action. Can be one of the available actions. </summary>
        public LeaseContainerRequestAction Action { get; set; }
        /// <summary> Identifies the lease. Can be specified in any valid GUID string format. </summary>
        public string LeaseId { get; set; }
        /// <summary> Optional. For a break action, proposed duration the lease should continue before it is broken, in seconds, between 0 and 60. </summary>
        public int? BreakPeriod { get; set; }
        /// <summary> Required for acquire. Specifies the duration of the lease, in seconds, or negative one (-1) for a lease that never expires. </summary>
        public int? LeaseDuration { get; set; }
        /// <summary> Optional for acquire, required for change. Proposed lease ID, in a GUID string format. </summary>
        public string ProposedLeaseId { get; set; }
    }
}
