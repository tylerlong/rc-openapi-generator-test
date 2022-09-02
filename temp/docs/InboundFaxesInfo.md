
# Org.OpenAPITools.Model.InboundFaxesInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotifyByEmail** | **bool** | Email notification flag | [optional] 
**NotifyBySms** | **bool** | SMS notification flag | [optional] 
**AdvancedEmailAddresses** | **List&lt;string&gt;** | List of recipient email addresses for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only | [optional] 
**AdvancedSmsEmailAddresses** | **List&lt;string&gt;** | List of recipient phone numbers for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only | [optional] 
**IncludeAttachment** | **bool** | Indicates whether fax should be attached to email | [optional] 
**MarkAsRead** | **bool** | Indicates whether email should be automatically marked as read | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

