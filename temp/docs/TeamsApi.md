# Org.OpenAPITools.Api.TeamsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGlipTeamMembers**](TeamsApi.md#addglipteammembers) | **POST** /restapi/v1.0/glip/teams/{chatId}/add | Add Team Members
[**ArchiveGlipTeam**](TeamsApi.md#archiveglipteam) | **POST** /restapi/v1.0/glip/teams/{chatId}/archive | Archive Team
[**CreateGlipTeam**](TeamsApi.md#createglipteam) | **POST** /restapi/v1.0/glip/teams | Create Team
[**DeleteGlipTeam**](TeamsApi.md#deleteglipteam) | **DELETE** /restapi/v1.0/glip/teams/{chatId} | Delete Team
[**JoinGlipTeam**](TeamsApi.md#joinglipteam) | **POST** /restapi/v1.0/glip/teams/{chatId}/join | Join Team
[**LeaveGlipTeam**](TeamsApi.md#leaveglipteam) | **POST** /restapi/v1.0/glip/teams/{chatId}/leave | Leave Team
[**ListGlipTeams**](TeamsApi.md#listglipteams) | **GET** /restapi/v1.0/glip/teams | Get Teams
[**PatchGlipEveryone**](TeamsApi.md#patchglipeveryone) | **PATCH** /restapi/v1.0/glip/everyone | Update Everyone Сhat
[**PatchGlipTeam**](TeamsApi.md#patchglipteam) | **PATCH** /restapi/v1.0/glip/teams/{chatId} | Update Team
[**ReadGlipEveryone**](TeamsApi.md#readglipeveryone) | **GET** /restapi/v1.0/glip/everyone | Get Everyone Chat
[**ReadGlipTeam**](TeamsApi.md#readglipteam) | **GET** /restapi/v1.0/glip/teams/{chatId} | Get Team
[**RemoveGlipTeamMembers**](TeamsApi.md#removeglipteammembers) | **POST** /restapi/v1.0/glip/teams/{chatId}/remove | Remove Team Members
[**UnarchiveGlipTeam**](TeamsApi.md#unarchiveglipteam) | **POST** /restapi/v1.0/glip/teams/{chatId}/unarchive | Unarchive Team



## AddGlipTeamMembers

> void AddGlipTeamMembers (string chatId, GlipPostMembersListBody glipPostMembersListBody)

Add Team Members

Adds members to the specified team. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddGlipTeamMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to add members to.
            var glipPostMembersListBody = new GlipPostMembersListBody(); // GlipPostMembersListBody | JSON body

            try
            {
                // Add Team Members
                apiInstance.AddGlipTeamMembers(chatId, glipPostMembersListBody);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.AddGlipTeamMembers: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to add members to. | 
 **glipPostMembersListBody** | [**GlipPostMembersListBody**](GlipPostMembersListBody.md)| JSON body | 

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
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | User is not Team Admin. |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArchiveGlipTeam

> void ArchiveGlipTeam (string chatId)

Archive Team

Changes the status of the specified team to 'Archived'. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to be archived.

            try
            {
                // Archive Team
                apiInstance.ArchiveGlipTeam(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.ArchiveGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to be archived. | 

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
| **205** | Reset Content |  -  |
| **403** | User is not Team Admin |  -  |
| **404** | Team Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateGlipTeam

> GlipTeamInfo CreateGlipTeam (GlipPostTeamBody glipPostTeamBody)

Create Team

Creates a team, and adds a list of people to the team.  A team is a chat between 2 and more (unlimited number) participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var glipPostTeamBody = new GlipPostTeamBody(); // GlipPostTeamBody | JSON body

            try
            {
                // Create Team
                GlipTeamInfo result = apiInstance.CreateGlipTeam(glipPostTeamBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.CreateGlipTeam: " + e.Message );
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
 **glipPostTeamBody** | [**GlipPostTeamBody**](GlipPostTeamBody.md)| JSON body | 

### Return type

[**GlipTeamInfo**](GlipTeamInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | One of body parameters has invalid value. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteGlipTeam

> void DeleteGlipTeam (string chatId)

Delete Team

Deletes the specified team. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team.

            try
            {
                // Delete Team
                apiInstance.DeleteGlipTeam(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team. | 

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
| **403** | User is not Team Admin. |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## JoinGlipTeam

> void JoinGlipTeam (string chatId)

Join Team

Adds the current user to the specified team. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class JoinGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to be joined.

            try
            {
                // Join Team
                apiInstance.JoinGlipTeam(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.JoinGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to be joined. | 

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
| **205** | Reset Content |  -  |
| **403** | Team status is not Active or Team is not public |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LeaveGlipTeam

> void LeaveGlipTeam (string chatId)

Leave Team

Removes the current user from the specified team. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeaveGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to be left.

            try
            {
                // Leave Team
                apiInstance.LeaveGlipTeam(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.LeaveGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to be left. | 

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
| **205** | Reset Content. |  -  |
| **403** | Team status is not Active. |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipTeams

> GlipTeamsList ListGlipTeams (int? recordCount = null, string pageToken = null)

Get Teams

Returns the list of teams where the user is a member (both archived and active) combined with a list of public teams that can be joined by the current user. All records in response are sorted by creation time of a chat in ascending order. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipTeamsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var recordCount = 30;  // int? | Number of teams to be fetched by one request. The maximum value is 250, by default - 30 (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Pagination token. (optional) 

            try
            {
                // Get Teams
                GlipTeamsList result = apiInstance.ListGlipTeams(recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.ListGlipTeams: " + e.Message );
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
 **recordCount** | **int?**| Number of teams to be fetched by one request. The maximum value is 250, by default - 30 | [optional] [default to 30]
 **pageToken** | **string**| Pagination token. | [optional] 

### Return type

[**GlipTeamsList**](GlipTeamsList.md)

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


## PatchGlipEveryone

> GlipEveryoneInfo PatchGlipEveryone (UpdateGlipEveryoneRequest updateGlipEveryoneRequest = null)

Update Everyone Сhat

Updates Everyone chat information. Everyone chat is a company level chat including all employees; assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchGlipEveryoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var updateGlipEveryoneRequest = new UpdateGlipEveryoneRequest(); // UpdateGlipEveryoneRequest | JSON body (optional) 

            try
            {
                // Update Everyone Сhat
                GlipEveryoneInfo result = apiInstance.PatchGlipEveryone(updateGlipEveryoneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.PatchGlipEveryone: " + e.Message );
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
 **updateGlipEveryoneRequest** | [**UpdateGlipEveryoneRequest**](UpdateGlipEveryoneRequest.md)| JSON body | [optional] 

### Return type

[**GlipEveryoneInfo**](GlipEveryoneInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Chat Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchGlipTeam

> GlipTeamInfo PatchGlipTeam (string chatId, GlipPatchTeamBody glipPatchTeamBody)

Update Team

Updates the name and description of the specified team. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to be updated.
            var glipPatchTeamBody = new GlipPatchTeamBody(); // GlipPatchTeamBody | JSON body

            try
            {
                // Update Team
                GlipTeamInfo result = apiInstance.PatchGlipTeam(chatId, glipPatchTeamBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.PatchGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to be updated. | 
 **glipPatchTeamBody** | [**GlipPatchTeamBody**](GlipPatchTeamBody.md)| JSON body | 

### Return type

[**GlipTeamInfo**](GlipTeamInfo.md)

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
| **403** | User is not Team Admin or Team is not active. |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipEveryone

> GlipEveryoneInfo ReadGlipEveryone ()

Get Everyone Chat

Returns information about Everyone chat, which is a company level chat including all employees; assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipEveryoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);

            try
            {
                // Get Everyone Chat
                GlipEveryoneInfo result = apiInstance.ReadGlipEveryone();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.ReadGlipEveryone: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**GlipEveryoneInfo**](GlipEveryoneInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Chat Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipTeam

> GlipTeamInfo ReadGlipTeam (string chatId)

Get Team

Returns information about the specified team. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to be returned.

            try
            {
                // Get Team
                GlipTeamInfo result = apiInstance.ReadGlipTeam(chatId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.ReadGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to be returned. | 

### Return type

[**GlipTeamInfo**](GlipTeamInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveGlipTeamMembers

> void RemoveGlipTeamMembers (string chatId, GlipPostMembersIdsListBody glipPostMembersIdsListBody)

Remove Team Members

Removes members from the specified team. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RemoveGlipTeamMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to remove members from.
            var glipPostMembersIdsListBody = new GlipPostMembersIdsListBody(); // GlipPostMembersIdsListBody | JSON body

            try
            {
                // Remove Team Members
                apiInstance.RemoveGlipTeamMembers(chatId, glipPostMembersIdsListBody);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.RemoveGlipTeamMembers: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to remove members from. | 
 **glipPostMembersIdsListBody** | [**GlipPostMembersIdsListBody**](GlipPostMembersIdsListBody.md)| JSON body | 

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
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | User is not Team Admin. |  -  |
| **404** | Team Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnarchiveGlipTeam

> void UnarchiveGlipTeam (string chatId)

Unarchive Team

Changes the status of the specified team to 'Active'. A team is a chat between 2 and more participants assigned with specific name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UnarchiveGlipTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a team to be made active.

            try
            {
                // Unarchive Team
                apiInstance.UnarchiveGlipTeam(chatId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.UnarchiveGlipTeam: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a team to be made active. | 

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
| **205** | Reset Content |  -  |
| **403** | User is not Team Admin |  -  |
| **404** | Team Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

