# Org.OpenAPITools.Api.MeetingConfigurationApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserMeetingProfileImage**](MeetingConfigurationApi.md#createusermeetingprofileimage) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-configuration/profile-image | Upload User Meeting Profile Image
[**GetAccountLockedSetting**](MeetingConfigurationApi.md#getaccountlockedsetting) | **GET** /restapi/v1.0/account/{accountId}/meeting/locked-settings | Get Locked Meeting Settings
[**GetUserSetting**](MeetingConfigurationApi.md#getusersetting) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/user-settings | Get Meeting User Settings
[**ReadAssistants**](MeetingConfigurationApi.md#readassistants) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants | Get Assistants
[**ReadAssistedUsers**](MeetingConfigurationApi.md#readassistedusers) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted | Get Assisted Users
[**ReadMeetingServiceInfo**](MeetingConfigurationApi.md#readmeetingserviceinfo) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info | Get Meeting Service Info
[**UpdateMeetingServiceInfo**](MeetingConfigurationApi.md#updatemeetingserviceinfo) | **PATCH** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info | Update Meeting Service Info



## CreateUserMeetingProfileImage

> void CreateUserMeetingProfileImage (string accountId, string extensionId, System.IO.Stream profilePic)

Upload User Meeting Profile Image

Uploads profile picture for user meetings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUserMeetingProfileImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var profilePic = "profilePic_example";  // System.IO.Stream | Profile image file size cannot exceed 2Mb. Supported formats are: JPG/JPEG, GIF and PNG

            try
            {
                // Upload User Meeting Profile Image
                apiInstance.CreateUserMeetingProfileImage(accountId, extensionId, profilePic);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.CreateUserMeetingProfileImage: " + e.Message );
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
 **profilePic** | **System.IO.Stream**| Profile image file size cannot exceed 2Mb. Supported formats are: JPG/JPEG, GIF and PNG | 

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


## GetAccountLockedSetting

> AccountLockedSettingResponse GetAccountLockedSetting (string accountId)

Get Locked Meeting Settings

Returns information on user meeting settings that are locked on account level and therefore cannot be changed by user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountLockedSettingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of an account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Locked Meeting Settings
                AccountLockedSettingResponse result = apiInstance.GetAccountLockedSetting(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.GetAccountLockedSetting: " + e.Message );
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
 **accountId** | **string**| Internal identifier of an account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**AccountLockedSettingResponse**](AccountLockedSettingResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Account Locked Meeting Settings |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUserSetting

> MeetingUserSettingsResponse GetUserSetting (string extensionId, string accountId)

Get Meeting User Settings

Returns user settings for meetings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserSettingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Meeting User Settings
                MeetingUserSettingsResponse result = apiInstance.GetUserSetting(extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.GetUserSetting: " + e.Message );
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

[**MeetingUserSettingsResponse**](MeetingUserSettingsResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: User Setting |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadAssistants

> AssistantsResource ReadAssistants (string accountId, string extensionId)

Get Assistants

Returns assistants information.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAssistantsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Assistants
                AssistantsResource result = apiInstance.ReadAssistants(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.ReadAssistants: " + e.Message );
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

[**AssistantsResource**](AssistantsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Assistants Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadAssistedUsers

> AssistedUsersResource ReadAssistedUsers (string accountId, string extensionId)

Get Assisted Users

Returns assisted users information.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAssistedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Assisted Users
                AssistedUsersResource result = apiInstance.ReadAssistedUsers(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.ReadAssistedUsers: " + e.Message );
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

[**AssistedUsersResource**](AssistedUsersResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Assisted User Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMeetingServiceInfo

> MeetingServiceInfoResource ReadMeetingServiceInfo (string extensionId, string accountId)

Get Meeting Service Info

Returns information on dial-in numbers for meetings, support and international dial-in numbers URIs and meeting account information.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMeetingServiceInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Meeting Service Info
                MeetingServiceInfoResource result = apiInstance.ReadMeetingServiceInfo(extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.ReadMeetingServiceInfo: " + e.Message );
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

[**MeetingServiceInfoResource**](MeetingServiceInfoResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Meeting Service Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMeetingServiceInfo

> MeetingServiceInfoResource UpdateMeetingServiceInfo (string extensionId, string accountId, MeetingServiceInfoRequest meetingServiceInfoRequest)

Update Meeting Service Info

Updates personal meeting identifier.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateMeetingServiceInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingConfigurationApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var meetingServiceInfoRequest = new MeetingServiceInfoRequest(); // MeetingServiceInfoRequest | JSON body

            try
            {
                // Update Meeting Service Info
                MeetingServiceInfoResource result = apiInstance.UpdateMeetingServiceInfo(extensionId, accountId, meetingServiceInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingConfigurationApi.UpdateMeetingServiceInfo: " + e.Message );
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
 **meetingServiceInfoRequest** | [**MeetingServiceInfoRequest**](MeetingServiceInfoRequest.md)| JSON body | 

### Return type

[**MeetingServiceInfoResource**](MeetingServiceInfoResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Meeting Service Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

