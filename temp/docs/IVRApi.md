# Org.OpenAPITools.Api.IVRApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIVRMenu**](IVRApi.md#createivrmenu) | **POST** /restapi/v1.0/account/{accountId}/ivr-menus | Create IVR Menu
[**CreateIVRPrompt**](IVRApi.md#createivrprompt) | **POST** /restapi/v1.0/account/{accountId}/ivr-prompts | Create IVR Prompts
[**DeleteIVRPrompt**](IVRApi.md#deleteivrprompt) | **DELETE** /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId} | Delete IVR Prompt
[**ListIVRPrompts**](IVRApi.md#listivrprompts) | **GET** /restapi/v1.0/account/{accountId}/ivr-prompts | Get IVR Prompt List
[**ReadIVRMenu**](IVRApi.md#readivrmenu) | **GET** /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId} | Get IVR Menu
[**ReadIVRPrompt**](IVRApi.md#readivrprompt) | **GET** /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId} | Get IVR Prompt
[**ReadIVRPromptContent**](IVRApi.md#readivrpromptcontent) | **GET** /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content | Get IVR Prompt Content
[**UpdateIVRMenu**](IVRApi.md#updateivrmenu) | **PUT** /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId} | Update IVR Menu
[**UpdateIVRPrompt**](IVRApi.md#updateivrprompt) | **PUT** /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId} | Update IVR Prompt



## CreateIVRMenu

> IVRMenuInfo CreateIVRMenu (string accountId, IVRMenuInfo iVRMenuInfo)

Create IVR Menu

Creates a company IVR menu.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateIVRMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var iVRMenuInfo = new IVRMenuInfo(); // IVRMenuInfo | JSON body

            try
            {
                // Create IVR Menu
                IVRMenuInfo result = apiInstance.CreateIVRMenu(accountId, iVRMenuInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.CreateIVRMenu: " + e.Message );
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
 **iVRMenuInfo** | [**IVRMenuInfo**](IVRMenuInfo.md)| JSON body | 

### Return type

[**IVRMenuInfo**](IVRMenuInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateIVRPrompt

> PromptInfo CreateIVRPrompt (string accountId, System.IO.Stream attachment, string name = null)

Create IVR Prompts

Creates an IVR prompt.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateIVRPromptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Audio file that will be used as a prompt. Attachment cannot be empty, only audio files are supported
            var name = "name_example";  // string | Description of file contents. (optional) 

            try
            {
                // Create IVR Prompts
                PromptInfo result = apiInstance.CreateIVRPrompt(accountId, attachment, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.CreateIVRPrompt: " + e.Message );
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
 **attachment** | **System.IO.Stream**| Audio file that will be used as a prompt. Attachment cannot be empty, only audio files are supported | 
 **name** | **string**| Description of file contents. | [optional] 

### Return type

[**PromptInfo**](PromptInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteIVRPrompt

> void DeleteIVRPrompt (string accountId, string promptId)

Delete IVR Prompt

Deletes an IVR prompt by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteIVRPromptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var promptId = "promptId_example";  // string | 

            try
            {
                // Delete IVR Prompt
                apiInstance.DeleteIVRPrompt(accountId, promptId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.DeleteIVRPrompt: " + e.Message );
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
 **promptId** | **string**|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListIVRPrompts

> IVRPrompts ListIVRPrompts (string accountId)

Get IVR Prompt List

Returns the list of IVR prompts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListIVRPromptsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get IVR Prompt List
                IVRPrompts result = apiInstance.ListIVRPrompts(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.ListIVRPrompts: " + e.Message );
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

### Return type

[**IVRPrompts**](IVRPrompts.md)

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


## ReadIVRMenu

> IVRMenuInfo ReadIVRMenu (string accountId, string ivrMenuId)

Get IVR Menu

Returns a company IVR menu by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadIVRMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var ivrMenuId = "ivrMenuId_example";  // string | 

            try
            {
                // Get IVR Menu
                IVRMenuInfo result = apiInstance.ReadIVRMenu(accountId, ivrMenuId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.ReadIVRMenu: " + e.Message );
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
 **ivrMenuId** | **string**|  | 

### Return type

[**IVRMenuInfo**](IVRMenuInfo.md)

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


## ReadIVRPrompt

> PromptInfo ReadIVRPrompt (string accountId, string promptId)

Get IVR Prompt

Returns an IVR prompt by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadIVRPromptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var promptId = "promptId_example";  // string | 

            try
            {
                // Get IVR Prompt
                PromptInfo result = apiInstance.ReadIVRPrompt(accountId, promptId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.ReadIVRPrompt: " + e.Message );
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
 **promptId** | **string**|  | 

### Return type

[**PromptInfo**](PromptInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Prompt Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadIVRPromptContent

> System.IO.Stream ReadIVRPromptContent (string accountId, string promptId)

Get IVR Prompt Content

Returns media content of an IVR prompt by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadIVRPromptContentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var promptId = "promptId_example";  // string | 

            try
            {
                // Get IVR Prompt Content
                System.IO.Stream result = apiInstance.ReadIVRPromptContent(accountId, promptId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.ReadIVRPromptContent: " + e.Message );
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
 **promptId** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IVR Prompt Media Data |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateIVRMenu

> IVRMenuInfo UpdateIVRMenu (string accountId, string ivrMenuId, IVRMenuInfo iVRMenuInfo)

Update IVR Menu

Updates a company IVR menu by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateIVRMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "accountId_example";  // string | 
            var ivrMenuId = "ivrMenuId_example";  // string | 
            var iVRMenuInfo = new IVRMenuInfo(); // IVRMenuInfo | JSON body

            try
            {
                // Update IVR Menu
                IVRMenuInfo result = apiInstance.UpdateIVRMenu(accountId, ivrMenuId, iVRMenuInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.UpdateIVRMenu: " + e.Message );
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
 **accountId** | **string**|  | 
 **ivrMenuId** | **string**|  | 
 **iVRMenuInfo** | [**IVRMenuInfo**](IVRMenuInfo.md)| JSON body | 

### Return type

[**IVRMenuInfo**](IVRMenuInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateIVRPrompt

> PromptInfo UpdateIVRPrompt (string accountId, string promptId, UpdateIVRPromptRequest updateIVRPromptRequest = null)

Update IVR Prompt

Updates an IVR prompt by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateIVRPromptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var promptId = "promptId_example";  // string | 
            var updateIVRPromptRequest = new UpdateIVRPromptRequest(); // UpdateIVRPromptRequest | JSON body (optional) 

            try
            {
                // Update IVR Prompt
                PromptInfo result = apiInstance.UpdateIVRPrompt(accountId, promptId, updateIVRPromptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IVRApi.UpdateIVRPrompt: " + e.Message );
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
 **promptId** | **string**|  | 
 **updateIVRPromptRequest** | [**UpdateIVRPromptRequest**](UpdateIVRPromptRequest.md)| JSON body | [optional] 

### Return type

[**PromptInfo**](PromptInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Prompt Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

