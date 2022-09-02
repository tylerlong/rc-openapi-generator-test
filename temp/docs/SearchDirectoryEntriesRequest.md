
# Org.OpenAPITools.Model.SearchDirectoryEntriesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchString** | **string** | String value to filter the contacts. The value specified is searched through the following fields: &#x60;firstName&#x60;, &#x60;lastName&#x60;, &#x60;extensionNumber&#x60;, &#x60;phoneNumber&#x60;, &#x60;email&#x60;, &#x60;jobTitle&#x60;, &#x60;department&#x60; | [optional] 
**SearchFields** | **List&lt;string&gt;** |  | [optional] 
**ShowFederated** | **bool** | If &#39;True&#39; then contacts of all accounts in federation are returned. If &#39;False&#39; then only contacts of the current account are returned, and account section is eliminated in this case | [optional] [default to true]
**ExtensionType** | **string** | Type of extension to filter the contacts. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
**OrderBy** | [**List&lt;OrderBy&gt;**](OrderBy.md) | Sorting settings | [optional] 
**Page** | **int** |  | [optional] 
**PerPage** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

