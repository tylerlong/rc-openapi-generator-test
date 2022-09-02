
# Org.OpenAPITools.Model.AnalyticsLegacyPerformanceCallsFilters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Direction** | **AnalyticsLegacyDirection** |  | [optional] 
**Origin** | **AnalyticsLegacyOrigin** |  | [optional] 
**CallResponse** | **AnalyticsLegacyCallResponse** |  | [optional] 
**CallResult** | [**List&lt;AnalyticsLegacyCallResultType&gt;**](AnalyticsLegacyCallResultType.md) | Aggregation of calls by the nature of call result (joined via OR) | [optional] 
**CallSegments** | [**List&lt;AnalyticsLegacyCallSegmentFilter&gt;**](AnalyticsLegacyCallSegmentFilter.md) | Aggregation of calls by presence of specific segment (joined via OR) | [optional] 
**CallActions** | [**List&lt;AnalyticsLegacyCallActionFilter&gt;**](AnalyticsLegacyCallActionFilter.md) | Aggregation of calls by presence of specific action (joined via OR) | [optional] 
**CompanyHours** | **AnalyticsLegacyPerformanceCallsCompanyHours** |  | [optional] 
**CallDuration** | [**AnalyticsLegacyPerformanceCallsFilterByLength**](AnalyticsLegacyPerformanceCallsFilterByLength.md) |  | [optional] 
**TimeSpent** | [**AnalyticsLegacyPerformanceCallsFilterTimeSpentByMailbox**](AnalyticsLegacyPerformanceCallsFilterTimeSpentByMailbox.md) |  | [optional] 
**CallerExtensionIds** | **List&lt;string&gt;** | List of extension Ids from which users specified in groupBy received calls, items are joined via OR condition | [optional] 
**CalledExtensionIds** | **List&lt;string&gt;** | List of extension Ids to which users specified in groupBy placed calls, items are joined via OR condition | [optional] 
**CalledNumbers** | **List&lt;string&gt;** | The direct company numbers the caller called (joined via OR) | [optional] 
**QueueSla** | **AnalyticsLegacyQueueSla** |  | [optional] 
**CallType** | [**List&lt;AnalyticsLegacyCallType&gt;**](AnalyticsLegacyCallType.md) | This filter allows to get aggregation of calls based on how the call started from the callee perspective (joined via OR). If the call is outbound relative to the grouping scope, callType is Outbound | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

