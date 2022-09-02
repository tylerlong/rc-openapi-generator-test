
# Org.OpenAPITools.Model.AccountHistorySearchPublicRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventTimeFrom** | **DateTime** | UTC formatted datetime (RFC3339)  2019-10-12T07:20:50.52Z  Default: current time | [optional] 
**EventTimeTo** | **DateTime** | UTC formatted datetime (RFC3339)  2019-10-12T07:20:50.52Z  Default: dateFrom + 24h | [optional] 
**InitiatorIds** | **List&lt;string&gt;** | List of extension IDs who is the user of changes. | [optional] 
**Page** | **int** | Page number of the page you want to jump to. | [optional] 
**PerPage** | **int** | Number of records returned per page. | [optional] 
**TargetIds** | **List&lt;string&gt;** | List of extension IDs (users) affected by this action. | [optional] 
**SiteId** | **string** | A filter to apply by site ID | [optional] 
**ActionIds** | **List&lt;string&gt;** | List of action IDs (exact keys) to search for. Or you can use the excludeActionIds option. | [optional] 
**SearchString** | **string** | List of fields to apply search on:  initiator.name initiator.role initiator.extensionNumber target.name target.extensionNumber details.parameters.value | [optional] 
**ExcludeActionIds** | **List&lt;string&gt;** | List of action IDs (exact keys) to exclude from your search. Or you can use the actionIds option. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

