
# Org.OpenAPITools.Model.CreateMessageStoreReportRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateTo** | **DateTime** | The end of the time range to collect message records in ISO 8601 format including timezone. Default is the current time  | [optional] 
**DateFrom** | **DateTime** | The beginning of the time range to collect call log records in ISO 8601 format including timezone. Default is the current time minus 24 hours  | [optional] 
**MessageTypes** | [**List&lt;MessageTypeEnum&gt;**](MessageTypeEnum.md) | Types of messages to be collected. If not specified, all messages without message type filtering will be returned. Multiple values are accepted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

