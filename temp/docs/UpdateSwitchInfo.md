
# Org.OpenAPITools.Model.UpdateSwitchInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | internal identifier of a switch | [optional] 
**ChassisId** | **string** | Unique identifier of a network switch. The supported formats are: XX:XX:XX:XX:XX:XX (symbols 0-9 and A-F) for MAC address and X.X.X.X for IP address (symbols 0-255) | [optional] 
**Name** | **string** | Name of a network switch | [optional] 
**Site** | [**SwitchSiteInfo**](SwitchSiteInfo.md) |  | [optional] 
**EmergencyAddress** | [**LocationUpdatesEmergencyAddressInfoRequest**](LocationUpdatesEmergencyAddressInfoRequest.md) |  | [optional] 
**EmergencyLocationId** | **string** | Deprecated. Emergency response location (address) internal identifier. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned | [optional] 
**EmergencyLocation** | [**ERLLocationInfo**](ERLLocationInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

