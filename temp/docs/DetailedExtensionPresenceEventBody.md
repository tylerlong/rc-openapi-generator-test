
# Org.OpenAPITools.Model.DetailedExtensionPresenceEventBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtensionId** | **string** | Internal identifier of an extension | [optional] [default to "~"]
**TelephonyStatus** | **string** | Telephony presence status. Returned if telephony status is changed. | [optional] 
**ActiveCalls** | [**List&lt;ActiveCallInfoWithoutSIP&gt;**](ActiveCallInfoWithoutSIP.md) | List of the latest 7 active calls on extension | [optional] 
**Sequence** | **int** | Order number of a notification to state the chronology | [optional] 
**PresenceStatus** | **string** | Aggregated presence status, calculated from a number of sources | [optional] 
**UserStatus** | **string** | User-defined presence status (as previously published by the user) | [optional] 
**MeetingStatus** | **string** | Meetings presence status | [optional] 
**DndStatus** | **string** | Extended DnD (Do not Disturb) status | [optional] 
**AllowSeeMyPresence** | **bool** | If &#39;True&#39; enables other extensions to see the extension presence status | [optional] 
**RingOnMonitoredCall** | **bool** | If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing | [optional] 
**PickUpCallsOnHold** | **bool** | If &#39;True&#39; enables the extension user to pick up a monitored line on hold | [optional] 
**TotalActiveCalls** | **int** | Total number of active calls on extension at the present moment | [optional] 
**OwnerId** | **string** | Internal identifier of a subscription owner extension | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

