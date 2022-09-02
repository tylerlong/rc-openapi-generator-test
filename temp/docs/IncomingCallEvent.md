
# Org.OpenAPITools.Model.IncomingCallEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aps** | [**APSInfo**](APSInfo.md) |  | [optional] 
**Event** | **string** | Event filter name | [optional] 
**Uuid** | **string** | Universally unique identifier of a notification | [optional] 
**SubscriptionId** | **string** | Internal identifier of a subscription | [optional] 
**Timestamp** | **DateTime** | The timestamp of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**ExtensionId** | **string** | Internal identifier of an extension | [optional] [default to "~"]
**Action** | **string** | Calling action, for example &#39;StartRing&#39; | [optional] 
**SessionId** | **string** | Identifier of a call session | [optional] 
**ServerId** | **string** | Identifier of a server | [optional] 
**From** | **string** | Phone number of a caller. For GCM transport type &#39;_from&#39; property should be used | [optional] 
**FromName** | **string** | Caller name | [optional] 
**To** | **string** | Phone number of a callee | [optional] 
**ToName** | **string** | Callee name | [optional] 
**Sid** | **string** | Unique identifier of a session | [optional] 
**ToUrl** | **string** | SIP proxy registration name | [optional] 
**SrvLvl** | **string** | User data | [optional] 
**SrvLvlExt** | **string** | User data | [optional] 
**RecUrl** | **string** | File containing recorded caller name | [optional] 
**PnTtl** | **int** | Notification lifetime value in seconds, the default value is 30 seconds | [optional] 
**OwnerId** | **string** | Internal identifier of a subscription owner extension | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

