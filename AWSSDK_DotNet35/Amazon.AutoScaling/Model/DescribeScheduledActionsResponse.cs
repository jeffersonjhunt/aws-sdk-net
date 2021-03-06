/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns information about the  DescribeScheduledActions response and response metadata.
    /// </summary>
    public partial class DescribeScheduledActionsResponse : DescribeScheduledActionsResult
    {
        /// <summary>
        /// Gets and sets the DescribeScheduledActionsResult property.
        /// A scaling action that is scheduled for a future time and date. An action can be scheduled up to thirty days in advance. Starting with API
        /// version 2011-01-01, you can use recurrence to specify that a scaling action occurs regularly on a schedule.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeScheduledActionsResult class are now available on the DescribeScheduledActionsResponse class. You should use the properties on DescribeScheduledActionsResponse instead of accessing them through DescribeScheduledActionsResult.")]
        public DescribeScheduledActionsResult DescribeScheduledActionsResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
