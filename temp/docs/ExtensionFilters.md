
# Org.OpenAPITools.Model.ExtensionFilters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromIds** | **List&lt;string&gt;** | List of extension ids to match against incoming calls, joined via OR condition. Only applicable for &#x60;groupByMembers&#x60; options and Users, IVRs, SharedLines and Queues in &#x60;groupBy&#x60; | [optional] 
**ToIds** | **List&lt;string&gt;** | List of extension ids to match against outgoing calls, joined via OR condition. Limited to the extension id that first accepted the call. Only applicable for &#x60;groupByMembers&#x60; options and Users, IVRs and SharedLines in &#x60;groupBy&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

