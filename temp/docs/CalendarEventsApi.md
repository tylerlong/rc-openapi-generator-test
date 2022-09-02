# Org.OpenAPITools.Api.CalendarEventsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEvent**](CalendarEventsApi.md#createevent) | **POST** /restapi/v1.0/glip/events | Create Event
[**CreateEventByGroupId**](CalendarEventsApi.md#createeventbygroupid) | **POST** /restapi/v1.0/glip/groups/{groupId}/events | Create Event by Group ID
[**DeleteEvent**](CalendarEventsApi.md#deleteevent) | **DELETE** /restapi/v1.0/glip/events/{eventId} | Delete Event
[**ListGroupEvents**](CalendarEventsApi.md#listgroupevents) | **GET** /restapi/v1.0/glip/groups/{groupId}/events | Get Group Events
[**ReadEvent**](CalendarEventsApi.md#readevent) | **GET** /restapi/v1.0/glip/events/{eventId} | Get Event
[**ReadGlipEvents**](CalendarEventsApi.md#readglipevents) | **GET** /restapi/v1.0/glip/events | Get User Events List
[**UpdateEvent**](CalendarEventsApi.md#updateevent) | **PUT** /restapi/v1.0/glip/events/{eventId} | Update Event



## CreateEvent

> GlipEventInfo CreateEvent (GlipEventCreate glipEventCreate)

Create Event

Creates a new calendar event.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var glipEventCreate = new GlipEventCreate(); // GlipEventCreate | 

            try
            {
                // Create Event
                GlipEventInfo result = apiInstance.CreateEvent(glipEventCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.CreateEvent: " + e.Message );
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
 **glipEventCreate** | [**GlipEventCreate**](GlipEventCreate.md)|  | 

### Return type

[**GlipEventInfo**](GlipEventInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateEventByGroupId

> GlipEventInfo CreateEventByGroupId (string groupId, GlipEventCreate glipEventCreate)

Create Event by Group ID

Creates a new calendar event within the specified group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateEventByGroupIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group
            var glipEventCreate = new GlipEventCreate(); // GlipEventCreate | 

            try
            {
                // Create Event by Group ID
                GlipEventInfo result = apiInstance.CreateEventByGroupId(groupId, glipEventCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.CreateEventByGroupId: " + e.Message );
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
 **glipEventCreate** | [**GlipEventCreate**](GlipEventCreate.md)|  | 

### Return type

[**GlipEventInfo**](GlipEventInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteEvent

> void DeleteEvent (string eventId)

Delete Event

Deletes the specified calendar event.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var eventId = "eventId_example";  // string | Internal identifier of an event to be deleted

            try
            {
                // Delete Event
                apiInstance.DeleteEvent(eventId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.DeleteEvent: " + e.Message );
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
 **eventId** | **string**| Internal identifier of an event to be deleted | 

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
| **404** | Event not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListGroupEvents

> GlipEventInfo ListGroupEvents (string groupId)

Get Group Events

Returns a list of calendar events available for the current user within the specified group. Users can only see their personal tasks and public tasks.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGroupEventsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var groupId = "groupId_example";  // string | Internal identifier of a group

            try
            {
                // Get Group Events
                GlipEventInfo result = apiInstance.ListGroupEvents(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.ListGroupEvents: " + e.Message );
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

[**GlipEventInfo**](GlipEventInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Group with specified Id is not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadEvent

> GlipEventInfo ReadEvent (List<string> eventId)

Get Event

Returns the specified calendar event(s) by ID(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var eventId = new List<string>(); // List<string> | event id or comma separated list of event ids.

            try
            {
                // Get Event
                GlipEventInfo result = apiInstance.ReadEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.ReadEvent: " + e.Message );
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
 **eventId** | [**List&lt;string&gt;**](string.md)| event id or comma separated list of event ids. | 

### Return type

[**GlipEventInfo**](GlipEventInfo.md)

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
| **404** | Event not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipEvents

> GlipEventsInfo ReadGlipEvents (int? recordCount = null, string pageToken = null)

Get User Events List

Returns all calendar events created by the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipEventsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var recordCount = 30;  // int? | Number of groups to be fetched by one request. The maximum value is 250, by default - 30. (optional)  (default to 30)
            var pageToken = "pageToken_example";  // string | Token of a page to be returned (optional) 

            try
            {
                // Get User Events List
                GlipEventsInfo result = apiInstance.ReadGlipEvents(recordCount, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.ReadGlipEvents: " + e.Message );
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
 **recordCount** | **int?**| Number of groups to be fetched by one request. The maximum value is 250, by default - 30. | [optional] [default to 30]
 **pageToken** | **string**| Token of a page to be returned | [optional] 

### Return type

[**GlipEventsInfo**](GlipEventsInfo.md)

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


## UpdateEvent

> GlipEventInfo UpdateEvent (string eventId, GlipEventCreate glipEventCreate)

Update Event

Updates the specified calendar event.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarEventsApi(Configuration.Default);
            var eventId = "eventId_example";  // string | Internal identifier of an event
            var glipEventCreate = new GlipEventCreate(); // GlipEventCreate | 

            try
            {
                // Update Event
                GlipEventInfo result = apiInstance.UpdateEvent(eventId, glipEventCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CalendarEventsApi.UpdateEvent: " + e.Message );
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
 **eventId** | **string**| Internal identifier of an event | 
 **glipEventCreate** | [**GlipEventCreate**](GlipEventCreate.md)|  | 

### Return type

[**GlipEventInfo**](GlipEventInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Event to update not exists. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

