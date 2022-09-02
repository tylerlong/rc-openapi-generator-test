
# Org.OpenAPITools.Model.GlipPostEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a post | [optional] 
**EventType** | **string** | Type of a post event | [optional] 
**GroupId** | **string** | Internal identifier of a group a post belongs to | [optional] 
**Type** | **string** | Type of a post. &#39;TextMessage&#39; - an incoming text message; &#39;PersonJoined&#39; - a message notifying that person has joined a conversation; &#39;PersonsAdded&#39; - a message notifying that a person(s) were added to a conversation | [optional] 
**Text** | **string** | For &#39;TextMessage&#39; post type only. Message text | [optional] 
**CreatorId** | **string** | Internal identifier of a user - author of a post | [optional] 
**AddedPersonIds** | **List&lt;string&gt;** | For PersonsAdded post type only. Identifiers of persons added to a group | [optional] 
**RemovedPersonIds** | **List&lt;string&gt;** | For PersonsRemoved post type only. Identifiers of persons removed from a group | [optional] 
**Mentions** | [**List&lt;GlipMentionsInfo&gt;**](GlipMentionsInfo.md) | List of mentions in post text with names. | [optional] 
**CreationTime** | **DateTime** | Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 
**LastModifiedTime** | **DateTime** | Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

