
# Org.OpenAPITools.Model.CallFilters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtensionFilters** | [**ExtensionFilters**](ExtensionFilters.md) |  | [optional] 
**Queues** | **List&lt;string&gt;** | List of queues extension ids which allows to get data only for calls that were routed through any of these queues | [optional] 
**CalledNumbers** | **List&lt;string&gt;** | The direct company numbers the caller called (joined via OR) | [optional] 
**Directions** | [**List&lt;Direction&gt;**](Direction.md) | Specifies the call directions relative to the scope specified in grouping object (joined via OR). Not applicable to internal origin calls with company scope | [optional] 
**Origins** | [**List&lt;Origin&gt;**](Origin.md) | Specifies whether an external party was present in the initial segment of the call (joined via OR) | [optional] 
**CallResponses** | [**List&lt;CallResponse&gt;**](CallResponse.md) | Filtering of calls by first response (joined via OR) | [optional] 
**CallResults** | [**List&lt;CallResult&gt;**](CallResult.md) | Filtering of calls by the nature of call result (joined via OR) | [optional] 
**CallSegments** | [**List&lt;CallSegmentFilter&gt;**](CallSegmentFilter.md) | Filtering of calls by presence of specific segment (joined via OR) | [optional] 
**CallActions** | [**List&lt;CallAction&gt;**](CallAction.md) | Filtering of calls by presence of specific action (joined via OR) | [optional] 
**CompanyHours** | [**List&lt;CompanyHoursOptions&gt;**](CompanyHoursOptions.md) | Filtering of calls by company&#39;s business hours or after hours (joined via OR) | [optional] 
**CallDuration** | [**CallDurationFilter**](CallDurationFilter.md) |  | [optional] 
**TimeSpent** | [**TimeSpentFilter**](TimeSpentFilter.md) |  | [optional] 
**QueueSla** | [**List&lt;QueueSlaOptions&gt;**](QueueSlaOptions.md) | Filtering calls that were within or out of queue SLA (joined via OR). Only applicable to Queues grouping | [optional] 
**CallTypes** | [**List&lt;CallType&gt;**](CallType.md) | Filtering of calls based on how the call started from the callee perspective (joined via OR). If the call is outbound relative to the grouping scope, CallType is Outbound | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

