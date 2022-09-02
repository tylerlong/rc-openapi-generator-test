
# Org.OpenAPITools.Model.CreateInternalTextMessageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**PagerCallerInfoRequest**](PagerCallerInfoRequest.md) |  | [optional] 
**ReplyOn** | **int** | Internal identifier of a message this message replies to | [optional] 
**Text** | **string** | Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols | 
**To** | [**List&lt;PagerCallerInfoRequest&gt;**](PagerCallerInfoRequest.md) | Optional if replyOn parameter is specified. Receiver of a pager message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

