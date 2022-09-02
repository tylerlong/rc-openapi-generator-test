# Org.OpenAPITools.Api.ExtensionsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExtension**](ExtensionsApi.md#createextension) | **POST** /restapi/v1.0/account/{accountId}/extension | Create Extension
[**ExtensionBulkUpdate**](ExtensionsApi.md#extensionbulkupdate) | **POST** /restapi/v1.0/account/{accountId}/extension-bulk-update | Update Multiple Extensions
[**GetExtensionBulkUpdateTask**](ExtensionsApi.md#getextensionbulkupdatetask) | **GET** /restapi/v1.0/account/{accountId}/extension-bulk-update/tasks/{taskId} | Get Update Task Status
[**ListExtensions**](ExtensionsApi.md#listextensions) | **GET** /restapi/v1.0/account/{accountId}/extension | Get Extension List
[**ListUserTemplates**](ExtensionsApi.md#listusertemplates) | **GET** /restapi/v1.0/account/{accountId}/templates | Get User Template List
[**ReadUserTemplate**](ExtensionsApi.md#readusertemplate) | **GET** /restapi/v1.0/account/{accountId}/templates/{templateId} | Get User Template



## CreateExtension

> ExtensionCreationResponse CreateExtension (string accountId, ExtensionCreationRequest extensionCreationRequest)

Create Extension

Creates an extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateExtensionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExtensionsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionCreationRequest = new ExtensionCreationRequest(); // ExtensionCreationRequest | JSON body

            try
            {
                // Create Extension
                ExtensionCreationResponse result = apiInstance.CreateExtension(accountId, extensionCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExtensionsApi.CreateExtension: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **extensionCreationRequest** | [**ExtensionCreationRequest**](ExtensionCreationRequest.md)| JSON body | 

### Return type

[**ExtensionCreationResponse**](ExtensionCreationResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExtensionBulkUpdate

> ExtensionBulkUpdateTaskResource ExtensionBulkUpdate (string accountId, ExtensionBulkUpdateRequest extensionBulkUpdateRequest)

Update Multiple Extensions

Updates multiple extensions at once. Maximum 500 extensions can be updated per request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExtensionBulkUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExtensionsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionBulkUpdateRequest = new ExtensionBulkUpdateRequest(); // ExtensionBulkUpdateRequest | JSON body

            try
            {
                // Update Multiple Extensions
                ExtensionBulkUpdateTaskResource result = apiInstance.ExtensionBulkUpdate(accountId, extensionBulkUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExtensionsApi.ExtensionBulkUpdate: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **extensionBulkUpdateRequest** | [**ExtensionBulkUpdateRequest**](ExtensionBulkUpdateRequest.md)| JSON body | 

### Return type

[**ExtensionBulkUpdateTaskResource**](ExtensionBulkUpdateTaskResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetExtensionBulkUpdateTask

> ExtensionBulkUpdateTaskResource GetExtensionBulkUpdateTask (string accountId, string taskId)

Get Update Task Status

Returns the status of multiple extension update task

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExtensionBulkUpdateTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExtensionsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var taskId = "taskId_example";  // string | Internal identifier of a task

            try
            {
                // Get Update Task Status
                ExtensionBulkUpdateTaskResource result = apiInstance.GetExtensionBulkUpdateTask(accountId, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExtensionsApi.GetExtensionBulkUpdateTask: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **taskId** | **string**| Internal identifier of a task | 

### Return type

[**ExtensionBulkUpdateTaskResource**](ExtensionBulkUpdateTaskResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListExtensions

> GetExtensionListResponse ListExtensions (string accountId, string extensionNumber = null, string email = null, long? page = null, long? perPage = null, List<string> status = null, List<string> type = null)

Get Extension List

Returns the list of extensions created for a particular account. All types of extensions are included in this list.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListExtensionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExtensionsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionNumber = "extensionNumber_example";  // string | Number of extension to be retrieved (optional) 
            var email = alice.smith@example.com&email=bob.johnson@example.com;  // string | Extension email address. Multiple values are accepted (optional) 
            var page = 1L;  // long? | Indicates the page number to retrieve. Only positive number values are allowed (optional)  (default to 1)
            var perPage = 100L;  // long? | Indicates the page size (number of items) (optional)  (default to 100)
            var status = new List<string>(); // List<string> | Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without `extensionNumber` attribute are returned. If not specified, then all extensions are returned. (optional) 
            var type = new List<string>(); // List<string> | Extension type. Multiple values are supported. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology (optional) 

            try
            {
                // Get Extension List
                GetExtensionListResponse result = apiInstance.ListExtensions(accountId, extensionNumber, email, page, perPage, status, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExtensionsApi.ListExtensions: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **extensionNumber** | **string**| Number of extension to be retrieved | [optional] 
 **email** | **string**| Extension email address. Multiple values are accepted | [optional] 
 **page** | **long?**| Indicates the page number to retrieve. Only positive number values are allowed | [optional] [default to 1]
 **perPage** | **long?**| Indicates the page size (number of items) | [optional] [default to 100]
 **status** | [**List&lt;string&gt;**](string.md)| Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without &#x60;extensionNumber&#x60; attribute are returned. If not specified, then all extensions are returned. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Extension type. Multiple values are supported. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 

### Return type

[**GetExtensionListResponse**](GetExtensionListResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListUserTemplates

> UserTemplates ListUserTemplates (string accountId, string type = null, string page = null, string perPage = null)

Get User Template List

Returns the list of user templates for the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListUserTemplatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExtensionsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var type = "UserSettings";  // string |  (optional) 
            var page = "page_example";  // string |  (optional) 
            var perPage = "perPage_example";  // string |  (optional) 

            try
            {
                // Get User Template List
                UserTemplates result = apiInstance.ListUserTemplates(accountId, type, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExtensionsApi.ListUserTemplates: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **type** | **string**|  | [optional] 
 **page** | **string**|  | [optional] 
 **perPage** | **string**|  | [optional] 

### Return type

[**UserTemplates**](UserTemplates.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadUserTemplate

> TemplateInfo ReadUserTemplate (string accountId, string templateId)

Get User Template

Returns the user template by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExtensionsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var templateId = "templateId_example";  // string | 

            try
            {
                // Get User Template
                TemplateInfo result = apiInstance.ReadUserTemplate(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExtensionsApi.ReadUserTemplate: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **templateId** | **string**|  | 

### Return type

[**TemplateInfo**](TemplateInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

