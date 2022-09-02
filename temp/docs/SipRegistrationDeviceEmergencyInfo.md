
# Org.OpenAPITools.Model.SipRegistrationDeviceEmergencyInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**DeviceEmergencyServiceAddressResource**](DeviceEmergencyServiceAddressResource.md) |  | [optional] 
**Location** | [**SipRegistrationDeviceLocationInfo**](SipRegistrationDeviceLocationInfo.md) |  | [optional] 
**OutOfCountry** | **bool** | Specifies if emergency address is out of country | [optional] 
**AddressStatus** | **string** | Emergency address status | [optional] 
**Visibility** | **string** | Specifies whether to return only private or only public (company) ERLs (Emergency Response Locations) | [optional] 
**SyncStatus** | **string** | Resulting status of emergency address synchronization. Returned if &#x60;syncEmergencyAddress&#x60; parameter is set to &#39;True&#39; | [optional] 
**AddressEditableStatus** | **string** | Ability to register new emergency address for a phone line using devices sharing this line or only main device (line owner) | [optional] 
**AddressRequired** | **bool** | &#39;True&#39; if emergency address is required for the country of a phone line | [optional] 
**AddressLocationOnly** | **bool** | &#39;True&#39; if out of country emergency address is not allowed for the country of a phone line | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

