
# Org.OpenAPITools.Model.CallLogSync

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to the list of call log records with sync information | [optional] 
**Records** | [**List&lt;UserCallLogRecord&gt;**](UserCallLogRecord.md) | List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter | [optional] 
**SyncInfo** | [**SyncInfoCallLog**](SyncInfoCallLog.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

