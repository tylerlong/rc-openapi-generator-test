
# Org.OpenAPITools.Model.AccountHistoryPublicRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal record identifier | [optional] 
**EventTime** | **DateTime** | Timestamp of an event (provided by a client), RFC3339 date-time format, UTC time zone. | [optional] 
**Initiator** | [**AccountHistoryRecordPublicInitiator**](AccountHistoryRecordPublicInitiator.md) |  | [optional] 
**ActionId** | **string** | Action type | [optional] 
**EventType** | **string** | Operation: \&quot;CREATE\&quot;, \&quot;UPDATE\&quot;, or \&quot;DELETE\&quot; | [optional] 
**AccountId** | **string** | Account which is related with the particular record. | [optional] 
**AccountName** | **string** | Account (company) name | [optional] 
**Target** | [**AccountHistoryRecordTarget**](AccountHistoryRecordTarget.md) |  | [optional] 
**ClientIp** | **string** | IP-address of a client. If not specified RCClientIp header value is used | [optional] 
**Comment** | **string** | Custom top-level comment | [optional] 
**Details** | [**AccountHistoryRecordPublicDetails**](AccountHistoryRecordPublicDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

