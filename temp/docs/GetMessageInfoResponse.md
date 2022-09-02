
# Org.OpenAPITools.Model.GetMessageInfoResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal identifier of a message | [optional] 
**Uri** | **string** | Canonical URI of a message | [optional] 
**ExtensionId** | **string** | Internal identifier of an extension | [optional] 
**Attachments** | [**List&lt;MessageAttachmentInfo&gt;**](MessageAttachmentInfo.md) | The list of message attachments | [optional] 
**Availability** | **string** | Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly | [optional] 
**ConversationId** | **long** | SMS and Pager only. Identifier of a conversation the message belongs to | [optional] 
**Conversation** | [**ConversationInfo**](ConversationInfo.md) |  | [optional] 
**CreationTime** | **DateTime** | Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**DeliveryErrorCode** | **string** | SMS only. Delivery error code returned by gateway | [optional] 
**Direction** | **string** | Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound | [optional] 
**FaxPageCount** | **int** | Fax only. Page count in a fax message | [optional] 
**FaxResolution** | **string** | Fax only. Resolution of a fax message. &#39;High&#39; for black and white image scanned at 200 dpi, &#39;Low&#39; for black and white image scanned at 100 dpi | [optional] 
**From** | [**MessageStoreCallerInfoResponseFrom**](MessageStoreCallerInfoResponseFrom.md) |  | [optional] 
**LastModifiedTime** | **DateTime** | The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**MessageStatus** | **string** | Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is &#39;Queued&#39;, then &#39;Queued&#39; value is returned If status for at least one recipient is &#39;SendingFailed&#39;, then &#39;SendingFailed&#39; value is returned In other cases Sent status is returned | [optional] 
**PgToDepartment** | **bool** | &#39;Pager&#39; only. &#39;True&#39; if at least one of the message recipients is &#39;Department&#39; extension | [optional] 
**Priority** | **string** | Message priority | [optional] 
**ReadStatus** | **string** | Message read status | [optional] 
**SmsDeliveryTime** | **DateTime** | SMS only. The datetime when outbound SMS was delivered to recipient&#39;s handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral | [optional] 
**SmsSendingAttemptsCount** | **int** | SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable) | [optional] 
**Subject** | **string** | Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment | [optional] 
**To** | [**List&lt;MessageStoreCallerInfoResponseTo&gt;**](MessageStoreCallerInfoResponseTo.md) | Recipient information | [optional] 
**Type** | **string** | Message type | [optional] 
**VmTranscriptionStatus** | **string** | Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the &#39;NotAvailable&#39; value is returned | [optional] 
**CoverIndex** | **int** | Cover page identifier. If coverIndex is set to &#39;0&#39; (zero) cover page is not attached. For the list of available cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is attached (which is configured in &#39;Outbound Fax Settings&#39;) | [optional] 
**CoverPageText** | **string** | Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

