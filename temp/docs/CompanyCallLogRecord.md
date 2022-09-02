
# Org.OpenAPITools.Model.CompanyCallLogRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a cal log record | [optional] 
**Uri** | **string** | Canonical URI of a call log record | [optional] 
**SessionId** | **string** | Internal identifier of a call session | [optional] 
**Extension** | [**ExtensionInfoCallLog**](ExtensionInfoCallLog.md) |  | [optional] 
**TelephonySessionId** | **string** | Telephony identifier of a call session | [optional] 
**Transport** | **string** | Call transport | [optional] 
**From** | [**CallLogCallerInfo**](CallLogCallerInfo.md) |  | [optional] 
**To** | [**CallLogCallerInfo**](CallLogCallerInfo.md) |  | [optional] 
**Type** | **string** | Call type | [optional] 
**Direction** | **string** | Call direction | [optional] 
**Message** | [**CallLogRecordMessage**](CallLogRecordMessage.md) |  | [optional] 
**Delegate** | [**CallLogDelegateInfo**](CallLogDelegateInfo.md) |  | [optional] 
**Deleted** | **bool** | Indicates whether the record is deleted. Returned for deleted records, for ISync requests | [optional] 
**Action** | **string** | Action description of the call operation | [optional] 
**Result** | **string** | Status description of the call operation | [optional] 
**Reason** | **string** |  | [optional] 
**ReasonDescription** | **string** |  | [optional] 
**StartTime** | **DateTime** | The call start datetime in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**Duration** | **int** | Call duration in seconds | [optional] 
**Recording** | [**CallLogRecordingInfo**](CallLogRecordingInfo.md) |  | [optional] 
**ShortRecording** | **bool** | Indicates that the recording is too short and therefore wouldn&#39;t be returned. The flag is not returned if the value is false | [optional] 
**Legs** | [**List&lt;CallLogRecordLegInfo&gt;**](CallLogRecordLegInfo.md) | For &#39;Detailed&#39; view only. Leg description | [optional] 
**Billing** | [**BillingInfo**](BillingInfo.md) |  | [optional] 
**LastModifiedTime** | **DateTime** | For &#39;Detailed&#39; view only. The datetime when the call log record was modified in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**InternalType** | **string** | Internal type of a call | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

