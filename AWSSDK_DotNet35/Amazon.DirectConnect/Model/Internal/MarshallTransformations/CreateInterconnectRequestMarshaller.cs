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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Interconnect Request Marshaller
    /// </summary>       
    internal class CreateInterconnectRequestMarshaller : IMarshaller<IRequest, CreateInterconnectRequest> 
    {
        

        public IRequest Marshall(CreateInterconnectRequest createInterconnectRequest) 
        {

            IRequest request = new DefaultRequest(createInterconnectRequest, "AmazonDirectConnect");
            string target = "OvertureService.CreateInterconnect";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (createInterconnectRequest != null && createInterconnectRequest.IsSetInterconnectName()) 
                {
                    writer.WritePropertyName("interconnectName");
                    writer.Write(createInterconnectRequest.InterconnectName);
                }
                if (createInterconnectRequest != null && createInterconnectRequest.IsSetBandwidth()) 
                {
                    writer.WritePropertyName("bandwidth");
                    writer.Write(createInterconnectRequest.Bandwidth);
                }
                if (createInterconnectRequest != null && createInterconnectRequest.IsSetLocation()) 
                {
                    writer.WritePropertyName("location");
                    writer.Write(createInterconnectRequest.Location);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
