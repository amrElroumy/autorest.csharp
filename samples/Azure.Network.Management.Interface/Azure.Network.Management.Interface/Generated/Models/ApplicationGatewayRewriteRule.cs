// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Rewrite rule of an application gateway. </summary>
    public partial class ApplicationGatewayRewriteRule
    {
        /// <summary> Name of the rewrite rule that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a RewriteRuleSet. </summary>
        public int? RuleSequence { get; set; }
        /// <summary> Conditions based on which the action set execution will be evaluated. </summary>
        public IList<ApplicationGatewayRewriteRuleCondition> Conditions { get; set; }
        /// <summary> Set of actions to be done as part of the rewrite Rule. </summary>
        public ApplicationGatewayRewriteRuleActionSet ActionSet { get; set; }
    }
}