
# Org.OpenAPITools.Model.CreateDataExportTaskRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeFrom** | **string** | Starting time for data collection. The default value is &#x60;timeTo&#x60; minus 24 hours. Max allowed time frame between &#x60;timeFrom&#x60; and &#x60;timeTo&#x60; is 6 months | [optional] 
**TimeTo** | **string** | Ending time for data collection. The default value is current time. Max allowed time frame between &#x60;timeFrom&#x60; and &#x60;timeTo&#x60; is 6 months | [optional] 
**Contacts** | [**List&lt;DataExportTaskContactInfo&gt;**](DataExportTaskContactInfo.md) |  | [optional] 
**ChatIds** | **List&lt;string&gt;** | List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected. Maximum number of chats supported is 10 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

