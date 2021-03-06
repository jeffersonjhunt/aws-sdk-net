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
using System.Threading;
using System.Threading.Tasks;

using Amazon.CloudWatch.Model;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Interface for accessing AmazonCloudWatch.
    /// 
    /// Amazon CloudWatch <para>This is the <i>Amazon CloudWatch API Reference</i> . This guide provides detailed information about Amazon
    /// CloudWatch actions, data types, parameters, and errors. For detailed information about Amazon CloudWatch features and their associated API
    /// calls, go to the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide">Amazon CloudWatch Developer Guide</a> .
    /// </para> <para>Amazon CloudWatch is a web service that enables you to publish, monitor, and manage various metrics, as well as configure
    /// alarm actions based on data from metrics. For more information about this product go to <a href="http://aws.amazon.com/cloudwatch">http://aws.amazon.com/cloudwatch</a> .
    /// </para> <para> For information about the namespace, metric names, and dimensions that other Amazon Web Services products use to send
    /// metrics to Cloudwatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
    /// CloudWatch Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch Developer Guide</i> .
    /// </para> <para>Use the following links to get started using the <i>Amazon CloudWatch API Reference</i> :</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Operations.html">Actions</a> : An alphabetical list of
    /// all Amazon CloudWatch actions.</li>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Types.html">Data Types</a> : An alphabetical list of all
    /// Amazon CloudWatch data types.</li>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CommonParameters.html">Common Parameters</a> : Parameters
    /// that all Query actions can use.</li>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CommonErrors.html">Common Errors</a> : Client and server
    /// errors that all actions can return.</li>
    /// <li> <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions and Endpoints</a> : Itemized regions and
    /// endpoints for all AWS products.</li>
    /// <li> <a href="http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl">WSDL Location</a> :
    /// http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl</li>
    /// 
    /// </ul>
    /// <para>In addition to using the Amazon CloudWatch API, you can also use the following SDKs and third-party libraries to access Amazon
    /// CloudWatch programmatically.</para>
    /// <ul>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforjava/">AWS SDK for Java Documentation</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkfornet/">AWS SDK for .NET Documentation</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforphp/">AWS SDK for PHP Documentation</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforruby/">AWS SDK for Ruby Documentation</a> </li>
    /// 
    /// </ul>
    /// <para>Developers in the AWS developer community also provide their own libraries, which you can find at the following AWS developer
    /// centers:</para>
    /// <ul>
    /// <li> <a href="http://aws.amazon.com/java/">AWS Java Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/php/">AWS PHP Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/python/">AWS Python Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/ruby/">AWS Ruby Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/net/">AWS Windows and .NET Developer Center</a> </li>
    /// 
    /// </ul>
    /// </summary>
	public partial interface IAmazonCloudWatch : IDisposable
    {
 

        /// <summary>
        /// <para> Deletes all specified alarms. In the event of an error, no alarms are deleted. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.ResourceNotFoundException" />
		DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DeleteAlarms"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteAlarmsResponse> DeleteAlarmsAsync(DeleteAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmHistory"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(DescribeAlarmHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		DescribeAlarmHistoryResponse DescribeAlarmHistory();
 

        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarms"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		DescribeAlarmsResponse DescribeAlarms();
 

        /// <summary>
        /// <para> Retrieves all alarms for a single metric. Specify a statistic, period, or unit to filter the set of alarms further. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by AmazonCloudWatch.</returns>
		DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmsForMetric"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAlarmsForMetricResponse> DescribeAlarmsForMetricAsync(DescribeAlarmsForMetricRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Disables actions for the specified alarms. When an alarm's actions are disabled the alarm's state may change, but none of the alarm's
        /// actions will execute. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions service method on
        /// AmazonCloudWatch.</param>
		DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DisableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisableAlarmActionsResponse> DisableAlarmActionsAsync(DisableAlarmActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Enables actions for the specified alarms. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions service method on
        /// AmazonCloudWatch.</param>
		EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.EnableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableAlarmActionsResponse> EnableAlarmActionsAsync(EnableAlarmActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Gets statistics for the specified metric. </para> <para> The maximum number of data points returned from a single
        /// <c>GetMetricStatistics</c> request is 1,440, wereas the maximum number of data points that can be queried is 50,850. If you make a request
        /// that generates more than 1,440 data points, Amazon CloudWatch returns an error. In such a case, you can alter the request by narrowing the
        /// specified time range or increasing the specified period. Alternatively, you can make multiple requests across adjacent time ranges. </para>
        /// <para> Amazon CloudWatch aggregates data points based on the length of the <c>period</c> that you specify. For example, if you request
        /// statistics with a one-minute granularity, Amazon CloudWatch aggregates data points with time stamps that fall within the same one-minute
        /// period. In such a case, the data points queried can greatly outnumber the data points returned. </para> <para> The following examples show
        /// various statistics allowed by the data point query maximum of 50,850 when you call <c>GetMetricStatistics</c> on Amazon EC2 instances with
        /// detailed (one-minute) monitoring enabled: </para>
        /// <ul>
        /// <li>Statistics for up to 400 instances for a span of one hour</li>
        /// <li>Statistics for up to 35 instances over a span of 24 hours</li>
        /// <li>Statistics for up to 2 instances over a span of 2 weeks</li>
        /// 
        /// </ul>
        /// <para> For information about the namespace, metric names, and dimensions that other Amazon Web Services products use to send metrics to
        /// Cloudwatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon CloudWatch
        /// Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.MissingRequiredParameterException" />
		GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.GetMetricStatistics"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetMetricStatisticsResponse> GetMetricStatisticsAsync(GetMetricStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
        /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
        /// however, are available sooner using GetMetricStatistics. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
		ListMetricsResponse ListMetrics(ListMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.ListMetrics"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
        /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
        /// however, are available sooner using GetMetricStatistics. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
		ListMetricsResponse ListMetrics();
 

        /// <summary>
        /// <para> Creates or updates an alarm and associates it with the specified Amazon CloudWatch metric. Optionally, this operation can associate
        /// one or more Amazon Simple Notification Service resources with the alarm. </para> <para> When this operation creates an alarm, the alarm
        /// state is immediately set to <c>INSUFFICIENT_DATA</c> . The alarm is evaluated and its <c>StateValue</c> is set appropriately. Any actions
        /// associated with the <c>StateValue</c> is then executed. </para> <para><b>NOTE:</b> When updating an existing alarm, its StateValue is left
        /// unchanged. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.LimitExceededException" />
		PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricAlarm"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutMetricAlarmResponse> PutMetricAlarmAsync(PutMetricAlarmRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Publishes metric data points to Amazon CloudWatch. Amazon Cloudwatch associates the data points with the specified metric. If the
        /// specified metric does not exist, Amazon CloudWatch creates the metric. It can take up to fifteen minutes for a new metric to appear in calls
        /// to the ListMetrics action.</para> <para> The size of a PutMetricData request is limited to 8 KB for HTTP GET requests and 40 KB for HTTP
        /// POST requests. </para> <para><b>IMPORTANT:</b> Although the Value parameter accepts numbers of type Double, Amazon CloudWatch truncates
        /// values with very large exponents. Values with base-10 exponents greater than 126 (1 x 10^126) are truncated. Likewise, values with base-10
        /// exponents less than -130 (1 x 10^-130) are also truncated. </para> <para>Data that is timestamped 24 hours or more in the past may take in
        /// excess of 48 hours to become available from submission time using <c>GetMetricStatistics</c> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.MissingRequiredParameterException" />
		PutMetricDataResponse PutMetricData(PutMetricDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricData"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Temporarily sets the state of an alarm. When the updated <c>StateValue</c> differs from the previous value, the action configured for
        /// the appropriate state is invoked. This is not a permanent change. The next periodic alarm check (in about a minute) will set the alarm to
        /// its actual state. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidFormatException" />
		SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.SetAlarmState"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetAlarmStateResponse> SetAlarmStateAsync(SetAlarmStateRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
