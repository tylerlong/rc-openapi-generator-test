# Org.OpenAPITools.Api.CallRecordingSettingsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCallRecordingCustomGreeting**](CallRecordingSettingsApi.md#deletecallrecordingcustomgreeting) | **DELETE** /restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId} | Delete Call Recording Custom Greeting
[**DeleteCallRecordingCustomGreetingList**](CallRecordingSettingsApi.md#deletecallrecordingcustomgreetinglist) | **DELETE** /restapi/v1.0/account/{accountId}/call-recording/custom-greetings | Delete Call Recording Custom Greeting List
[**ListCallRecordingCustomGreetings**](CallRecordingSettingsApi.md#listcallrecordingcustomgreetings) | **GET** /restapi/v1.0/account/{accountId}/call-recording/custom-greetings | Get Call Recording Custom Greeting List
[**ListCallRecordingExtensions**](CallRecordingSettingsApi.md#listcallrecordingextensions) | **GET** /restapi/v1.0/account/{accountId}/call-recording/extensions | Get Call Recording Extension List
[**ReadCallRecordingSettings**](CallRecordingSettingsApi.md#readcallrecordingsettings) | **GET** /restapi/v1.0/account/{accountId}/call-recording | Get Call Recording Settings
[**UpdateCallRecordingExtensionList**](CallRecordingSettingsApi.md#updatecallrecordingextensionlist) | **POST** /restapi/v1.0/account/{accountId}/call-recording/bulk-assign | Update Call Recording Extension List
[**UpdateCallRecordingSettings**](CallRecordingSettingsApi.md#updatecallrecordingsettings) | **PUT** /restapi/v1.0/account/{accountId}/call-recording | Update Call Recording Settings



## DeleteCallRecordingCustomGreeting

> void DeleteCallRecordingCustomGreeting (string accountId, string greetingId)

Delete Call Recording Custom Greeting

Deletes call recording custom greeting(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCallRecordingCustomGreetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var greetingId = "greetingId_example";  // string | 

            try
            {
                // Delete Call Recording Custom Greeting
                apiInstance.DeleteCallRecordingCustomGreeting(accountId, greetingId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.DeleteCallRecordingCustomGreeting: " + e.Message );
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
 **greetingId** | **string**|  | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCallRecordingCustomGreetingList

> void DeleteCallRecordingCustomGreetingList (string accountId)

Delete Call Recording Custom Greeting List

Deletes call recording custom greetings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCallRecordingCustomGreetingListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Delete Call Recording Custom Greeting List
                apiInstance.DeleteCallRecordingCustomGreetingList(accountId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.DeleteCallRecordingCustomGreetingList: " + e.Message );
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


## ListCallRecordingCustomGreetings

> CallRecordingCustomGreetings ListCallRecordingCustomGreetings (string accountId, string type = null)

Get Call Recording Custom Greeting List

Returns call recording custom greetings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallRecordingCustomGreetingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var type = "StartRecording";  // string |  (optional) 

            try
            {
                // Get Call Recording Custom Greeting List
                CallRecordingCustomGreetings result = apiInstance.ListCallRecordingCustomGreetings(accountId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.ListCallRecordingCustomGreetings: " + e.Message );
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

### Return type

[**CallRecordingCustomGreetings**](CallRecordingCustomGreetings.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCallRecordingExtensions

> CallRecordingExtensions ListCallRecordingExtensions (string accountId)

Get Call Recording Extension List

Returns the list of extensions to be recorded.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallRecordingExtensionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Call Recording Extension List
                CallRecordingExtensions result = apiInstance.ListCallRecordingExtensions(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.ListCallRecordingExtensions: " + e.Message );
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

[**CallRecordingExtensions**](CallRecordingExtensions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Extension List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadCallRecordingSettings

> CallRecordingSettingsResource ReadCallRecordingSettings (string accountId)

Get Call Recording Settings

Returns call recording settings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallRecordingSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "accountId_example";  // string | 

            try
            {
                // Get Call Recording Settings
                CallRecordingSettingsResource result = apiInstance.ReadCallRecordingSettings(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.ReadCallRecordingSettings: " + e.Message );
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

### Return type

[**CallRecordingSettingsResource**](CallRecordingSettingsResource.md)

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


## UpdateCallRecordingExtensionList

> void UpdateCallRecordingExtensionList (string accountId, BulkAccountCallRecordingsResource bulkAccountCallRecordingsResource)

Update Call Recording Extension List

Creates or updates the list of extensions to be recorded.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallRecordingExtensionListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var bulkAccountCallRecordingsResource = new BulkAccountCallRecordingsResource(); // BulkAccountCallRecordingsResource | 

            try
            {
                // Update Call Recording Extension List
                apiInstance.UpdateCallRecordingExtensionList(accountId, bulkAccountCallRecordingsResource);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.UpdateCallRecordingExtensionList: " + e.Message );
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
 **bulkAccountCallRecordingsResource** | [**BulkAccountCallRecordingsResource**](BulkAccountCallRecordingsResource.md)|  | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCallRecordingSettings

> CallRecordingSettingsResource UpdateCallRecordingSettings (string accountId, CallRecordingSettingsResource callRecordingSettingsResource = null)

Update Call Recording Settings

Updates current call recording settings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallRecordingSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var callRecordingSettingsResource = new CallRecordingSettingsResource(); // CallRecordingSettingsResource |  (optional) 

            try
            {
                // Update Call Recording Settings
                CallRecordingSettingsResource result = apiInstance.UpdateCallRecordingSettings(accountId, callRecordingSettingsResource);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingSettingsApi.UpdateCallRecordingSettings: " + e.Message );
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
 **callRecordingSettingsResource** | [**CallRecordingSettingsResource**](CallRecordingSettingsResource.md)|  | [optional] 

### Return type

[**CallRecordingSettingsResource**](CallRecordingSettingsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Updated Call Recording Settings |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

