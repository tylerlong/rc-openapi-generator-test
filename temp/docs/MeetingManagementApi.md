# Org.OpenAPITools.Api.MeetingManagementApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMeeting**](MeetingManagementApi.md#createmeeting) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting | Create Meeting
[**DeleteMeeting**](MeetingManagementApi.md#deletemeeting) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId} | Delete Meeting
[**EndMeeting**](MeetingManagementApi.md#endmeeting) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end | End Meeting
[**ListMeetings**](MeetingManagementApi.md#listmeetings) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting | Get Scheduled Meetings
[**ReadMeeting**](MeetingManagementApi.md#readmeeting) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId} | Get Meeting Info
[**ReadMeetingInvitation**](MeetingManagementApi.md#readmeetinginvitation) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/invitation | Get Meeting Invitation
[**UpdateMeeting**](MeetingManagementApi.md#updatemeeting) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId} | Update Meeting



## CreateMeeting

> MeetingResponseResource CreateMeeting (string extensionId, string accountId, MeetingRequestResource meetingRequestResource = null)

Create Meeting

Creates a new meeting.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateMeetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var meetingRequestResource = new MeetingRequestResource(); // MeetingRequestResource |  (optional) 

            try
            {
                // Create Meeting
                MeetingResponseResource result = apiInstance.CreateMeeting(extensionId, accountId, meetingRequestResource);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.CreateMeeting: " + e.Message );
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
 **meetingRequestResource** | [**MeetingRequestResource**](MeetingRequestResource.md)|  | [optional] 

### Return type

[**MeetingResponseResource**](MeetingResponseResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Meeting |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteMeeting

> void DeleteMeeting (string meetingId, string extensionId, string accountId)

Delete Meeting

Deletes a scheduled meeting.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteMeetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var meetingId = "meetingId_example";  // string | Internal identifier of a RingCentral meeting
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Delete Meeting
                apiInstance.DeleteMeeting(meetingId, extensionId, accountId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.DeleteMeeting: " + e.Message );
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
 **meetingId** | **string**| Internal identifier of a RingCentral meeting | 
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
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


## EndMeeting

> void EndMeeting (string meetingId, string extensionId, string accountId)

End Meeting

Ends a meetings which is in progress.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EndMeetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var meetingId = "meetingId_example";  // string | Internal identifier of a RingCentral meeting
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string |  (default to "~")

            try
            {
                // End Meeting
                apiInstance.EndMeeting(meetingId, extensionId, accountId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.EndMeeting: " + e.Message );
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
 **meetingId** | **string**| Internal identifier of a RingCentral meeting | 
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**|  | [default to &quot;~&quot;]

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


## ListMeetings

> MeetingsResource ListMeetings (string extensionId, string accountId)

Get Scheduled Meetings

Returns a list of user meetings scheduled for the future (meetings of 'Instant' type are not included).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListMeetingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Scheduled Meetings
                MeetingsResource result = apiInstance.ListMeetings(extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.ListMeetings: " + e.Message );
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

[**MeetingsResource**](MeetingsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Scheduled Meeting List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMeeting

> MeetingResponseResource ReadMeeting (string meetingId, string extensionId, string accountId)

Get Meeting Info

Returns a particular meetings details by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMeetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var meetingId = "meetingId_example";  // string | Internal identifier of a RingCentral meeting
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Meeting Info
                MeetingResponseResource result = apiInstance.ReadMeeting(meetingId, extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.ReadMeeting: " + e.Message );
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
 **meetingId** | **string**| Internal identifier of a RingCentral meeting | 
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**MeetingResponseResource**](MeetingResponseResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Meeting Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMeetingInvitation

> PublicMeetingInvitationResponse ReadMeetingInvitation (long meetingId, string extensionId, string accountId)

Get Meeting Invitation

Returns a meeting invitation by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMeetingInvitationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var meetingId = 789L;  // long | Internal identifier of a RingCentral meeting
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of an account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Meeting Invitation
                PublicMeetingInvitationResponse result = apiInstance.ReadMeetingInvitation(meetingId, extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.ReadMeetingInvitation: " + e.Message );
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
 **meetingId** | **long**| Internal identifier of a RingCentral meeting | 
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of an account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**PublicMeetingInvitationResponse**](PublicMeetingInvitationResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Meeting Invitation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMeeting

> MeetingResponseResource UpdateMeeting (string meetingId, string extensionId, string accountId, MeetingRequestResource meetingRequestResource = null)

Update Meeting

Modifies a particular meeting.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateMeetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingManagementApi(Configuration.Default);
            var meetingId = "meetingId_example";  // string | Internal identifier of a RingCentral meeting
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var meetingRequestResource = new MeetingRequestResource(); // MeetingRequestResource |  (optional) 

            try
            {
                // Update Meeting
                MeetingResponseResource result = apiInstance.UpdateMeeting(meetingId, extensionId, accountId, meetingRequestResource);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingManagementApi.UpdateMeeting: " + e.Message );
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
 **meetingId** | **string**| Internal identifier of a RingCentral meeting | 
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **meetingRequestResource** | [**MeetingRequestResource**](MeetingRequestResource.md)|  | [optional] 

### Return type

[**MeetingResponseResource**](MeetingResponseResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Updated Meeting Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

