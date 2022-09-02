
# Org.OpenAPITools.Model.ActiveCallInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Direction** | **string** |  | [optional] 
**QueueCall** | **bool** | Identifies if a call belongs to the call queue | [optional] 
**From** | **string** | Phone number or extension number of a caller. For GCM transport type &#39;_from&#39; property should be used | [optional] 
**FromName** | **string** | Name of a caller | [optional] 
**To** | **string** | Phone number or extension number of a callee | [optional] 
**ToName** | **string** | Name of a callee | [optional] 
**StartTime** | **string** | Time when the call is actually started | [optional] 
**TelephonyStatus** | **string** | Telephony presence status | [optional] 
**SipData** | [**DetailedCallInfo**](DetailedCallInfo.md) |  | [optional] 
**SessionId** | **string** |  | [optional] 
**TelephonySessionId** | **string** | Telephony identifier of a call session | [optional] 
**OnBehalfOf** | **string** | Extension ID of the call owner on whose behalf a call is performed | [optional] 
**PartyId** | **string** | Internal identifier of a call party | [optional] 
**TerminationType** | **string** |  | [optional] 
**CallInfo** | [**CallInfoCQ**](CallInfoCQ.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

