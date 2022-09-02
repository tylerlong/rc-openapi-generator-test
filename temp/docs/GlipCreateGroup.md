
# Org.OpenAPITools.Model.GlipCreateGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of a group to be created. &#39;PrivateChat&#39; is a group of 2 members. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user | 
**IsPublic** | **bool** | For &#39;Team&#39; group type only. Team access level | [optional] 
**Name** | **string** | For &#39;Team&#39; group type only. Team name | [optional] 
**Description** | **string** | For &#39;Team&#39; group type only. Team description | [optional] 
**Members** | [**List&lt;GlipMemberInfo&gt;**](GlipMemberInfo.md) | “List of glip members. For &#39;PrivateChat&#39; group type 2 members only are supported” | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

