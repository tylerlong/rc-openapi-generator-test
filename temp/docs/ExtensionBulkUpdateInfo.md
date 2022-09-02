
# Org.OpenAPITools.Model.ExtensionBulkUpdateInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of an extension | [optional] 
**Status** | **string** |  | [optional] 
**StatusInfo** | [**ExtensionStatusInfo**](ExtensionStatusInfo.md) |  | [optional] 
**Reason** | **string** | Type of suspension | [optional] 
**Comment** | **string** | Free form user comment | [optional] 
**ExtensionNumber** | **string** | Extension number available | [optional] 
**Contact** | [**ContactInfoUpdateRequest**](ContactInfoUpdateRequest.md) |  | [optional] 
**RegionalSettings** | [**ExtensionRegionalSettingRequest**](ExtensionRegionalSettingRequest.md) |  | [optional] 
**SetupWizardState** | **string** |  | [optional] 
**PartnerId** | **string** | Additional extension identifier created by partner application and applied on client side | [optional] 
**IvrPin** | **string** | IVR PIN | [optional] 
**Password** | **string** | Password for extension | [optional] 
**CallQueueInfo** | [**CallQueueInfoRequest**](CallQueueInfoRequest.md) |  | [optional] 
**Transition** | [**UserTransitionInfo**](UserTransitionInfo.md) |  | [optional] 
**CustomFields** | [**List&lt;CustomFieldInfo&gt;**](CustomFieldInfo.md) |  | [optional] 
**Hidden** | **bool** | Hides extension from showing in company directory. Supported for extensions of User type only | [optional] 
**Site** | [**AutomaticLocationUpdatesSiteInfo**](AutomaticLocationUpdatesSiteInfo.md) |  | [optional] 
**Type** | **string** | Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
**References** | [**List&lt;ReferenceInfo&gt;**](ReferenceInfo.md) | List of non-RC internal identifiers assigned to an extension | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

