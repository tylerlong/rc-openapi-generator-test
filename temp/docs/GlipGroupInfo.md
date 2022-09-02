
# Org.OpenAPITools.Model.GlipGroupInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a group | [optional] 
**Type** | **string** | Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user | [optional] 
**IsPublic** | **bool** | For &#39;Team&#39; group type only. Team access level | [optional] 
**Name** | **string** | For &#39;Team&#39; group type only. Team name | [optional] 
**Description** | **string** | For &#39;Team&#39; group type only. Team description | [optional] 
**Members** | **List&lt;string&gt;** | “List of glip members” | [optional] 
**CreationTime** | **DateTime** | Group creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 
**LastModifiedTime** | **DateTime** | Group last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

