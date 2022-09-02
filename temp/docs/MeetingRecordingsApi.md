# Org.OpenAPITools.Api.MeetingRecordingsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAccountMeetingRecordings**](MeetingRecordingsApi.md#listaccountmeetingrecordings) | **GET** /restapi/v1.0/account/{accountId}/meeting-recordings | Get Account Meeting Recordings List
[**ListUserMeetingRecordings**](MeetingRecordingsApi.md#listusermeetingrecordings) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings | Get User Meeting Recordings List



## ListAccountMeetingRecordings

> ListMeetingRecordingsResponse ListAccountMeetingRecordings (string accountId, string meetingId = null, string meetingStartTimeFrom = null, string meetingStartTimeTo = null, int? page = null, int? perPage = null)

Get Account Meeting Recordings List

Returns the list of meeting recordings for the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAccountMeetingRecordingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingRecordingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var meetingId = "meetingId_example";  // string | Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified (optional) 
            var meetingStartTimeFrom = "meetingStartTimeFrom_example";  // string | Recordings of meetings in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format started after the time specified will be returned, for example *2016-03-10T18:07:52.534Z*. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified (optional) 
            var meetingStartTimeTo = "meetingStartTimeTo_example";  // string | Recordings of meetings in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format started before the time specified will be returned, for example *2016-03-10T18:07:52.534Z*. The default value is current time. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified (optional) 
            var page = 56;  // int? | Page number (optional) 
            var perPage = 100;  // int? | Number of items per page. The `max` value is supported to indicate the maximum size - 300 (optional)  (default to 100)

            try
            {
                // Get Account Meeting Recordings List
                ListMeetingRecordingsResponse result = apiInstance.ListAccountMeetingRecordings(accountId, meetingId, meetingStartTimeFrom, meetingStartTimeTo, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingRecordingsApi.ListAccountMeetingRecordings: " + e.Message );
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
 **meetingId** | **string**| Internal identifier of a meeting. Either &#x60;meetingId&#x60; or &#x60;meetingStartTime&#x60;/&#x60;meetingEndTime&#x60; can be specified | [optional] 
 **meetingStartTimeFrom** | **string**| Recordings of meetings in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format started after the time specified will be returned, for example *2016-03-10T18:07:52.534Z*. Either &#x60;meetingId&#x60; or &#x60;meetingStartTime&#x60;/&#x60;meetingEndTime&#x60; can be specified | [optional] 
 **meetingStartTimeTo** | **string**| Recordings of meetings in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format started before the time specified will be returned, for example *2016-03-10T18:07:52.534Z*. The default value is current time. Either &#x60;meetingId&#x60; or &#x60;meetingStartTime&#x60;/&#x60;meetingEndTime&#x60; can be specified | [optional] 
 **page** | **int?**| Page number | [optional] 
 **perPage** | **int?**| Number of items per page. The &#x60;max&#x60; value is supported to indicate the maximum size - 300 | [optional] [default to 100]

### Return type

[**ListMeetingRecordingsResponse**](ListMeetingRecordingsResponse.md)

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


## ListUserMeetingRecordings

> ListMeetingRecordingsResponse ListUserMeetingRecordings (string accountId, string extensionId, string meetingId = null, string meetingStartTimeFrom = null, string meetingStartTimeTo = null, int? page = null, int? perPage = null)

Get User Meeting Recordings List

Returns the list of meetings recordings for the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListUserMeetingRecordingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeetingRecordingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var meetingId = "meetingId_example";  // string | Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified (optional) 
            var meetingStartTimeFrom = "meetingStartTimeFrom_example";  // string | Recordings of meetings started after the time specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, will be returned, for example *2016-03-10T18:07:52.534Z*. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified (optional) 
            var meetingStartTimeTo = "meetingStartTimeTo_example";  // string | Recordings of meetings started before the time specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format will be returned, for example *2016-03-10T18:07:52.534Z*. The default value is current time. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified (optional) 
            var page = 56;  // int? | Page number (optional) 
            var perPage = 100;  // int? | Number of items per page. The `max` value is supported to indicate the maximum size - 300 (optional)  (default to 100)

            try
            {
                // Get User Meeting Recordings List
                ListMeetingRecordingsResponse result = apiInstance.ListUserMeetingRecordings(accountId, extensionId, meetingId, meetingStartTimeFrom, meetingStartTimeTo, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MeetingRecordingsApi.ListUserMeetingRecordings: " + e.Message );
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
 **meetingId** | **string**| Internal identifier of a meeting. Either &#x60;meetingId&#x60; or &#x60;meetingStartTime&#x60;/&#x60;meetingEndTime&#x60; can be specified | [optional] 
 **meetingStartTimeFrom** | **string**| Recordings of meetings started after the time specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, will be returned, for example *2016-03-10T18:07:52.534Z*. Either &#x60;meetingId&#x60; or &#x60;meetingStartTime&#x60;/&#x60;meetingEndTime&#x60; can be specified | [optional] 
 **meetingStartTimeTo** | **string**| Recordings of meetings started before the time specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format will be returned, for example *2016-03-10T18:07:52.534Z*. The default value is current time. Either &#x60;meetingId&#x60; or &#x60;meetingStartTime&#x60;/&#x60;meetingEndTime&#x60; can be specified | [optional] 
 **page** | **int?**| Page number | [optional] 
 **perPage** | **int?**| Number of items per page. The &#x60;max&#x60; value is supported to indicate the maximum size - 300 | [optional] [default to 100]

### Return type

[**ListMeetingRecordingsResponse**](ListMeetingRecordingsResponse.md)

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

