# Org.OpenAPITools.Api.RingOutApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRingOutCall**](RingOutApi.md#createringoutcall) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out | Make RingOut Call
[**CreateRingOutCallDeprecated**](RingOutApi.md#createringoutcalldeprecated) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout | Make RingOut Call
[**DeleteRingOutCall**](RingOutApi.md#deleteringoutcall) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId} | Cancel RingOut Call
[**DeleteRingOutCallDeprecated**](RingOutApi.md#deleteringoutcalldeprecated) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId} | Cancel RingOut Call
[**ReadRingOutCallStatus**](RingOutApi.md#readringoutcallstatus) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId} | Get RingOut Call Status
[**ReadRingOutCallStatusDeprecated**](RingOutApi.md#readringoutcallstatusdeprecated) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId} | Get RingOut Call Status



## CreateRingOutCall

> GetRingOutStatusResponse CreateRingOutCall (string accountId, string extensionId, MakeRingOutRequest makeRingOutRequest)

Make RingOut Call

Makes a 2-leg RingOut call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateRingOutCallExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RingOutApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var makeRingOutRequest = new MakeRingOutRequest(); // MakeRingOutRequest | JSON body

            try
            {
                // Make RingOut Call
                GetRingOutStatusResponse result = apiInstance.CreateRingOutCall(accountId, extensionId, makeRingOutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RingOutApi.CreateRingOutCall: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **makeRingOutRequest** | [**MakeRingOutRequest**](MakeRingOutRequest.md)| JSON body | 

### Return type

[**GetRingOutStatusResponse**](GetRingOutStatusResponse.md)

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


## CreateRingOutCallDeprecated

> GetRingOutStatusResponseIntId CreateRingOutCallDeprecated (string accountId, string extensionId, MakeRingOutRequest makeRingOutRequest)

Make RingOut Call

Makes a 2-leg RingOut call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateRingOutCallDeprecatedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RingOutApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var makeRingOutRequest = new MakeRingOutRequest(); // MakeRingOutRequest | JSON body

            try
            {
                // Make RingOut Call
                GetRingOutStatusResponseIntId result = apiInstance.CreateRingOutCallDeprecated(accountId, extensionId, makeRingOutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RingOutApi.CreateRingOutCallDeprecated: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **makeRingOutRequest** | [**MakeRingOutRequest**](MakeRingOutRequest.md)| JSON body | 

### Return type

[**GetRingOutStatusResponseIntId**](GetRingOutStatusResponseIntId.md)

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


## DeleteRingOutCall

> void DeleteRingOutCall (string accountId, string extensionId, string ringoutId)

Cancel RingOut Call

Cancels a 2-leg RingOut call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteRingOutCallExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RingOutApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ringoutId = "ringoutId_example";  // string | Internal identifier of a RingOut call

            try
            {
                // Cancel RingOut Call
                apiInstance.DeleteRingOutCall(accountId, extensionId, ringoutId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RingOutApi.DeleteRingOutCall: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **ringoutId** | **string**| Internal identifier of a RingOut call | 

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
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteRingOutCallDeprecated

> void DeleteRingOutCallDeprecated (string accountId, string extensionId, int ringoutId)

Cancel RingOut Call

Cancels a 2-leg RingOut call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteRingOutCallDeprecatedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RingOutApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ringoutId = 56;  // int | Internal identifier of a RingOut call

            try
            {
                // Cancel RingOut Call
                apiInstance.DeleteRingOutCallDeprecated(accountId, extensionId, ringoutId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RingOutApi.DeleteRingOutCallDeprecated: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **ringoutId** | **int**| Internal identifier of a RingOut call | 

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


## ReadRingOutCallStatus

> GetRingOutStatusResponse ReadRingOutCallStatus (string accountId, string extensionId, string ringoutId)

Get RingOut Call Status

Returns the status of a 2-leg RingOut call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadRingOutCallStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RingOutApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ringoutId = "ringoutId_example";  // string | Internal identifier of a RingOut call

            try
            {
                // Get RingOut Call Status
                GetRingOutStatusResponse result = apiInstance.ReadRingOutCallStatus(accountId, extensionId, ringoutId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RingOutApi.ReadRingOutCallStatus: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **ringoutId** | **string**| Internal identifier of a RingOut call | 

### Return type

[**GetRingOutStatusResponse**](GetRingOutStatusResponse.md)

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


## ReadRingOutCallStatusDeprecated

> GetRingOutStatusResponse ReadRingOutCallStatusDeprecated (string accountId, string extensionId, int ringoutId)

Get RingOut Call Status

Returns status of a 2-leg RingOut call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadRingOutCallStatusDeprecatedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RingOutApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ringoutId = 56;  // int | Internal identifier of a RingOut call

            try
            {
                // Get RingOut Call Status
                GetRingOutStatusResponse result = apiInstance.ReadRingOutCallStatusDeprecated(accountId, extensionId, ringoutId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RingOutApi.ReadRingOutCallStatusDeprecated: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **ringoutId** | **int**| Internal identifier of a RingOut call | 

### Return type

[**GetRingOutStatusResponse**](GetRingOutStatusResponse.md)

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

