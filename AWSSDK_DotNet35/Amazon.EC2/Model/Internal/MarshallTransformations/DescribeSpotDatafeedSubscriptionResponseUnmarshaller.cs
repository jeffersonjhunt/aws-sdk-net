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
using System.Net;
using System.Collections.Generic;
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for DescribeSpotDatafeedSubscription operation
    /// </summary>
    internal class DescribeSpotDatafeedSubscriptionResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            DescribeSpotDatafeedSubscriptionResponse response = new DescribeSpotDatafeedSubscriptionResponse();
            
            int targetDepth = 2;
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    
                    if (context.TestExpression("spotDatafeedSubscription", targetDepth))
                    {
                        response.SpotDatafeedSubscription = SpotDatafeedSubscriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
            }
                 
                        
            return response;
        }
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static DescribeSpotDatafeedSubscriptionResponseUnmarshaller instance;

        public static DescribeSpotDatafeedSubscriptionResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DescribeSpotDatafeedSubscriptionResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
