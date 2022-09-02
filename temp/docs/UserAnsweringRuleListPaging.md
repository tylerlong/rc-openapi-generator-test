
# Org.OpenAPITools.Model.UserAnsweringRuleListPaging

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Page** | **int** | The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage&#x3D;0 was requested) | [optional] 
**TotalPages** | **int** | The total number of pages in a dataset. | [optional] 
**PerPage** | **int** | Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied | [optional] 
**TotalElements** | **int** | The total number of elements in a dataset. | [optional] 
**PageStart** | **int** | The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty | [optional] 
**PageEnd** | **int** | The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

