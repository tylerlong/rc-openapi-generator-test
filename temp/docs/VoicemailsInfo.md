
# Org.OpenAPITools.Model.VoicemailsInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotifyByEmail** | **bool** | Email notification flag | [optional] 
**NotifyBySms** | **bool** | SMS notification flag | [optional] 
**AdvancedEmailAddresses** | **List&lt;string&gt;** | List of recipient email addresses for voicemail notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only | [optional] 
**AdvancedSmsEmailAddresses** | **List&lt;string&gt;** | List of recipient phone numbers for voicemail notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only | [optional] 
**IncludeAttachment** | **bool** | Indicates whether voicemail should be attached to email | [optional] 
**IncludeTranscription** | **bool** | Specifies whether to add voicemail transcription or not | [optional] 
**MarkAsRead** | **bool** | Indicates whether a voicemail should be automatically marked as read | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

