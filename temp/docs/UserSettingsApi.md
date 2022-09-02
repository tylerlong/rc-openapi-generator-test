# Org.OpenAPITools.Api.UserSettingsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserProfileImage**](UserSettingsApi.md#createuserprofileimage) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image | Upload User Profile Image
[**DeleteExtension**](UserSettingsApi.md#deleteextension) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId} | Delete Extension
[**ListExtensionGrants**](UserSettingsApi.md#listextensiongrants) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/grant | Get Extension Grant List
[**ReadConferencingSettings**](UserSettingsApi.md#readconferencingsettings) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing | Get User Conferencing Settings
[**ReadExtension**](UserSettingsApi.md#readextension) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId} | Get Extension
[**ReadExtensionCallerId**](UserSettingsApi.md#readextensioncallerid) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id | Get Extension Caller ID
[**ReadNotificationSettings**](UserSettingsApi.md#readnotificationsettings) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings | Get Notification Settings
[**ReadScaledProfileImage**](UserSettingsApi.md#readscaledprofileimage) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize} | Get Scaled User Profile Image
[**ReadUserProfileImage**](UserSettingsApi.md#readuserprofileimage) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image | Get User Profile Image
[**UpdateConferencingSettings**](UserSettingsApi.md#updateconferencingsettings) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing | Update User Conferencing Settings
[**UpdateExtension**](UserSettingsApi.md#updateextension) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId} | Update Extension
[**UpdateExtensionCallerId**](UserSettingsApi.md#updateextensioncallerid) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id | Update Extension Caller ID
[**UpdateNotificationSettings**](UserSettingsApi.md#updatenotificationsettings) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings | Update Notification Settings
[**UpdateUserProfileImage**](UserSettingsApi.md#updateuserprofileimage) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image | Update User Profile Image



## CreateUserProfileImage

> void CreateUserProfileImage (string extensionId, string accountId, System.IO.Stream image)

Upload User Profile Image

Uploads the extension profile image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUserProfileImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload User Profile Image
                apiInstance.CreateUserProfileImage(extensionId, accountId, image);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.CreateUserProfileImage: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **image** | **System.IO.Stream**|  | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteExtension

> void DeleteExtension (string extensionId, string accountId, bool? savePhoneLines = null, bool? savePhoneNumbers = null)

Delete Extension

Deletes extension(s) by ID(s). When an extension is being deleted the default API behavior is as follows: ⋅⋅* user's direct numbers are preserved by becoming additional company numbers; ⋅⋅* user's digital lines (both device & associated phone number) are deleted. You can change this behavior using the filters: ..* create unassigned extensions for each digital line of the deleted extension by setting the query parameter `savePhoneLines` to `true` in request path; ..* remove direct numbers of the deleted extension by setting the query parameter `savePhoneNumbers` to `false` in request path

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteExtensionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var savePhoneLines = false;  // bool? |  (optional)  (default to false)
            var savePhoneNumbers = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Delete Extension
                apiInstance.DeleteExtension(extensionId, accountId, savePhoneLines, savePhoneNumbers);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.DeleteExtension: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **savePhoneLines** | **bool?**|  | [optional] [default to false]
 **savePhoneNumbers** | **bool?**|  | [optional] [default to true]

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


## ListExtensionGrants

> GetExtensionGrantListResponse ListExtensionGrants (string accountId, string extensionId, string extensionType = null, string page = null, string perPage = null)

Get Extension Grant List

Returns the list of extensions with the information on grants given to the current extension regarding them. Currently the list of grants include: picking up a call, monitoring, calling or receiving a call on behalf of somebody, call delegation and calling paging groups.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListExtensionGrantsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var extensionType = "User";  // string | Type of extension to be returned. Multiple values are supported. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology (optional) 
            var page = "\"1\"";  // string |  (optional)  (default to "1")
            var perPage = "\"100\"";  // string |  (optional)  (default to "100")

            try
            {
                // Get Extension Grant List
                GetExtensionGrantListResponse result = apiInstance.ListExtensionGrants(accountId, extensionId, extensionType, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ListExtensionGrants: " + e.Message );
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
 **extensionType** | **string**| Type of extension to be returned. Multiple values are supported. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
 **page** | **string**|  | [optional] [default to &quot;1&quot;]
 **perPage** | **string**|  | [optional] [default to &quot;100&quot;]

### Return type

[**GetExtensionGrantListResponse**](GetExtensionGrantListResponse.md)

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


## ReadConferencingSettings

> GetConferencingInfoResponse ReadConferencingSettings (string accountId, string extensionId, string countryId = null)

Get User Conferencing Settings

Returns the information on the Free Conference Calling (FCC) feature for a given extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadConferencingSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var countryId = "countryId_example";  // string | Internal identifier of a country. If not specified, the response is returned for the brand country (optional) 

            try
            {
                // Get User Conferencing Settings
                GetConferencingInfoResponse result = apiInstance.ReadConferencingSettings(accountId, extensionId, countryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ReadConferencingSettings: " + e.Message );
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
 **countryId** | **string**| Internal identifier of a country. If not specified, the response is returned for the brand country | [optional] 

### Return type

[**GetConferencingInfoResponse**](GetConferencingInfoResponse.md)

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


## ReadExtension

> GetExtensionInfoResponse ReadExtension (string accountId, string extensionId)

Get Extension

Returns basic information about a particular extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadExtensionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Extension
                GetExtensionInfoResponse result = apiInstance.ReadExtension(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ReadExtension: " + e.Message );
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

### Return type

[**GetExtensionInfoResponse**](GetExtensionInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Extension information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadExtensionCallerId

> ExtensionCallerIdInfo ReadExtensionCallerId (string accountId, string extensionId)

Get Extension Caller ID

Returns information on an outbound caller ID of an extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadExtensionCallerIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Extension Caller ID
                ExtensionCallerIdInfo result = apiInstance.ReadExtensionCallerId(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ReadExtensionCallerId: " + e.Message );
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

### Return type

[**ExtensionCallerIdInfo**](ExtensionCallerIdInfo.md)

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


## ReadNotificationSettings

> NotificationSettings ReadNotificationSettings (string accountId, string extensionId)

Get Notification Settings

Returns notification settings for the current extension.  <p>Knowledge Article: <a href=\"https://success.ringcentral.com/articles/RC_Knowledge_Article/9740\">User Settings - Set up Message Notifications</a></p>

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Notification Settings
                NotificationSettings result = apiInstance.ReadNotificationSettings(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ReadNotificationSettings: " + e.Message );
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

### Return type

[**NotificationSettings**](NotificationSettings.md)

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


## ReadScaledProfileImage

> System.IO.Stream ReadScaledProfileImage (string accountId, string extensionId, string scaleSize)

Get Scaled User Profile Image

Returns scaled profile image of an extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadScaledProfileImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var scaleSize = "scaleSize_example";  // string | Dimensions of a profile image which will be returned in response. If this path parameter is not specified in request URI then

            try
            {
                // Get Scaled User Profile Image
                System.IO.Stream result = apiInstance.ReadScaledProfileImage(accountId, extensionId, scaleSize);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ReadScaledProfileImage: " + e.Message );
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
 **scaleSize** | **string**| Dimensions of a profile image which will be returned in response. If this path parameter is not specified in request URI then | 

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/jpeg


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User Profile Image Media Data |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadUserProfileImage

> System.IO.Stream ReadUserProfileImage (string extensionId, string accountId)

Get User Profile Image

Returns a profile image of an extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserProfileImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get User Profile Image
                System.IO.Stream result = apiInstance.ReadUserProfileImage(extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.ReadUserProfileImage: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*, image/png, image/jpeg, image/gif


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User Profile Image (Media Data) |  -  |
| **304** | Not Modified |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConferencingSettings

> GetConferencingInfoResponse UpdateConferencingSettings (string accountId, string extensionId, UpdateConferencingInfoRequest updateConferencingInfoRequest)

Update User Conferencing Settings

Updates the default conferencing number for the current extension. The number can be selected from conferencing numbers of the current extension. Updates the setting, allowing participants join the conference before host.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateConferencingSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var updateConferencingInfoRequest = new UpdateConferencingInfoRequest(); // UpdateConferencingInfoRequest | JSON body

            try
            {
                // Update User Conferencing Settings
                GetConferencingInfoResponse result = apiInstance.UpdateConferencingSettings(accountId, extensionId, updateConferencingInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.UpdateConferencingSettings: " + e.Message );
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
 **updateConferencingInfoRequest** | [**UpdateConferencingInfoRequest**](UpdateConferencingInfoRequest.md)| JSON body | 

### Return type

[**GetConferencingInfoResponse**](GetConferencingInfoResponse.md)

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


## UpdateExtension

> GetExtensionInfoResponse UpdateExtension (string accountId, string extensionId, ExtensionUpdateRequest extensionUpdateRequest)

Update Extension

Updates user settings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateExtensionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var extensionUpdateRequest = new ExtensionUpdateRequest(); // ExtensionUpdateRequest | JSON body

            try
            {
                // Update Extension
                GetExtensionInfoResponse result = apiInstance.UpdateExtension(accountId, extensionId, extensionUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.UpdateExtension: " + e.Message );
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
 **extensionUpdateRequest** | [**ExtensionUpdateRequest**](ExtensionUpdateRequest.md)| JSON body | 

### Return type

[**GetExtensionInfoResponse**](GetExtensionInfoResponse.md)

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


## UpdateExtensionCallerId

> ExtensionCallerIdInfo UpdateExtensionCallerId (string accountId, string extensionId, ExtensionCallerIdInfoRequest extensionCallerIdInfoRequest)

Update Extension Caller ID

Updates outbound caller ID information of an extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateExtensionCallerIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var extensionCallerIdInfoRequest = new ExtensionCallerIdInfoRequest(); // ExtensionCallerIdInfoRequest | JSON body

            try
            {
                // Update Extension Caller ID
                ExtensionCallerIdInfo result = apiInstance.UpdateExtensionCallerId(accountId, extensionId, extensionCallerIdInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.UpdateExtensionCallerId: " + e.Message );
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
 **extensionCallerIdInfoRequest** | [**ExtensionCallerIdInfoRequest**](ExtensionCallerIdInfoRequest.md)| JSON body | 

### Return type

[**ExtensionCallerIdInfo**](ExtensionCallerIdInfo.md)

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


## UpdateNotificationSettings

> NotificationSettings UpdateNotificationSettings (string accountId, string extensionId, NotificationSettingsUpdateRequest notificationSettingsUpdateRequest)

Update Notification Settings

Updates notification settings for the current extension. <p>Knowledge Article: <a href=\"https://success.ringcentral.com/articles/RC_Knowledge_Article/9740\">User Settings - Set up Message Notifications</a></p>

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var notificationSettingsUpdateRequest = new NotificationSettingsUpdateRequest(); // NotificationSettingsUpdateRequest | 

            try
            {
                // Update Notification Settings
                NotificationSettings result = apiInstance.UpdateNotificationSettings(accountId, extensionId, notificationSettingsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.UpdateNotificationSettings: " + e.Message );
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
 **notificationSettingsUpdateRequest** | [**NotificationSettingsUpdateRequest**](NotificationSettingsUpdateRequest.md)|  | 

### Return type

[**NotificationSettings**](NotificationSettings.md)

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


## UpdateUserProfileImage

> void UpdateUserProfileImage (string extensionId, string accountId, System.IO.Stream image = null)

Update User Profile Image

Updates the extension profile image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserProfileImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserSettingsApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Update User Profile Image
                apiInstance.UpdateUserProfileImage(extensionId, accountId, image);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserSettingsApi.UpdateUserProfileImage: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **image** | **System.IO.Stream**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

