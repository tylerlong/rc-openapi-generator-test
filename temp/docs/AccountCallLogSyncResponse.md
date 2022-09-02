
# Org.OpenAPITools.Model.AccountCallLogSyncResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to account call log sync resource | [optional] 
**Records** | [**List&lt;CompanyCallLogRecord&gt;**](CompanyCallLogRecord.md) | List of call log records with synchronization information. For &#39;ISync&#39; the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter | [optional] 
**SyncInfo** | [**CompanyCallLogSyncInfo**](CompanyCallLogSyncInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

