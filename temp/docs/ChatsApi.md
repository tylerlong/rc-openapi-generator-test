# Org.OpenAPITools.Api.ChatsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignGlipGroupMembers**](ChatsApi.md#assignglipgroupmembers) | **POST** /restapi/v1.0/glip/groups/{groupId}/bulk-assign | Edit Group Members
[**CreateGlipGroup**](ChatsApi.md#createglipgroup) | **POST** /restapi/v1.0/glip/groups | Create Group
[**FavoriteGlipChat**](ChatsApi.md#favoriteglipchat) | **POST** /restapi/v1.0/glip/chats/{chatId}/favorite | Add Chat to Favorites
[**ListFavoriteChats**](ChatsApi.md#listfavoritechats) | **GET** /restapi/v1.0/glip/favorites | Get Favorite Chats
[**ListGlipChats**](ChatsApi.md#listglipchats) | **GET** /restapi/v1.0/glip/chats | Get Chats
[**ListGlipGroups**](ChatsApi.md#listglipgroups) | **GET** /restapi/v1.0/glip/groups | Get User Groups
[**ListRecentChats**](ChatsApi.md#listrecentchats) | **GET** /restapi/v1.0/glip/recent/chats | Get Recent Chats
[**MarkChatRead**](ChatsApi.md#markchatread) | **POST** /restapi/v1.0/glip/chats/{chatId}/read | Mark Chat as Read
[**MarkChatUnread**](ChatsApi.md#markchatunread) | **POST** /restapi/v1.0/glip/chats/{chatId}/unread | Mark Chat as Unread
[**ReadGlipChat**](ChatsApi.md#readglipchat) | **GET** /restapi/v1.0/glip/chats/{chatId} | Get Chat
[**ReadGlipGroup**](ChatsApi.md#readglipgroup) | **GET** /restapi/v1.0/glip/groups/{groupId} | Get Group
[**UnfavoriteGlipChat**](ChatsApi.md#unfavoriteglipchat) | **POST** /restapi/v1.0/glip/chats/{chatId}/unfavorite | Remove Chat from Favorites



## AssignGlipGroupMembers

> GlipGroupInfo AssignGlipGroupMembers (string groupId, EditGroupRequest editGroupRequest)

Edit Group Members

Updates group members. **Please note:** Only groups of 'Team' type can be updated. Currently only one operation at a time (either adding or removal) is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignGlipGroupMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group
            var editGroupRequest = new EditGroupRequest(); // EditGroupRequest | JSON body

            try
            {
                // Edit Group Members
                GlipGroupInfo result = apiInstance.AssignGlipGroupMembers(groupId, editGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.AssignGlipGroupMembers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Internal identifier of a group | 
 **editGroupRequest** | [**EditGroupRequest**](EditGroupRequest.md)| JSON body | 

### Return type

[**GlipGroupInfo**](GlipGroupInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateGlipGroup

> GlipGroupInfo CreateGlipGroup (GlipCreateGroup glipCreateGroup)

Create Group

Creates a new private chat/team.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var glipCreateGroup = new GlipCreateGroup(); // GlipCreateGroup | JSON body

            try
            {
                // Create Group
                GlipGroupInfo result = apiInstance.CreateGlipGroup(glipCreateGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.CreateGlipGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **glipCreateGroup** | [**GlipCreateGroup**](GlipCreateGroup.md)| JSON body | 

### Return type

[**GlipGroupInfo**](GlipGroupInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FavoriteGlipChat

> void FavoriteGlipChat (string chatId)

Add Chat to Favorites

Adds the specified chat to the users's list of favorite chats. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FavoriteGlipChatExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat to add to favorite list.

            try
            {
                // Add Chat to Favorites
                apiInstance.FavoriteGlipChat(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.FavoriteGlipChat: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chatId** | **string**| Internal identifier of a chat to add to favorite list. | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Favorite chat list is limited to 250 unique chats |  -  |
| **403** | User is not member of chat |  -  |
| **404** | Chat not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListFavoriteChats

> GlipChatsListWithoutNavigation ListFavoriteChats (int? recordCount = null)

Get Favorite Chats

Returns a list of the current user's favorite chats.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListFavoriteChatsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var recordCount = 30;  // int? | Max number of chats to be fetched by one request (Not more than 250). (optional)  (default to 30)

            try
            {
                // Get Favorite Chats
                GlipChatsListWithoutNavigation result = apiInstance.ListFavoriteChats(recordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.ListFavoriteChats: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordCount** | **int?**| Max number of chats to be fetched by one request (Not more than 250). | [optional] [default to 30]

### Return type

[**GlipChatsListWithoutNavigation**](GlipChatsListWithoutNavigation.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipChats

> GlipChatsList ListGlipChats (List<string> type = null, int? recordCount = null, string pageToken = null)

Get Chats

Returns the list of chats where the user is a member and also public teams that can be joined.  All records in response are sorted by creation time of a chat in ascending order.  **Chat types**  There are multiple types of chats, including:  * **Personal** - each user is given a dedicated \"personal chat\" in which they are the only member. * **Direct** - a chat between two individuals. * **Group** - a chat between three or more named individuals. A \"group\" chat has no name. * **Team** - a chat related to a specific topic. Members can come and go freely from this chat type. * **Everyone** - a special chat containing every individual in a company. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipChatsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var type = new List<string>(); // List<string> | Type of chats to be fetched. By default all type of chats will be fetched (optional) 
            var recordCount = 30;  // int? | Number of chats to be fetched by one request. The maximum value is 250, by default - 30. (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Pagination token. (optional) 

            try
            {
                // Get Chats
                GlipChatsList result = apiInstance.ListGlipChats(type, recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.ListGlipChats: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**List&lt;string&gt;**](string.md)| Type of chats to be fetched. By default all type of chats will be fetched | [optional] 
 **recordCount** | **int?**| Number of chats to be fetched by one request. The maximum value is 250, by default - 30. | [optional] [default to 30]
 **pageToken** | **string**| Pagination token. | [optional] 

### Return type

[**GlipChatsList**](GlipChatsList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipGroups

> GlipGroupList ListGlipGroups (string type = null, int? recordCount = null, string pageToken = null)

Get User Groups

Returns the list of groups where the user is a member.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var type = "Group";  // string | Type of groups to be fetched (by default all type of groups will be fetched) (optional) 
            var recordCount = 30;  // int? | Number of groups to be fetched by one request. The maximum value is 250, by default - 30 (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Pagination token. (optional) 

            try
            {
                // Get User Groups
                GlipGroupList result = apiInstance.ListGlipGroups(type, recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.ListGlipGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of groups to be fetched (by default all type of groups will be fetched) | [optional] 
 **recordCount** | **int?**| Number of groups to be fetched by one request. The maximum value is 250, by default - 30 | [optional] [default to 30]
 **pageToken** | **string**| Pagination token. | [optional] 

### Return type

[**GlipGroupList**](GlipGroupList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Group with the specified ID is not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListRecentChats

> GlipChatsListWithoutNavigation ListRecentChats (List<string> type = null, int? recordCount = null)

Get Recent Chats

Returns recent chats where the user is a member. All records in response are sorted by the `lastModifiedTime` in descending order (the latest changed chat is displayed first on page). **Note** 'Chat' is a general name for all types of threads including *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat including all employees, with a specific name).\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListRecentChatsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var type = new List<string>(); // List<string> | Type of chats to be fetched. By default all chat types are returned (optional) 
            var recordCount = 30;  // int? | Max number of chats to be fetched by one request (Not more than 250). (optional)  (default to 30)

            try
            {
                // Get Recent Chats
                GlipChatsListWithoutNavigation result = apiInstance.ListRecentChats(type, recordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.ListRecentChats: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**List&lt;string&gt;**](string.md)| Type of chats to be fetched. By default all chat types are returned | [optional] 
 **recordCount** | **int?**| Max number of chats to be fetched by one request (Not more than 250). | [optional] [default to 30]

### Return type

[**GlipChatsListWithoutNavigation**](GlipChatsListWithoutNavigation.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MarkChatRead

> void MarkChatRead (string chatId)

Mark Chat as Read

Sets the specified chat status to 'Read' for the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkChatReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Id of chat to be marked

            try
            {
                // Mark Chat as Read
                apiInstance.MarkChatRead(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.MarkChatRead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chatId** | **string**| Id of chat to be marked | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |
| **403** | You have no permissions to mark this chat |  -  |
| **404** | Chat is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MarkChatUnread

> void MarkChatUnread (string chatId)

Mark Chat as Unread

Sets the specified chat status to 'Unread' for the current user. **Note** 'Chat' is a general name for all types of threads including *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat including all employees, with a specific name).\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkChatUnreadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Id of chat to be marked

            try
            {
                // Mark Chat as Unread
                apiInstance.MarkChatUnread(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.MarkChatUnread: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chatId** | **string**| Id of chat to be marked | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |
| **403** | You have no permissions to mark this chat |  -  |
| **404** | Chat is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipChat

> GlipChatInfo ReadGlipChat (string chatId)

Get Chat

Returns information about a chat by ID. **Note** 'Chat' is a general name for all types of threads including *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat including all employees, with a specific name).\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipChatExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat. If tilde (~) is specified, then `/me` (Personal) chat will be returned

            try
            {
                // Get Chat
                GlipChatInfo result = apiInstance.ReadGlipChat(chatId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.ReadGlipChat: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chatId** | **string**| Internal identifier of a chat. If tilde (~) is specified, then &#x60;/me&#x60; (Personal) chat will be returned | 

### Return type

[**GlipChatInfo**](GlipChatInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Chat Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipGroup

> GlipGroupInfo ReadGlipGroup (List<string> groupId)

Get Group

Returns information about a group or multiple groups by their ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var groupId = new List<string>(); // List<string> | Internal identifier of a group to be returned, the maximum number of IDs is 30

            try
            {
                // Get Group
                GlipGroupInfo result = apiInstance.ReadGlipGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.ReadGlipGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | [**List&lt;string&gt;**](string.md)| Internal identifier of a group to be returned, the maximum number of IDs is 30 | 

### Return type

[**GlipGroupInfo**](GlipGroupInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, multipart/mixed


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **207** | Mixed Result |  -  |
| **403** | You do not have permissions to get such kind of information. |  -  |
| **404** | Person Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnfavoriteGlipChat

> void UnfavoriteGlipChat (string chatId)

Remove Chat from Favorites

Removes the specified chat from the users's list of favorite chats.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UnfavoriteGlipChatExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat to remove from favorite list.

            try
            {
                // Remove Chat from Favorites
                apiInstance.UnfavoriteGlipChat(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChatsApi.UnfavoriteGlipChat: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chatId** | **string**| Internal identifier of a chat to remove from favorite list. | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Chat not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

