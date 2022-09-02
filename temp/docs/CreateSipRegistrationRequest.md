
# Org.OpenAPITools.Model.CreateSipRegistrationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | [**DeviceInfoRequest**](DeviceInfoRequest.md) |  | [optional] 
**SipInfo** | [**List&lt;SIPInfoRequest&gt;**](SIPInfoRequest.md) | SIP settings for device | [optional] 
**SoftPhoneLineReassignment** | **string** | Supported for softphone clients only. If &#39;SoftphoneLineReassignment&#39; feature is enabled the reassignment process can be initialized, however if there is no DL for the given user&#39;s device then SPR-131 error code will be returned. | [optional] [default to SoftPhoneLineReassignmentEnum.None]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

