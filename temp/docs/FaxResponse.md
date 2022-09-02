
# Org.OpenAPITools.Model.FaxResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal identifier of a message | [optional] 
**Uri** | **string** | Canonical URI of a message | [optional] 
**Type** | **string** | Message type - &#39;Fax&#39; | [optional] 
**From** | [**CallerInfoFrom**](CallerInfoFrom.md) |  | [optional] 
**To** | [**List&lt;CallerInfoTo&gt;**](CallerInfoTo.md) | Recipient information | [optional] 
**CreationTime** | **DateTime** | Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**ReadStatus** | **string** | Message read status | [optional] 
**Priority** | **string** | Message priority | [optional] 
**Attachments** | [**List&lt;MessageAttachmentInfoIntId&gt;**](MessageAttachmentInfoIntId.md) | The list of message attachments | [optional] 
**Direction** | **string** | Message direction | [optional] 
**Availability** | **string** | Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly | [optional] 
**MessageStatus** | **string** | Message status. &#39;Queued&#39; - the message is queued for sending; &#39;Sent&#39; - a message is successfully sent; &#39;SendingFailed&#39; - a message sending attempt has failed; &#39;Received&#39; - a message is received (inbound messages have this status by default) | [optional] 
**FaxResolution** | **string** | Resolution of a fax message. (&#39;High&#39; for black and white image scanned at 200 dpi, &#39;Low&#39; for black and white image scanned at 100 dpi) | [optional] 
**FaxPageCount** | **int** | Page count in a fax message | [optional] 
**LastModifiedTime** | **DateTime** | Datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**CoverIndex** | **int** | Cover page identifier. If coverIndex is set to &#39;0&#39; (zero) cover page is not attached. For the list of available cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is attached (which is configured in &#39;Outbound Fax Settings&#39;) | [optional] 
**CoverPageText** | **string** | Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

