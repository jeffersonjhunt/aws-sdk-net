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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DhcpOptions Unmarshaller
     /// </summary>
    internal class DhcpOptionsUnmarshaller : IUnmarshaller<DhcpOptions, XmlUnmarshallerContext>, IUnmarshaller<DhcpOptions, JsonUnmarshallerContext> 
    {
        public DhcpOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            DhcpOptions dhcpOptions = new DhcpOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("dhcpOptionsId", targetDepth))
                    {
                        dhcpOptions.DhcpOptionsId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("dhcpConfigurationSet/item", targetDepth))
                    {
                        dhcpOptions.DhcpConfigurations.Add(DhcpConfigurationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        dhcpOptions.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dhcpOptions;
                }
            }
                        


            return dhcpOptions;
        }

        public DhcpOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DhcpOptionsUnmarshaller instance;

        public static DhcpOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DhcpOptionsUnmarshaller();

            return instance;
        }
    }
}
    
