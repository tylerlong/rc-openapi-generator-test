# Org.OpenAPITools.Api.IncomingWebhooksApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateGlipWebhook**](IncomingWebhooksApi.md#activateglipwebhook) | **POST** /restapi/v1.0/glip/webhooks/{webhookId}/activate | Activate Webhook
[**CreateGlipGroupWebhook**](IncomingWebhooksApi.md#createglipgroupwebhook) | **POST** /restapi/v1.0/glip/groups/{groupId}/webhooks | Create Webhook in Group
[**DeleteGlipWebhook**](IncomingWebhooksApi.md#deleteglipwebhook) | **DELETE** /restapi/v1.0/glip/webhooks/{webhookId} | Delete Webhook
[**ListGlipGroupWebhooks**](IncomingWebhooksApi.md#listglipgroupwebhooks) | **GET** /restapi/v1.0/glip/groups/{groupId}/webhooks | Get Webhooks in Group
[**ListGlipWebhooks**](IncomingWebhooksApi.md#listglipwebhooks) | **GET** /restapi/v1.0/glip/webhooks | Get Webhooks
[**ReadGlipWebhook**](IncomingWebhooksApi.md#readglipwebhook) | **GET** /restapi/v1.0/glip/webhooks/{webhookId} | Get Webhook
[**SuspendGlipWebhook**](IncomingWebhooksApi.md#suspendglipwebhook) | **POST** /restapi/v1.0/glip/webhooks/{webhookId}/suspend | Suspend Webhook



## ActivateGlipWebhook

> void ActivateGlipWebhook (string webhookId)

Activate Webhook

Activates a webhook by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivateGlipWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);
            var webhookId = "webhookId_example";  // string | Internal identifier of a webhook

            try
            {
                // Activate Webhook
                apiInstance.ActivateGlipWebhook(webhookId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.ActivateGlipWebhook: " + e.Message );
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
 **webhookId** | **string**| Internal identifier of a webhook | 

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
| **404** | Webhook not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateGlipGroupWebhook

> GlipWebhookInfo CreateGlipGroupWebhook (string groupId)

Create Webhook in Group

Creates a new webhook.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGlipGroupWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group

            try
            {
                // Create Webhook in Group
                GlipWebhookInfo result = apiInstance.CreateGlipGroupWebhook(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.CreateGlipGroupWebhook: " + e.Message );
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

### Return type

[**GlipWebhookInfo**](GlipWebhookInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
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


## DeleteGlipWebhook

> void DeleteGlipWebhook (string webhookId)

Delete Webhook

Deletes a webhook by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGlipWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);
            var webhookId = "webhookId_example";  // string | Internal identifier of a webhook

            try
            {
                // Delete Webhook
                apiInstance.DeleteGlipWebhook(webhookId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.DeleteGlipWebhook: " + e.Message );
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
 **webhookId** | **string**| Internal identifier of a webhook | 

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
| **200** | The resource was deleted successfully. |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Webhook not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGlipGroupWebhooks

> GlipWebhookList ListGlipGroupWebhooks (string groupId)

Get Webhooks in Group

Returns webhooks which are available for the current user by group ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipGroupWebhooksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group

            try
            {
                // Get Webhooks in Group
                GlipWebhookList result = apiInstance.ListGlipGroupWebhooks(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.ListGlipGroupWebhooks: " + e.Message );
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

### Return type

[**GlipWebhookList**](GlipWebhookList.md)

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


## ListGlipWebhooks

> GlipWebhookList ListGlipWebhooks ()

Get Webhooks

Returns the list of all webhooks associated with the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGlipWebhooksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);

            try
            {
                // Get Webhooks
                GlipWebhookList result = apiInstance.ListGlipWebhooks();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.ListGlipWebhooks: " + e.Message );
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

[**GlipWebhookList**](GlipWebhookList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, multipart/mixed


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipWebhook

> GlipWebhookList ReadGlipWebhook (List<string> webhookId)

Get Webhook

Returns webhooks(s) with the specified id(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);
            var webhookId = new List<string>(); // List<string> | Internal identifier of a webhook or comma separated list of webhooks IDs

            try
            {
                // Get Webhook
                GlipWebhookList result = apiInstance.ReadGlipWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.ReadGlipWebhook: " + e.Message );
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
 **webhookId** | [**List&lt;string&gt;**](string.md)| Internal identifier of a webhook or comma separated list of webhooks IDs | 

### Return type

[**GlipWebhookList**](GlipWebhookList.md)

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
| **404** | Webhooks not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SuspendGlipWebhook

> void SuspendGlipWebhook (string webhookId)

Suspend Webhook

Suspends a webhook by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SuspendGlipWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IncomingWebhooksApi(Configuration.Default);
            var webhookId = "webhookId_example";  // string | Internal identifier of a webhook

            try
            {
                // Suspend Webhook
                apiInstance.SuspendGlipWebhook(webhookId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IncomingWebhooksApi.SuspendGlipWebhook: " + e.Message );
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
 **webhookId** | **string**| Internal identifier of a webhook | 

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
| **404** | Webhook not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

