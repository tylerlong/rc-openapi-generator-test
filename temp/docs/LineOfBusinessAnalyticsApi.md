# Org.OpenAPITools.Api.LineOfBusinessAnalyticsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AggregatePerformanceReportCalls**](LineOfBusinessAnalyticsApi.md#aggregateperformancereportcalls) | **POST** /analytics/phone/performance/v1/accounts/{accountId}/calls/aggregate | Aggregate Call Performance Data
[**AnalyticsCallsAggregationFetch**](LineOfBusinessAnalyticsApi.md#analyticscallsaggregationfetch) | **POST** /analytics/calls/v1/accounts/{accountId}/aggregation/fetch | Calls Aggregation Data
[**AnalyticsCallsTimelineFetch**](LineOfBusinessAnalyticsApi.md#analyticscallstimelinefetch) | **POST** /analytics/calls/v1/accounts/{accountId}/timeline/fetch | Calls Timeline Data
[**PerformanceReportCallsTimeline**](LineOfBusinessAnalyticsApi.md#performancereportcallstimeline) | **POST** /analytics/phone/performance/v1/accounts/{accountId}/calls/timeline | Timeline Call Performance Data



## AggregatePerformanceReportCalls

> AnalyticsLegacyPerformanceCallsAggregatesResponse AggregatePerformanceReportCalls (string accountId, AnalyticsLegacyPerformanceCallsAggregatesRequest analyticsLegacyPerformanceCallsAggregatesRequest, int? page = null, int? perPage = null)

Aggregate Call Performance Data

Returns call performance aggregations filtered by parameters specified. This API is deprecated, and it will be disabled after September 8th. Please use [new version](https://developers.ringcentral.com/api-reference/Line-Of-Business-Analytics/analyticsCallsAggregationFetch) instead.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AggregatePerformanceReportCallsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LineOfBusinessAnalyticsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var analyticsLegacyPerformanceCallsAggregatesRequest = new AnalyticsLegacyPerformanceCallsAggregatesRequest(); // AnalyticsLegacyPerformanceCallsAggregatesRequest | 
            var page = 56;  // int? | The current page number (optional) 
            var perPage = 56;  // int? | Number of records displayed on a page (optional) 

            try
            {
                // Aggregate Call Performance Data
                AnalyticsLegacyPerformanceCallsAggregatesResponse result = apiInstance.AggregatePerformanceReportCalls(accountId, analyticsLegacyPerformanceCallsAggregatesRequest, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LineOfBusinessAnalyticsApi.AggregatePerformanceReportCalls: " + e.Message );
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
 **analyticsLegacyPerformanceCallsAggregatesRequest** | [**AnalyticsLegacyPerformanceCallsAggregatesRequest**](AnalyticsLegacyPerformanceCallsAggregatesRequest.md)|  | 
 **page** | **int?**| The current page number | [optional] 
 **perPage** | **int?**| Number of records displayed on a page | [optional] 

### Return type

[**AnalyticsLegacyPerformanceCallsAggregatesResponse**](AnalyticsLegacyPerformanceCallsAggregatesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Performance Calls Aggregates |  -  |
| **400** | Request is invalid (e.g. malformed request syntax, invalid request parameters, etc.) |  -  |
| **401** | Client must authenticate itself to get the requested response |  -  |
| **403** | The client does not have access rights to the content |  -  |
| **500** | The server has encountered a situation it does not know how to handle |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AnalyticsCallsAggregationFetch

> AggregationResponse AnalyticsCallsAggregationFetch (string accountId, AggregationRequest aggregationRequest, int? page = null, int? perPage = null)

Calls Aggregation Data

Returns call aggregations filtered by parameters specified

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnalyticsCallsAggregationFetchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LineOfBusinessAnalyticsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var aggregationRequest = new AggregationRequest(); // AggregationRequest | 
            var page = 56;  // int? | The current page number (positive numbers only) (optional) 
            var perPage = 56;  // int? | Number of records displayed on a page (positive numbers only, max value of 200) (optional) 

            try
            {
                // Calls Aggregation Data
                AggregationResponse result = apiInstance.AnalyticsCallsAggregationFetch(accountId, aggregationRequest, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LineOfBusinessAnalyticsApi.AnalyticsCallsAggregationFetch: " + e.Message );
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
 **aggregationRequest** | [**AggregationRequest**](AggregationRequest.md)|  | 
 **page** | **int?**| The current page number (positive numbers only) | [optional] 
 **perPage** | **int?**| Number of records displayed on a page (positive numbers only, max value of 200) | [optional] 

### Return type

[**AggregationResponse**](AggregationResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Calls Aggregation |  -  |
| **400** | Request is invalid (e.g. malformed request syntax, invalid request parameters, etc.) |  -  |
| **401** | Client must authenticate itself to get the requested response |  -  |
| **403** | The client does not have access rights to the content |  -  |
| **500** | The server has encountered a situation it does not know how to handle |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AnalyticsCallsTimelineFetch

> TimelineResponse AnalyticsCallsTimelineFetch (string accountId, Interval interval, TimelineRequest timelineRequest, int? page = null, int? perPage = null)

Calls Timeline Data

Returns time-value data aggregations filtered by parameters specified

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnalyticsCallsTimelineFetchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LineOfBusinessAnalyticsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var interval = (Interval) "Hour";  // Interval | Aggregation interval
            var timelineRequest = new TimelineRequest(); // TimelineRequest | 
            var page = 56;  // int? | The current page number (positive numbers only) (optional) 
            var perPage = 56;  // int? | Number of records displayed on a page (positive numbers only, max value of 20) (optional) 

            try
            {
                // Calls Timeline Data
                TimelineResponse result = apiInstance.AnalyticsCallsTimelineFetch(accountId, interval, timelineRequest, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LineOfBusinessAnalyticsApi.AnalyticsCallsTimelineFetch: " + e.Message );
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
 **interval** | **Interval**| Aggregation interval | 
 **timelineRequest** | [**TimelineRequest**](TimelineRequest.md)|  | 
 **page** | **int?**| The current page number (positive numbers only) | [optional] 
 **perPage** | **int?**| Number of records displayed on a page (positive numbers only, max value of 20) | [optional] 

### Return type

[**TimelineResponse**](TimelineResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Calls Timeline |  -  |
| **400** | Request is invalid (e.g. malformed request syntax, invalid request parameters, etc.) |  -  |
| **401** | Client must authenticate itself to get the requested response |  -  |
| **403** | The client does not have access rights to the content |  -  |
| **500** | The server has encountered a situation it does not know how to handle |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PerformanceReportCallsTimeline

> AnalyticsLegacyPerformanceCallsTimelineResponse PerformanceReportCallsTimeline (string accountId, AnalyticsLegacyInterval interval, AnalyticsLegacyPerformanceCallsTimelineRequest analyticsLegacyPerformanceCallsTimelineRequest)

Timeline Call Performance Data

Returns time-value data aggregations filtered by parameters specified. This API is deprecated, and it will be disabled after September 8th. Please use [new version](https://developers.ringcentral.com/api-reference/Line-Of-Business-Analytics/analyticsCallsTimelineFetch) instead.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PerformanceReportCallsTimelineExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LineOfBusinessAnalyticsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var interval = (AnalyticsLegacyInterval) "Hour";  // AnalyticsLegacyInterval | Aggregation interval
            var analyticsLegacyPerformanceCallsTimelineRequest = new AnalyticsLegacyPerformanceCallsTimelineRequest(); // AnalyticsLegacyPerformanceCallsTimelineRequest | 

            try
            {
                // Timeline Call Performance Data
                AnalyticsLegacyPerformanceCallsTimelineResponse result = apiInstance.PerformanceReportCallsTimeline(accountId, interval, analyticsLegacyPerformanceCallsTimelineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LineOfBusinessAnalyticsApi.PerformanceReportCallsTimeline: " + e.Message );
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
 **interval** | **AnalyticsLegacyInterval**| Aggregation interval | 
 **analyticsLegacyPerformanceCallsTimelineRequest** | [**AnalyticsLegacyPerformanceCallsTimelineRequest**](AnalyticsLegacyPerformanceCallsTimelineRequest.md)|  | 

### Return type

[**AnalyticsLegacyPerformanceCallsTimelineResponse**](AnalyticsLegacyPerformanceCallsTimelineResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Timeline Call Performance Data |  -  |
| **400** | Request is invalid (e.g. malformed request syntax, invalid request parameters, etc.) |  -  |
| **401** | Client must authenticate itself to get the requested response |  -  |
| **403** | The client does not have access rights to the content |  -  |
| **500** | The server has encountered a situation it does not know how to handle |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

