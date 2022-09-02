
# Org.OpenAPITools.Model.ActiveCallInfoWithoutSIP

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a call | [optional] 
**Direction** | **string** | Call direction | [optional] 
**QueueCall** | **bool** | Identifies if a call belongs to the call queue | [optional] 
**From** | **string** | Phone number or extension number of a caller. For GCM transport type &#39;_from&#39; property should be used | [optional] 
**FromName** | **string** | Name of a caller | [optional] 
**To** | **string** | Phone number or extension number of a callee | [optional] 
**ToName** | **string** | Name of a callee | [optional] 
**PartyId** | **string** | Internal identifier of a call party | [optional] 
**StartTime** | **string** | Time when the call is actually started | [optional] 
**SessionId** | **string** | Internal identifier of a call session | [optional] 
**TelephonySessionId** | **string** | Telephony identifier of a call session | [optional] 
**TelephonyStatus** | **string** | Telephony call status | [optional] 
**TerminationType** | **string** | Type of call termination. Supported for calls in &#39;NoCall&#39; status. If the returned termination type is &#39;intermediate&#39; it means the call is not actually ended, the connection is established on one of the devices | [optional] 
**CallInfo** | [**CallInfoCQ**](CallInfoCQ.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

