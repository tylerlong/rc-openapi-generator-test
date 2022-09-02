
# Org.OpenAPITools.Model.ExtensionCreationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal identifier of an extension | [optional] 
**Uri** | **string** | Canonical URI of an extension | [optional] 
**Contact** | [**ContactInfo**](ContactInfo.md) |  | [optional] 
**CustomFields** | [**List&lt;CustomFieldInfo&gt;**](CustomFieldInfo.md) |  | [optional] 
**ExtensionNumber** | **string** | Number of extension | [optional] 
**Name** | **string** | Extension name. For user extension types the value is a combination of the specified first name and last name | [optional] 
**PartnerId** | **string** | For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid &#x3D; XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension | [optional] 
**Permissions** | [**ExtensionPermissions**](ExtensionPermissions.md) |  | [optional] 
**ProfileImage** | [**ProfileImageInfo**](ProfileImageInfo.md) |  | [optional] 
**References** | [**List&lt;ReferenceInfo&gt;**](ReferenceInfo.md) | List of non-RC internal identifiers assigned to an extension | [optional] 
**RegionalSettings** | [**RegionalSettings**](RegionalSettings.md) |  | [optional] 
**ServiceFeatures** | [**List&lt;ExtensionServiceFeatureInfo&gt;**](ExtensionServiceFeatureInfo.md) | Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features | [optional] 
**SetupWizardState** | **string** | Specifies extension configuration wizard state (web service setup). The default value is &#39;NotStarted&#39; | [optional] 
**Site** | [**AutomaticLocationUpdatesSiteInfo**](AutomaticLocationUpdatesSiteInfo.md) |  | [optional] 
**Status** | **string** | Extension current state. If &#39;Unassigned&#39; is specified, then extensions without ‘extensionNumber’ are returned. If not specified, then all extensions are returned | [optional] 
**StatusInfo** | [**ExtensionStatusInfo**](ExtensionStatusInfo.md) |  | [optional] 
**Type** | **string** | Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
**Hidden** | **bool** | Hides extension from showing in company directory. Supported for extensions of User type only | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

