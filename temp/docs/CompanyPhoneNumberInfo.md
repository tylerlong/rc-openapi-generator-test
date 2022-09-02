
# Org.OpenAPITools.Model.CompanyPhoneNumberInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to a company phone number resource | [optional] 
**Id** | **long** | Internal identifier of a phone number | [optional] 
**Country** | [**CountryInfo**](CountryInfo.md) |  | [optional] 
**Extension** | [**ExtensionInfo**](ExtensionInfo.md) |  | [optional] 
**Label** | **string** | Custom user name of a phone number, if any | [optional] 
**Location** | **string** | Location (City, State). Filled for local US numbers | [optional] 
**PaymentType** | **string** | Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system | [optional] 
**PhoneNumber** | **string** | Phone number | [optional] 
**Status** | **string** | Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. If the value is &#39;Pending&#39; it is an external number not yet ported to RingCentral. | [optional] 
**Type** | **string** | Phone number type | [optional] 
**UsageType** | **string** | Usage type of a phone number. Usage type of a phone number. Numbers of &#39;NumberPool&#39; type wont&#39;t be returned for phone number list requests | [optional] 
**TemporaryNumber** | [**TemporaryNumberInfo**](TemporaryNumberInfo.md) |  | [optional] 
**ContactCenterProvider** | [**ContactCenterProvider**](ContactCenterProvider.md) |  | [optional] 
**VanityPattern** | **string** | Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

