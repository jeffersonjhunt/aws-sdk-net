/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> This data type is used as a response element in the DescribeDBSecurityGroups action. </para>
    /// </summary>
    public class IPRange
    {
        
        private string status;
        private string cIDRIP;


        /// <summary>
        /// Specifies the status of the IP range. Status can be "authorizing", "authorized", "revoking", and "revoked".
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Specifies the IP range.
        ///  
        /// </summary>
        public string CIDRIP
        {
            get { return this.cIDRIP; }
            set { this.cIDRIP = value; }
        }

        // Check to see if CIDRIP property is set
        internal bool IsSetCIDRIP()
        {
            return this.cIDRIP != null;
        }
    }
}
