
# Org.OpenAPITools.Model.WirelessPointInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to the wireless point resource | [optional] 
**Id** | **string** | Internal identifier of a wireless point | [optional] 
**Bssid** | **string** | Unique 48-bit identifier of the wireless access point complying with MAC address conventions | [optional] 
**Name** | **string** | Wireless access point name | [optional] 
**Site** | [**AutomaticLocationUpdatesSiteInfo**](AutomaticLocationUpdatesSiteInfo.md) |  | [optional] 
**EmergencyAddress** | [**LocationUpdatesEmergencyAddressInfo**](LocationUpdatesEmergencyAddressInfo.md) |  | [optional] 
**EmergencyLocation** | [**ERLLocationInfo**](ERLLocationInfo.md) |  | [optional] 
**EmergencyLocationId** | **string** | Deprecated. Emergency response location (address) internal identifier. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

