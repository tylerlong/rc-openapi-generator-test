# Org.OpenAPITools.Api.MessageExportsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMessageStoreReport**](MessageExportsApi.md#createmessagestorereport) | **POST** /restapi/v1.0/account/{accountId}/message-store-report | Create Message Store Report
[**ReadMessageStoreReportArchive**](MessageExportsApi.md#readmessagestorereportarchive) | **GET** /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive | Get Message Store Report Archive
[**ReadMessageStoreReportArchiveContent**](MessageExportsApi.md#readmessagestorereportarchivecontent) | **GET** /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId} | Get Message Store Report Archive Content
[**ReadMessageStoreReportTask**](MessageExportsApi.md#readmessagestorereporttask) | **GET** /restapi/v1.0/account/{accountId}/message-store-report/{taskId} | Get Message Store Report Task



## CreateMessageStoreReport

> MessageStoreReport CreateMessageStoreReport (string accountId, CreateMessageStoreReportRequest createMessageStoreReportRequest = null)

Create Message Store Report

Creates a task to collect all account messages within the specified time interval. Maximum number of simultaneous tasks per account is 2. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateMessageStoreReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageExportsApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var createMessageStoreReportRequest = new CreateMessageStoreReportRequest(); // CreateMessageStoreReportRequest |  (optional) 

            try
            {
                // Create Message Store Report
                MessageStoreReport result = apiInstance.CreateMessageStoreReport(accountId, createMessageStoreReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageExportsApi.CreateMessageStoreReport: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **createMessageStoreReportRequest** | [**CreateMessageStoreReportRequest**](CreateMessageStoreReportRequest.md)|  | [optional] 

### Return type

[**MessageStoreReport**](MessageStoreReport.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Success |  -  |
| **400** | Bad request, path, query or body parameters are invalid (HTTP 400) |  -  |
| **500** | Internal service error (HTTP 500) |  -  |
| **503** | Service not available(HTTP 503) |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMessageStoreReportArchive

> MessageStoreReportArchive ReadMessageStoreReportArchive (string accountId, string taskId)

Get Message Store Report Archive

Returns the created report with message data not including attachments.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMessageStoreReportArchiveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageExportsApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var taskId = 400142200026-400142200026-bd162f24028442489385eb3f44c18354;  // string | Internal identifier of a task

            try
            {
                // Get Message Store Report Archive
                MessageStoreReportArchive result = apiInstance.ReadMessageStoreReportArchive(accountId, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageExportsApi.ReadMessageStoreReportArchive: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **taskId** | **string**| Internal identifier of a task | 

### Return type

[**MessageStoreReportArchive**](MessageStoreReportArchive.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Internal service error (HTTP 500) |  -  |
| **503** | Service not available(HTTP 503) |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMessageStoreReportArchiveContent

> System.IO.Stream ReadMessageStoreReportArchiveContent (string accountId, string taskId, string archiveId)

Get Message Store Report Archive Content

Returns one of the report archives with message contents in application/zip format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMessageStoreReportArchiveContentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageExportsApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var taskId = 400142200026-400142200026-bd162f24028442489385eb3f44c18354;  // string | Internal identifier of a task
            var archiveId = 987654;  // string | Internal identifier of an archive volume to download

            try
            {
                // Get Message Store Report Archive Content
                System.IO.Stream result = apiInstance.ReadMessageStoreReportArchiveContent(accountId, taskId, archiveId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageExportsApi.ReadMessageStoreReportArchiveContent: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **taskId** | **string**| Internal identifier of a task | 
 **archiveId** | **string**| Internal identifier of an archive volume to download | 

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/zip, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Archived Data |  -  |
| **500** | Internal service error (HTTP 500) |  -  |
| **503** | Service not available(HTTP 503) |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMessageStoreReportTask

> MessageStoreReport ReadMessageStoreReportTask (string accountId, string taskId)

Get Message Store Report Task

Returns the current status of a task on report creation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMessageStoreReportTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageExportsApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var taskId = 400142200026-400142200026-bd162f24028442489385eb3f44c18354;  // string | Internal identifier of a task

            try
            {
                // Get Message Store Report Task
                MessageStoreReport result = apiInstance.ReadMessageStoreReportTask(accountId, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageExportsApi.ReadMessageStoreReportTask: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **taskId** | **string**| Internal identifier of a task | 

### Return type

[**MessageStoreReport**](MessageStoreReport.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Internal service error (HTTP 500) |  -  |
| **503** | Service not available(HTTP 503) |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

