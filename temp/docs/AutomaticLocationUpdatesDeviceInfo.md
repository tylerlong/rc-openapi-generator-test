
# Org.OpenAPITools.Model.AutomaticLocationUpdatesDeviceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a device | [optional] 
**Type** | **string** | Device type | [optional] [default to TypeEnum.HardPhone]
**Serial** | **string** | Serial number for HardPhone (is returned only when the phone is shipped and provisioned) | [optional] 
**FeatureEnabled** | **bool** | Specifies if Automatic Location Updates feature is enabled | [optional] 
**Name** | **string** | Device name | [optional] 
**Model** | [**AutomaticLocationUpdatesModelInfo**](AutomaticLocationUpdatesModelInfo.md) |  | [optional] 
**Site** | [**AutomaticLocationUpdatesSiteInfo**](AutomaticLocationUpdatesSiteInfo.md) |  | [optional] 
**PhoneLines** | [**List&lt;AutomaticLocationUpdatesPhoneLine&gt;**](AutomaticLocationUpdatesPhoneLine.md) | Phone lines information | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

