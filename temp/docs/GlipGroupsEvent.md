
# Org.OpenAPITools.Model.GlipGroupsEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a group | [optional] 
**Type** | **string** | Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user | [optional] 
**IsPublic** | **bool** | For &#39;Team&#39; group type only. Team access level | [optional] 
**Name** | **string** | For &#39;Team&#39; group type only. Team name | [optional] 
**Description** | **string** | For &#39;Team&#39; group type only. Team description | [optional] 
**Members** | [**List&lt;GlipMemberInfo&gt;**](GlipMemberInfo.md) | “List of glip members” | [optional] 
**CreationTime** | **DateTime** | Group creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 
**LastModifiedTime** | **DateTime** | Group last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 
**EventType** | **string** | Type of a group event. Only the person who joined/was added to a group will receive &#39;GroupJoined&#39; notification. Only the person who left/was removed from a group will receive &#39;GroupLeft&#39; notification | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

