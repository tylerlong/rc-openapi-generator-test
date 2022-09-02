
# Org.OpenAPITools.Model.MessageListMessageResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The Id of the message | [optional] 
**BatchId** | **string** | Internal identifier of a batch the message was submitted in | [optional] 
**From** | **string** | Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message is sent | [optional] 
**To** | **List&lt;string&gt;** | Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which a message is sent | [optional] 
**CreationTime** | **DateTime** | The time at which the message was created | [optional] 
**LastModifiedTime** | **DateTime** | The time at which the messages was last updated | [optional] 
**MessageStatus** | **SmsStatusEnum** |  | [optional] 
**SegmentCount** | **int** | Number of segments of a message | [optional] 
**Text** | **string** | Text of a message. Returned if the &#x60;view&#x60; parameter is set to &#39;Detailed&#39; | [optional] 
**Cost** | **double** | Cost of a message | [optional] 
**Direction** | **SmsDirectionEnum** |  | [optional] 
**ErrorCode** | **string** | The RC error code of the message sending failure reason | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

