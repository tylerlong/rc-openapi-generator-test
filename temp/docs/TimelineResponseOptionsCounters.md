
# Org.OpenAPITools.Model.TimelineResponseOptionsCounters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllCalls** | **bool** | Include data for total calls count | [optional] 
**CallsByDirection** | **bool** | Include breakdown of calls count by direction (Inbound, Outbound) | [optional] 
**CallsByOrigin** | **bool** | Include breakdown of calls count by origin (Internal, External) | [optional] 
**CallsByResponse** | **bool** | Include breakdown of calls count by response (Answered, NotAnswered, Connected, NotConnected) | [optional] 
**CallsSegments** | **bool** | Include breakdown of calls count by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup) | [optional] 
**CallsByResult** | **bool** | Include breakdown of calls count by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted) | [optional] 
**CallsByCompanyHours** | **bool** | Include breakdown of calls count by company hours (BusinessHours, AfterHours) | [optional] 
**CallsByQueueSla** | **bool** | Include breakdown of calls count by queue SLA (InSLA, OutSLA). This counter is only applicable to Queues grouping | [optional] 
**CallsByActions** | **bool** | Include breakdown of calls count by action (HoldOff, HoldOn, ParkOn, ParkOff, BlindTransfer, WarmTransfer, DTMFTransfer) | [optional] 
**CallsByType** | **bool** | Include breakdown of calls count by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

