
# Org.OpenAPITools.Model.MessageDetailsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a message | [optional] 
**From** | **string** | Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent | [optional] 
**To** | **List&lt;string&gt;** | List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent | [optional] 
**Text** | **string** | Text of a message, maximum number of characters is 1000 | [optional] 
**CreationTime** | **DateTime** | The time when this is message was created. | [optional] 
**LastModifiedTime** | **DateTime** | The time when this message was last updated. | [optional] 
**MessageStatus** | **SmsStatusEnum** |  | [optional] 
**SegmentCount** | **int** | Number of segments of a message | [optional] 
**Cost** | **double** | Cost of a message | [optional] 
**BatchId** | **string** | The batch in which the message was submitted | [optional] 
**Direction** | **SmsDirectionEnum** |  | [optional] 
**ErrorCode** | **string** | The RC error code of the message sending failure reason | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

