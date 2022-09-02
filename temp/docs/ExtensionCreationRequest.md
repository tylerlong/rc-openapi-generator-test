
# Org.OpenAPITools.Model.ExtensionCreationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contact** | [**ContactInfoCreationRequest**](ContactInfoCreationRequest.md) |  | [optional] 
**ExtensionNumber** | **string** | Number of extension | [optional] 
**CustomFields** | [**List&lt;CustomFieldInfo&gt;**](CustomFieldInfo.md) |  | [optional] 
**Password** | **string** | Password for extension. If not specified, the password is auto-generated | [optional] 
**References** | [**List&lt;ReferenceInfo&gt;**](ReferenceInfo.md) | List of non-RC internal identifiers assigned to an extension | [optional] 
**RegionalSettings** | [**RegionalSettings**](RegionalSettings.md) |  | [optional] 
**PartnerId** | **string** | Additional extension identifier, created by partner application and applied on client side | [optional] 
**IvrPin** | **string** | IVR PIN | [optional] 
**SetupWizardState** | **string** | Specifies extension configuration wizard state (web service setup). | [optional] [default to SetupWizardStateEnum.NotStarted]
**Site** | [**SiteInfo**](SiteInfo.md) |  | [optional] 
**Status** | **string** | Extension current state | [optional] 
**StatusInfo** | [**ExtensionStatusInfo**](ExtensionStatusInfo.md) |  | [optional] 
**Type** | **string** | Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
**Hidden** | **bool** | Hides extension from showing in company directory. Supported for extensions of User type only. For unassigned extensions the value is set to &#39;True&#39; by default. For assigned extensions the value is set to &#39;False&#39; by default | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

