# Org.OpenAPITools.Api.AdaptiveCardsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGlipAdaptiveCard**](AdaptiveCardsApi.md#createglipadaptivecard) | **POST** /restapi/v1.0/glip/chats/{chatId}/adaptive-cards | Create Adaptive Card
[**DeleteGlipAdaptiveCard**](AdaptiveCardsApi.md#deleteglipadaptivecard) | **DELETE** /restapi/v1.0/glip/adaptive-cards/{cardId} | Delete Adaptive Card
[**GetGlipAdaptiveCard**](AdaptiveCardsApi.md#getglipadaptivecard) | **GET** /restapi/v1.0/glip/adaptive-cards/{cardId} | Get Adaptive Card
[**UpdateGlipAdaptiveCard**](AdaptiveCardsApi.md#updateglipadaptivecard) | **PUT** /restapi/v1.0/glip/adaptive-cards/{cardId} | Update Adaptive Card



## CreateGlipAdaptiveCard

> GlipAdaptiveCardShortInfo CreateGlipAdaptiveCard (string chatId, GlipAdaptiveCardRequest glipAdaptiveCardRequest)

Create Adaptive Card

Creates a new adaptive card in the chat specified in path.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipAdaptiveCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdaptiveCardsApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat
            var glipAdaptiveCardRequest = new GlipAdaptiveCardRequest(); // GlipAdaptiveCardRequest | 

            try
            {
                // Create Adaptive Card
                GlipAdaptiveCardShortInfo result = apiInstance.CreateGlipAdaptiveCard(chatId, glipAdaptiveCardRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdaptiveCardsApi.CreateGlipAdaptiveCard: " + e.Message );
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
 **glipAdaptiveCardRequest** | [**GlipAdaptiveCardRequest**](GlipAdaptiveCardRequest.md)|  | 

### Return type

[**GlipAdaptiveCardShortInfo**](GlipAdaptiveCardShortInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | You do not have permissions to create adaptive card in the specified chat. |  -  |
| **404** | Specified chat ID does not exist. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteGlipAdaptiveCard

> void DeleteGlipAdaptiveCard (string cardId)

Delete Adaptive Card

Deletes an adaptive card by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGlipAdaptiveCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdaptiveCardsApi(Configuration.Default);
            var cardId = "cardId_example";  // string | Adaptive Card ID to be deleted.

            try
            {
                // Delete Adaptive Card
                apiInstance.DeleteGlipAdaptiveCard(cardId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdaptiveCardsApi.DeleteGlipAdaptiveCard: " + e.Message );
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
 **cardId** | **string**| Adaptive Card ID to be deleted. | 

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
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | You do not have permissions to delete specified adaptive card. |  -  |
| **404** | Adaptive Card not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetGlipAdaptiveCard

> GlipAdaptiveCardInfo GetGlipAdaptiveCard (List<string> cardId)

Get Adaptive Card

Returns adaptive card(s) with given id(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGlipAdaptiveCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdaptiveCardsApi(Configuration.Default);
            var cardId = new List<string>(); // List<string> | Internal identifier of an adaptive card, or comma separated list of adaptive cards IDs.

            try
            {
                // Get Adaptive Card
                GlipAdaptiveCardInfo result = apiInstance.GetGlipAdaptiveCard(cardId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdaptiveCardsApi.GetGlipAdaptiveCard: " + e.Message );
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
 **cardId** | [**List&lt;string&gt;**](string.md)| Internal identifier of an adaptive card, or comma separated list of adaptive cards IDs. | 

### Return type

[**GlipAdaptiveCardInfo**](GlipAdaptiveCardInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **207** | Multi-Status |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Adaptive Card not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateGlipAdaptiveCard

> GlipAdaptiveCardShortInfo UpdateGlipAdaptiveCard (string cardId, GlipAdaptiveCardRequest glipAdaptiveCardRequest)

Update Adaptive Card

Updates an adaptive card.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateGlipAdaptiveCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdaptiveCardsApi(Configuration.Default);
            var cardId = "cardId_example";  // string | Internal identifier of an adaptive card
            var glipAdaptiveCardRequest = new GlipAdaptiveCardRequest(); // GlipAdaptiveCardRequest | 

            try
            {
                // Update Adaptive Card
                GlipAdaptiveCardShortInfo result = apiInstance.UpdateGlipAdaptiveCard(cardId, glipAdaptiveCardRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdaptiveCardsApi.UpdateGlipAdaptiveCard: " + e.Message );
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
 **cardId** | **string**| Internal identifier of an adaptive card | 
 **glipAdaptiveCardRequest** | [**GlipAdaptiveCardRequest**](GlipAdaptiveCardRequest.md)|  | 

### Return type

[**GlipAdaptiveCardShortInfo**](GlipAdaptiveCardShortInfo.md)

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
| **403** | You do not have permissions to update specified adaptive card. |  -  |
| **404** | Adaptive Card for update does not exist. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

