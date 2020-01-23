// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace CognitiveSearch.Models
{
    /// <summary> Defines the aggregation function used to combine the results of all the scoring functions in a scoring profile. </summary>
    public enum ScoringFunctionAggregation
    {
        /// <summary> sum. </summary>
        Sum,
        /// <summary> average. </summary>
        Average,
        /// <summary> minimum. </summary>
        Minimum,
        /// <summary> maximum. </summary>
        Maximum,
        /// <summary> firstMatching. </summary>
        FirstMatching
    }
}