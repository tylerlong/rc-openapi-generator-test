
# Org.OpenAPITools.Model.UserPhoneNumberInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to the user&#39;s phone number resource | [optional] 
**Id** | **long** | Internal identifier of a phone number | [optional] 
**Country** | [**CountryInfo**](CountryInfo.md) |  | [optional] 
**ContactCenterProvider** | [**ContactCenterProvider**](ContactCenterProvider.md) |  | [optional] 
**Extension** | [**UserPhoneNumberExtensionInfo**](UserPhoneNumberExtensionInfo.md) |  | [optional] 
**Label** | **string** | Custom user name of a phone number, if any | [optional] 
**Location** | **string** | Location (City, State). Filled for local US numbers | [optional] 
**PaymentType** | **string** | Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system | [optional] 
**PhoneNumber** | **string** | Phone number | [optional] 
**Primary** | **bool** | Specifies if the number is primary, i.e. displayed as &#39;main number&#39; and called by default | [optional] 
**Status** | **string** | Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral | [optional] 
**Type** | **string** | Phone number type | [optional] 
**SubType** | **string** | Extension sub-type, if applicable. For any unsupported sub-types the &#39;Unknown&#39; value will be returned | [optional] 
**UsageType** | **string** | Usage type of a phone number. Numbers of &#39;NumberPool&#39; type will not be returned for phone number list requests | [optional] 
**Features** | **List&lt;string&gt;** | List of features of a phone number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

