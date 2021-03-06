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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ExportToS3TaskSpecification
    {
        
        private DiskImageFormat diskImageFormat;
        private ContainerFormat containerFormat;
        private string s3Bucket;
        private string s3Prefix;


        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>VMDK, RAW, VHD</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DiskImageFormat DiskImageFormat
        {
            get { return this.diskImageFormat; }
            set { this.diskImageFormat = value; }
        }

        // Check to see if DiskImageFormat property is set
        internal bool IsSetDiskImageFormat()
        {
            return this.diskImageFormat != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ova</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ContainerFormat ContainerFormat
        {
            get { return this.containerFormat; }
            set { this.containerFormat = value; }
        }

        // Check to see if ContainerFormat property is set
        internal bool IsSetContainerFormat()
        {
            return this.containerFormat != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string S3Bucket
        {
            get { return this.s3Bucket; }
            set { this.s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this.s3Bucket != null;
        }

        /// <summary>
        /// The image is written to a single object in the Amazon S3 bucket at the S3 key s3prefix + exportTaskId + '.' + diskImageFormat.
        ///  
        /// </summary>
        public string S3Prefix
        {
            get { return this.s3Prefix; }
            set { this.s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this.s3Prefix != null;
        }
    }
}
