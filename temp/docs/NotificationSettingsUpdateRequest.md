
# Org.OpenAPITools.Model.NotificationSettingsUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailAddresses** | **List&lt;string&gt;** | List of notification recipient email addresses. Should not be empty if &#39;includeManagers&#39; parameter is set to false | [optional] 
**SmsEmailAddresses** | **List&lt;string&gt;** | List of notification recipient email addresses | [optional] 
**AdvancedMode** | **bool** | Specifies notifications settings mode. If &#39;True&#39; then advanced mode is on, it allows using different emails and/or phone numbers for each notification type. If &#39;False&#39; then basic mode is on. Advanced mode settings are returned in both modes, if specified once, but if basic mode is switched on, they are not applied  | [optional] 
**Voicemails** | [**VoicemailsInfo**](VoicemailsInfo.md) |  | [optional] 
**InboundFaxes** | [**InboundFaxesInfo**](InboundFaxesInfo.md) |  | [optional] 
**OutboundFaxes** | [**OutboundFaxesInfo**](OutboundFaxesInfo.md) |  | [optional] 
**InboundTexts** | [**InboundTextsInfo**](InboundTextsInfo.md) |  | [optional] 
**MissedCalls** | [**MissedCallsInfo**](MissedCallsInfo.md) |  | [optional] 
**IncludeManagers** | **bool** | Specifies if managers&#39; emails are included in the list of emails to which notifications are sent. If not specified, then the value is &#39;True&#39; | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

