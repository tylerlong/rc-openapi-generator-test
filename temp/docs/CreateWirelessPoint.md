
# Org.OpenAPITools.Model.CreateWirelessPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bssid** | **string** | Unique 48-bit identifier of wireless access point complying with MAC address conventions. The Mask is XX:XX:XX:XX:XX:XX, where X can be a symbol in the range of 0-9 or A-F | 
**Name** | **string** | Wireless access point name | 
**Site** | [**AutomaticLocationUpdatesSiteInfo**](AutomaticLocationUpdatesSiteInfo.md) |  | [optional] 
**EmergencyAddress** | [**LocationUpdatesEmergencyAddressInfoRequest**](LocationUpdatesEmergencyAddressInfoRequest.md) |  | [optional] 
**EmergencyLocationId** | **string** | Deprecated. Internal identifier of the emergency response location (address). Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned | [optional] 
**EmergencyLocation** | [**ERLLocationInfo**](ERLLocationInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

