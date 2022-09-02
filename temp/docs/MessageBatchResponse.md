
# Org.OpenAPITools.Model.MessageBatchResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the message batch | [optional] [readonly] 
**From** | **string** | Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the messages are going to be sent | [optional] 
**BatchSize** | **int** | Total number of messages in the accepted batch | [optional] 
**ProcessedCount** | **int** | Total number of messages currently processed in the batch | [optional] 
**LastModifiedTime** | **DateTime** | The last time the batch was processed.  | [optional] 
**Status** | **string** | Current status of a message batch | [optional] 
**CreationTime** | **DateTime** | The time at which the batch was created  | [optional] 
**Rejected** | [**List&lt;RejectedRecipientResponseResource&gt;**](RejectedRecipientResponseResource.md) | The list of rejected/invalid recipients | [optional] 
**Cost** | **double** | The estimated batch cost for completed batch. Calculated after batch processing is completed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

