
# Org.OpenAPITools.Model.CreateMMSMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**MessageStoreCallerInfoRequest**](MessageStoreCallerInfoRequest.md) |  | 
**To** | [**List&lt;MessageStoreCallerInfoRequest&gt;**](MessageStoreCallerInfoRequest.md) | Message receiver(s) information. The &#x60;phoneNumber&#x60; value is required | 
**Text** | **string** | Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols | [optional] 
**Country** | [**MessageCountryInfo**](MessageCountryInfo.md) |  | [optional] 
**Attachments** | **List&lt;System.IO.Stream&gt;** | Media file(s) to upload | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

