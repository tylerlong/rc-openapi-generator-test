
# Org.OpenAPITools.Model.GetExtensionListInfoResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal identifier of an extension | [optional] 
**Uri** | **string** | Canonical URI of an extension | [optional] 
**Contact** | [**ContactInfo**](ContactInfo.md) |  | [optional] 
**ExtensionNumber** | **string** | Number of an extension | [optional] 
**Name** | **string** | Extension name. For user extension types the value is a combination of the specified first name and last name | [optional] 
**Permissions** | [**ExtensionPermissions**](ExtensionPermissions.md) |  | [optional] 
**ProfileImage** | [**ProfileImageInfo**](ProfileImageInfo.md) |  | [optional] 
**Status** | **string** | Extension current state. If &#39;Unassigned&#39; is specified, then extensions without ‘extensionNumber’ are returned. If not specified, then all extensions are returned | [optional] 
**Type** | **string** | Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
**SubType** | **string** | Extension sub-type, if applicable. For any unsupported sub-types the &#39;Unknown&#39; value will be returned | [optional] 
**CallQueueInfo** | [**CallQueueExtensionInfo**](CallQueueExtensionInfo.md) |  | [optional] 
**Hidden** | **bool** | Hides extension from showing in company directory. Supported for extensions of User type only | [optional] 
**Site** | [**AutomaticLocationUpdatesSiteInfo**](AutomaticLocationUpdatesSiteInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

