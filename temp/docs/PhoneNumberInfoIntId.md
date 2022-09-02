
# Org.OpenAPITools.Model.PhoneNumberInfoIntId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal identifier of a phone number | [optional] 
**Country** | [**PhoneNumberCountryInfo**](PhoneNumberCountryInfo.md) |  | [optional] 
**Extension** | [**DeviceProvisioningExtensionInfo**](DeviceProvisioningExtensionInfo.md) |  | [optional] 
**Label** | **string** | Custom user name of a phone number, if any | [optional] 
**Location** | **string** | Location (City, State). Filled for local US numbers | [optional] 
**PaymentType** | **string** | Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system | [optional] 
**PhoneNumber** | **string** | Phone number | [optional] 
**Status** | **string** | Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral | [optional] 
**Type** | **string** | Phone number type | [optional] 
**UsageType** | **string** | Usage type of the phone number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

