# Org.OpenAPITools.Api.VideoConfigurationApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReadUserVideoConfiguration**](VideoConfigurationApi.md#readuservideoconfiguration) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration | Get User Video Configuration
[**UpdateUserVideoConfiguration**](VideoConfigurationApi.md#updateuservideoconfiguration) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration | Update User Video Configuration



## ReadUserVideoConfiguration

> UserVideoConfiguration ReadUserVideoConfiguration (string accountId, string extensionId)

Get User Video Configuration

Returns information about video configuration of the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserVideoConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideoConfigurationApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account (default to "~")

            try
            {
                // Get User Video Configuration
                UserVideoConfiguration result = apiInstance.ReadUserVideoConfiguration(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VideoConfigurationApi.ReadUserVideoConfiguration: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account | [default to &quot;~&quot;]

### Return type

[**UserVideoConfiguration**](UserVideoConfiguration.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User Video Configuration |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUserVideoConfiguration

> UserVideoConfiguration UpdateUserVideoConfiguration (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration)

Update User Video Configuration

Allows to update user video settings, for example video provider.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserVideoConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideoConfigurationApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account (default to "~")
            var userVideoConfiguration = new UserVideoConfiguration(); // UserVideoConfiguration | 

            try
            {
                // Update User Video Configuration
                UserVideoConfiguration result = apiInstance.UpdateUserVideoConfiguration(accountId, extensionId, userVideoConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VideoConfigurationApi.UpdateUserVideoConfiguration: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account | [default to &quot;~&quot;]
 **userVideoConfiguration** | [**UserVideoConfiguration**](UserVideoConfiguration.md)|  | 

### Return type

[**UserVideoConfiguration**](UserVideoConfiguration.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Video Configuration |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

