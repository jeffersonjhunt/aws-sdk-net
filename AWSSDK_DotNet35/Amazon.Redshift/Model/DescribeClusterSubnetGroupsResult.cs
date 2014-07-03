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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Contains the output from the             <a>DescribeClusterSubnetGroups</a>
    /// action.
    /// </summary>
    public partial class DescribeClusterSubnetGroupsResult : AmazonWebServiceResponse
    {
        private List<ClusterSubnetGroup> _clusterSubnetGroups = new List<ClusterSubnetGroup>();
        private string _marker;


        /// <summary>
        /// Gets and sets the property ClusterSubnetGroups. 
        /// <para>
        ///         A list of <a>ClusterSubnetGroup</a> instances.        
        /// </para>
        /// </summary>
        public List<ClusterSubnetGroup> ClusterSubnetGroups
        {
            get { return this._clusterSubnetGroups; }
            set { this._clusterSubnetGroups = value; }
        }

        // Check to see if ClusterSubnetGroups property is set
        internal bool IsSetClusterSubnetGroups()
        {
            return this._clusterSubnetGroups != null && this._clusterSubnetGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///             A value that indicates the starting point for the next set of response
        /// records in a subsequent request.             If a value is returned in a response,
        /// you can retrieve the next set of records by providing this returned             marker
        /// value in the <code>Marker</code> parameter and retrying the command. If the <code>Marker</code>
        /// field            is empty, all response records have been retrieved for the request.
        ///        
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}