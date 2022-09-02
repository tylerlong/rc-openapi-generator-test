
# Org.OpenAPITools.Model.EmergencyLocationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of the emergency response location | [optional] 
**Address** | [**EmergencyLocationAddressInfo**](EmergencyLocationAddressInfo.md) |  | [optional] 
**Name** | **string** | Emergency response location name | [optional] 
**Site** | [**ShortSiteInfo**](ShortSiteInfo.md) |  | [optional] 
**AddressStatus** | **string** | Emergency address status | [optional] 
**UsageStatus** | **string** | Status of emergency response location usage. | [optional] 
**SyncStatus** | **string** | Resulting status of emergency address synchronization. Returned if &#x60;syncEmergencyAddress&#x60; parameter is set to &#39;True&#39; | [optional] 
**Visibility** | **string** | Visibility of an emergency response location. If &#x60;Private&#x60; is set, then location is visible only for the restricted number of users, specified in &#x60;owners&#x60; array | [optional] [default to VisibilityEnum.Public]
**Owners** | [**List&lt;LocationOwnerInfo&gt;**](LocationOwnerInfo.md) | List of private location owners | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

