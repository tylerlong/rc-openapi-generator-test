
# Org.OpenAPITools.Model.VoicemailMessageEventBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a message | [optional] 
**To** | [**List&lt;NotificationRecipientInfo&gt;**](NotificationRecipientInfo.md) | Message receiver(s) information | [optional] 
**From** | [**SenderInfo**](SenderInfo.md) |  | [optional] 
**Type** | **string** | Type of a message | [optional] 
**CreationTime** | **string** | Message creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2019-03-10T18:07:52.534Z* | [optional] 
**LastModifiedTime** | **string** | Datetime when the message was modified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2019-03-10T18:07:52.534Z* | [optional] 
**ReadStatus** | **string** | Status of a message | [optional] [default to "Unread"]
**Priority** | **string** | Message priority | [optional] [default to "Normal"]
**Attachments** | [**List&lt;MessageAttachmentInfo&gt;**](MessageAttachmentInfo.md) | Message attachment data | [optional] 
**Direction** | **string** | Message direction | [optional] [default to DirectionEnum.Inbound]
**Availability** | **string** | Message availability status | [optional] [default to "Alive"]
**Subject** | **string** | Message subject. It replicates message text which is also returned as an attachment | [optional] 
**MessageStatus** | **string** | Status of a message | [optional] [default to "Received"]
**ConversationId** | **string** | Internal identifier of a conversation this message belongs to | [optional] 
**VmTranscriptionStatus** | **string** | Specifies if a voicemail message transcription is already completed or not | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

