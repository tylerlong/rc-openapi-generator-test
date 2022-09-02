
# Org.OpenAPITools.Model.DeviceEmergencyInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**DeviceEmergencyAddress**](DeviceEmergencyAddress.md) |  | [optional] 
**Location** | [**DeviceEmergencyLocationInfo**](DeviceEmergencyLocationInfo.md) |  | [optional] 
**OutOfCountry** | **bool** | Specifies if emergency address is out of country | [optional] 
**AddressStatus** | **string** | Emergency address status | [optional] 
**Visibility** | **string** | Visibility of an emergency response location. If &#x60;Private&#x60; is set, then location is visible only for the restricted number of users, specified in &#x60;owners&#x60; array | [optional] 
**SyncStatus** | **string** | Resulting status of emergency address synchronization. Returned if &#x60;syncEmergencyAddress&#x60; parameter is set to &#39;True&#39; | [optional] 
**AddressEditableStatus** | **string** | Ability to register new emergency address for a phone line using devices sharing this line or only main device (line owner) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

