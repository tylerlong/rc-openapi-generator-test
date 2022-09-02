
# Org.OpenAPITools.Model.PresenceInfoResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to the presence resource | [optional] 
**UserStatus** | **string** |  | [optional] 
**DndStatus** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**AllowSeeMyPresence** | **bool** |  | [optional] [default to false]
**RingOnMonitoredCall** | **bool** |  | [optional] [default to false]
**PickUpCallsOnHold** | **bool** |  | [optional] [default to false]
**ActiveCalls** | [**List&lt;ActiveCallInfo&gt;**](ActiveCallInfo.md) |  | [optional] 
**Extension** | [**GetPresenceExtensionInfo**](GetPresenceExtensionInfo.md) |  | [optional] 
**MeetingStatus** | **string** | Meetings presence status | [optional] 
**TelephonyStatus** | **string** | Telephony presence status. Returned if telephony status is changed | [optional] 
**PresenceStatus** | **string** | Aggregated presence status, calculated from a number of sources | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

