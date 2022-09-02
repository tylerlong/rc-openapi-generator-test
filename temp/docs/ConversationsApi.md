# Org.OpenAPITools.Api.ConversationsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGlipConversation**](ConversationsApi.md#createglipconversation) | **POST** /restapi/v1.0/glip/conversations | Create/Open Conversation
[**ListGlipConversations**](ConversationsApi.md#listglipconversations) | **GET** /restapi/v1.0/glip/conversations | Get Conversations
[**ReadGlipConversation**](ConversationsApi.md#readglipconversation) | **GET** /restapi/v1.0/glip/conversations/{chatId} | Get Conversation



## CreateGlipConversation

> GlipConversationInfo CreateGlipConversation (CreateGlipConversationRequest createGlipConversationRequest)

Create/Open Conversation

Creates a new conversation or opens the existing one. If the conversation already exists, then its ID will be returned in response. A conversation is an adhoc discussion between a particular set of users, not featuring any specific name or description; it is a chat of 'Group' type. If you add a person to the existing conversation (group), it creates a whole new conversation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipConversationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi(Configuration.Default);
            var createGlipConversationRequest = new CreateGlipConversationRequest(); // CreateGlipConversationRequest | JSON body

            try
            {
                // Create/Open Conversation
                GlipConversationInfo result = apiInstance.CreateGlipConversation(createGlipConversationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationsApi.CreateGlipConversation: " + e.Message );
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
 **createGlipConversationRequest** | [**CreateGlipConversationRequest**](CreateGlipConversationRequest.md)| JSON body | 

### Return type

[**GlipConversationInfo**](GlipConversationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conversation is opened |  -  |
| **201** | Conversation is created |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipConversations

> GlipConversationsList ListGlipConversations (int? recordCount = null, string pageToken = null)

Get Conversations

Returns the list of conversations where the user is a member. All records in response are sorted by creation time of a conversation in ascending order. Conversation is a chat of the *Group* type.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipConversationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi(Configuration.Default);
            var recordCount = 30;  // int? | Number of conversations to be fetched by one request. The maximum value is 250, by default - 30 (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Pagination token. (optional) 

            try
            {
                // Get Conversations
                GlipConversationsList result = apiInstance.ListGlipConversations(recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationsApi.ListGlipConversations: " + e.Message );
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
 **recordCount** | **int?**| Number of conversations to be fetched by one request. The maximum value is 250, by default - 30 | [optional] [default to 30]
 **pageToken** | **string**| Pagination token. | [optional] 

### Return type

[**GlipConversationsList**](GlipConversationsList.md)

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


## ReadGlipConversation

> GlipConversationInfo ReadGlipConversation (string chatId)

Get Conversation

Returns information about the specified conversation, including the list of conversation participants. A conversation is an adhoc discussion between a particular set of users, not featuring any specific name or description; it is a chat of 'Group' type. If you add a person to the existing conversation, it creates a whole new conversation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipConversationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a conversation to be returned.

            try
            {
                // Get Conversation
                GlipConversationInfo result = apiInstance.ReadGlipConversation(chatId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationsApi.ReadGlipConversation: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a conversation to be returned. | 

### Return type

[**GlipConversationInfo**](GlipConversationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Conversation Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

