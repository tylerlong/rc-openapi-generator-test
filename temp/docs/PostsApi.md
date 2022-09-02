# Org.OpenAPITools.Api.PostsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGlipCard**](PostsApi.md#createglipcard) | **POST** /restapi/v1.0/glip/cards | Create Card
[**CreateGlipFile**](PostsApi.md#createglipfile) | **POST** /restapi/v1.0/glip/files | Upload File
[**CreateGlipGroupPost**](PostsApi.md#createglipgrouppost) | **POST** /restapi/v1.0/glip/groups/{groupId}/posts | Create Post in Group
[**CreateGlipPost**](PostsApi.md#createglippost) | **POST** /restapi/v1.0/glip/chats/{chatId}/posts | Create Post
[**CreatePost**](PostsApi.md#createpost) | **POST** /restapi/v1.0/glip/posts | Create Post
[**DeleteGlipCard**](PostsApi.md#deleteglipcard) | **DELETE** /restapi/v1.0/glip/cards/{cardId} | Delete Card
[**DeleteGlipPost**](PostsApi.md#deleteglippost) | **DELETE** /restapi/v1.0/glip/chats/{chatId}/posts/{postId} | Delete Post
[**ListGlipGroupPosts**](PostsApi.md#listglipgroupposts) | **GET** /restapi/v1.0/glip/groups/{groupId}/posts | Get Group Posts
[**ListGlipPosts**](PostsApi.md#listglipposts) | **GET** /restapi/v1.0/glip/posts | Get Posts
[**PatchGlipPost**](PostsApi.md#patchglippost) | **PATCH** /restapi/v1.0/glip/chats/{chatId}/posts/{postId} | Update Post
[**ReadGlipCard**](PostsApi.md#readglipcard) | **GET** /restapi/v1.0/glip/cards/{cardId} | Get Card
[**ReadGlipPost**](PostsApi.md#readglippost) | **GET** /restapi/v1.0/glip/chats/{chatId}/posts/{postId} | Get Post
[**ReadGlipPosts**](PostsApi.md#readglipposts) | **GET** /restapi/v1.0/glip/chats/{chatId}/posts | Get Posts
[**UpdateGlipCard**](PostsApi.md#updateglipcard) | **PUT** /restapi/v1.0/glip/cards/{cardId} | Update Card
[**UpdateGlipPostText**](PostsApi.md#updateglipposttext) | **PUT** /restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text | Update Post



## CreateGlipCard

> GlipMessageAttachmentInfo CreateGlipCard (GlipMessageAttachmentInfoRequest glipMessageAttachmentInfoRequest, long? groupId = null)

Create Card

Creates a new message.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var glipMessageAttachmentInfoRequest = new GlipMessageAttachmentInfoRequest(); // GlipMessageAttachmentInfoRequest | 
            var groupId = 789L;  // long? | Internal identifier of a group where to create a post with the card (optional) 

            try
            {
                // Create Card
                GlipMessageAttachmentInfo result = apiInstance.CreateGlipCard(glipMessageAttachmentInfoRequest, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.CreateGlipCard: " + e.Message );
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
 **glipMessageAttachmentInfoRequest** | [**GlipMessageAttachmentInfoRequest**](GlipMessageAttachmentInfoRequest.md)|  | 
 **groupId** | **long?**| Internal identifier of a group where to create a post with the card | [optional] 

### Return type

[**GlipMessageAttachmentInfo**](GlipMessageAttachmentInfo.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateGlipFile

> PostGlipFile CreateGlipFile (System.IO.Stream body, long? groupId = null, string name = null)

Upload File

Posts a file.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The file (binary or multipart/form-data) to upload
            var groupId = 789L;  // long? | Internal identifier of a group to which the post with attachment will be added to (optional) 
            var name = "name_example";  // string | Name of a file attached (optional) 

            try
            {
                // Upload File
                PostGlipFile result = apiInstance.CreateGlipFile(body, groupId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.CreateGlipFile: " + e.Message );
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
 **body** | **System.IO.Stream**| The file (binary or multipart/form-data) to upload | 
 **groupId** | **long?**| Internal identifier of a group to which the post with attachment will be added to | [optional] 
 **name** | **string**| Name of a file attached | [optional] 

### Return type

[**PostGlipFile**](PostGlipFile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **415** | Media type is not supported |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateGlipGroupPost

> GlipPostInfo CreateGlipGroupPost (string groupId, GlipCreatePost glipCreatePost)

Create Post in Group

Creates a new post in a group specified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipGroupPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group.
            var glipCreatePost = new GlipCreatePost(); // GlipCreatePost | 

            try
            {
                // Create Post in Group
                GlipPostInfo result = apiInstance.CreateGlipGroupPost(groupId, glipCreatePost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.CreateGlipGroupPost: " + e.Message );
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
 **groupId** | **string**| Internal identifier of a group. | 
 **glipCreatePost** | [**GlipCreatePost**](GlipCreatePost.md)|  | 

### Return type

[**GlipPostInfo**](GlipPostInfo.md)

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
| **404** | Group not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateGlipPost

> GlipPostInfo CreateGlipPost (string chatId, GlipPostPostBody glipPostPostBody)

Create Post

Creates a post in the chat specified in path. Any mention can be added within the `text` attribute of the request body in .md format - `![:Type](id)`, where `type` is one of (Person, Team, File, Note, Task, Event, Link, Card) and `id` is a unique identifier of the mentioned object of the specified type. Attachments of the following types (File, Card, Event, Note) can also be added to a post by passing type and ID of attachment(s) in request body.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat.
            var glipPostPostBody = new GlipPostPostBody(); // GlipPostPostBody | JSON body

            try
            {
                // Create Post
                GlipPostInfo result = apiInstance.CreateGlipPost(chatId, glipPostPostBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.CreateGlipPost: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat. | 
 **glipPostPostBody** | [**GlipPostPostBody**](GlipPostPostBody.md)| JSON body | 

### Return type

[**GlipPostInfo**](GlipPostInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | One of body parameters has invalid value. |  -  |
| **404** | Resource for parameter [chatId] is not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePost

> GlipPostInfo CreatePost (GlipCreatePost glipCreatePost)

Create Post

Creates a post.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var glipCreatePost = new GlipCreatePost(); // GlipCreatePost | JSON body

            try
            {
                // Create Post
                GlipPostInfo result = apiInstance.CreatePost(glipCreatePost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.CreatePost: " + e.Message );
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
 **glipCreatePost** | [**GlipCreatePost**](GlipCreatePost.md)| JSON body | 

### Return type

[**GlipPostInfo**](GlipPostInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Group not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteGlipCard

> void DeleteGlipCard (string cardId)

Delete Card

Deletes a card by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGlipCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var cardId = "cardId_example";  // string | Card ID to be deleted.

            try
            {
                // Delete Card
                apiInstance.DeleteGlipCard(cardId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.DeleteGlipCard: " + e.Message );
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
 **cardId** | **string**| Card ID to be deleted. | 

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
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Card not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteGlipPost

> void DeleteGlipPost (string chatId, string postId)

Delete Post

Deletes the specified post from the chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGlipPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat.
            var postId = "postId_example";  // string | Internal identifier of a post to be deleted.

            try
            {
                // Delete Post
                apiInstance.DeleteGlipPost(chatId, postId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.DeleteGlipPost: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat. | 
 **postId** | **string**| Internal identifier of a post to be deleted. | 

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
| **204** | No Content. |  -  |
| **403** | Requestor has no permissions to do this action. |  -  |
| **404** | Post Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipGroupPosts

> GlipPosts ListGlipGroupPosts (string groupId, int? recordCount = null, string pageToken = null)

Get Group Posts

Returns posts which are available for the current user by group ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipGroupPostsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group
            var recordCount = 30;  // int? | Max number of records to be returned (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Pagination token (optional) 

            try
            {
                // Get Group Posts
                GlipPosts result = apiInstance.ListGlipGroupPosts(groupId, recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.ListGlipGroupPosts: " + e.Message );
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
 **recordCount** | **int?**| Max number of records to be returned | [optional] [default to 30]
 **pageToken** | **string**| Pagination token | [optional] 

### Return type

[**GlipPosts**](GlipPosts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Group with specified ID is not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipPosts

> GlipPosts ListGlipPosts (string groupId = null, string pageToken = null, long? recordCount = null)

Get Posts

Returns posts available for the current user by group ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipPostsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Identifier of a group to filter posts (optional) 
            var pageToken = "pageToken_example";  // string | Token of a page to be returned (optional) 
            var recordCount = 30L;  // long? | Number of records to be returned. The maximum value is 250, by default - 30 (optional)  (default to 30)

            try
            {
                // Get Posts
                GlipPosts result = apiInstance.ListGlipPosts(groupId, pageToken, recordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.ListGlipPosts: " + e.Message );
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
 **groupId** | **string**| Identifier of a group to filter posts | [optional] 
 **pageToken** | **string**| Token of a page to be returned | [optional] 
 **recordCount** | **long?**| Number of records to be returned. The maximum value is 250, by default - 30 | [optional] [default to 30]

### Return type

[**GlipPosts**](GlipPosts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Group with the specified ID is not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchGlipPost

> GlipPostInfo PatchGlipPost (string chatId, string postId, GlipPatchPostBody glipPatchPostBody)

Update Post

Updates a specific post within a chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchGlipPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat.
            var postId = "postId_example";  // string | Internal identifier of a post to be updated.
            var glipPatchPostBody = new GlipPatchPostBody(); // GlipPatchPostBody | JSON body

            try
            {
                // Update Post
                GlipPostInfo result = apiInstance.PatchGlipPost(chatId, postId, glipPatchPostBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.PatchGlipPost: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat. | 
 **postId** | **string**| Internal identifier of a post to be updated. | 
 **glipPatchPostBody** | [**GlipPatchPostBody**](GlipPatchPostBody.md)| JSON body | 

### Return type

[**GlipPostInfo**](GlipPostInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | One of body parameters has invalid value. |  -  |
| **403** | Requestor has no permissions to do this action. |  -  |
| **404** | Chat not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipCard

> GlipMessageAttachmentInfo ReadGlipCard (List<string> cardId)

Get Card

Returns card(s) with given id(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var cardId = new List<string>(); // List<string> | Internal identifier of a card or comma separated list of card IDs.

            try
            {
                // Get Card
                GlipMessageAttachmentInfo result = apiInstance.ReadGlipCard(cardId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.ReadGlipCard: " + e.Message );
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
 **cardId** | [**List&lt;string&gt;**](string.md)| Internal identifier of a card or comma separated list of card IDs. | 

### Return type

[**GlipMessageAttachmentInfo**](GlipMessageAttachmentInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, multipart/mixed


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Card not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipPost

> GlipPostInfo ReadGlipPost (string chatId, string postId)

Get Post

Returns information about the specified post.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat.
            var postId = "postId_example";  // string | Internal identifier of a post.

            try
            {
                // Get Post
                GlipPostInfo result = apiInstance.ReadGlipPost(chatId, postId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.ReadGlipPost: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat. | 
 **postId** | **string**| Internal identifier of a post. | 

### Return type

[**GlipPostInfo**](GlipPostInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Post Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipPosts

> GlipPostsList ReadGlipPosts (string chatId, int? recordCount = null, string pageToken = null)

Get Posts

Returns a list of posts from the specified chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipPostsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat
            var recordCount = 30;  // int? | Max number of posts to be fetched by one request (not more than 250) (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Pagination token. (optional) 

            try
            {
                // Get Posts
                GlipPostsList result = apiInstance.ReadGlipPosts(chatId, recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.ReadGlipPosts: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat | 
 **recordCount** | **int?**| Max number of posts to be fetched by one request (not more than 250) | [optional] [default to 30]
 **pageToken** | **string**| Pagination token. | [optional] 

### Return type

[**GlipPostsList**](GlipPostsList.md)

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


## UpdateGlipCard

> void UpdateGlipCard (string cardId, GlipMessageAttachmentInfoRequest glipMessageAttachmentInfoRequest)

Update Card

Updates a card.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateGlipCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var cardId = "cardId_example";  // string | Internal identifier of a card
            var glipMessageAttachmentInfoRequest = new GlipMessageAttachmentInfoRequest(); // GlipMessageAttachmentInfoRequest | 

            try
            {
                // Update Card
                apiInstance.UpdateGlipCard(cardId, glipMessageAttachmentInfoRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.UpdateGlipCard: " + e.Message );
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
 **cardId** | **string**| Internal identifier of a card | 
 **glipMessageAttachmentInfoRequest** | [**GlipMessageAttachmentInfoRequest**](GlipMessageAttachmentInfoRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Card for update does not exist. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateGlipPostText

> string UpdateGlipPostText (string groupId, string postId, string body)

Update Post

Modifies text of a post.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateGlipPostTextExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group
            var postId = "postId_example";  // string | Internal identifier of a post
            var body = "body_example";  // string | 

            try
            {
                // Update Post
                string result = apiInstance.UpdateGlipPostText(groupId, postId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PostsApi.UpdateGlipPostText: " + e.Message );
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
 **postId** | **string**| Internal identifier of a post | 
 **body** | **string**|  | 

### Return type

**string**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: text/*
- **Accept**: text/plain, application/json


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

