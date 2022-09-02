
# Org.OpenAPITools.Model.TimelineResponseOptionsTimers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllCallsDuration** | **bool** | Include data for all calls duration | [optional] 
**CallsDurationByDirection** | **bool** | Include breakdown of calls duration by direction (Inbound, Outbound) | [optional] 
**CallsDurationByOrigin** | **bool** | Include breakdown of calls duration by origin (Internal, External) | [optional] 
**CallsDurationByResponse** | **bool** | Include breakdown of calls duration by response (Answered, NotAnswered, Connected, NotConnected) | [optional] 
**CallsSegmentsDuration** | **bool** | Include breakdown of calls duration by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup)  | [optional] 
**CallsDurationByResult** | **bool** | Include breakdown of calls duration by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted) | [optional] 
**CallsDurationByCompanyHours** | **bool** | Include breakdown of calls duration by company hours (BusinessHours, AfterHours) | [optional] 
**CallsDurationByQueueSla** | **bool** | Include breakdown of calls duration by queue SLA (InSLA, OutSLA). This timer is only applicable to Queues grouping | [optional] 
**CallsDurationByType** | **bool** | Include breakdown of calls duration by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

