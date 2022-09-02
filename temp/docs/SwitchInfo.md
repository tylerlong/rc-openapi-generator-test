
# Org.OpenAPITools.Model.SwitchInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to the network switch resource | [optional] 
**Id** | **string** | Internal identifier of a network switch | [optional] 
**ChassisId** | **string** | Unique identifier of a network switch | [optional] 
**Name** | **string** | Name of a network switch | [optional] 
**Site** | [**SwitchSiteInfo**](SwitchSiteInfo.md) |  | [optional] 
**EmergencyAddress** | [**LocationUpdatesEmergencyAddressInfo**](LocationUpdatesEmergencyAddressInfo.md) |  | [optional] 
**EmergencyLocationId** | **string** | Deprecated. Emergency response location (address) internal identifier. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned | [optional] 
**EmergencyLocation** | [**ERLLocationInfo**](ERLLocationInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

