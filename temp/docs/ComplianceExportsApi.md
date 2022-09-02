# Org.OpenAPITools.Api.ComplianceExportsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDataExportTask**](ComplianceExportsApi.md#createdataexporttask) | **POST** /restapi/v1.0/glip/data-export | Create Data Export Task
[**ListDataExportTasks**](ComplianceExportsApi.md#listdataexporttasks) | **GET** /restapi/v1.0/glip/data-export | Get Data Export Task List
[**ReadDataExportTask**](ComplianceExportsApi.md#readdataexporttask) | **GET** /restapi/v1.0/glip/data-export/{taskId} | Get Data Export Task
[**ReadDataExportTaskDataset**](ComplianceExportsApi.md#readdataexporttaskdataset) | **GET** /restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId} | Get Data Export Task Dataset



## CreateDataExportTask

> DataExportTask CreateDataExportTask (CreateDataExportTaskRequest createDataExportTaskRequest = null)

Create Data Export Task

Creates a task for Glip data export and returns a link at which the exported data will be available in future once the task is implemented. The exported data can be downloaded by calling Get Data Export Task method with the specified task ID. Simultaneously no more than 2 tasks per company can be created.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateDataExportTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceExportsApi(Configuration.Default);
            var createDataExportTaskRequest = new CreateDataExportTaskRequest(); // CreateDataExportTaskRequest | JSON body (optional) 

            try
            {
                // Create Data Export Task
                DataExportTask result = apiInstance.CreateDataExportTask(createDataExportTaskRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ComplianceExportsApi.CreateDataExportTask: " + e.Message );
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
 **createDataExportTaskRequest** | [**CreateDataExportTaskRequest**](CreateDataExportTaskRequest.md)| JSON body | [optional] 

### Return type

[**DataExportTask**](DataExportTask.md)

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


## ListDataExportTasks

> DataExportTaskList ListDataExportTasks (string status = null, int? page = null, int? perPage = null)

Get Data Export Task List

Returns the list of Glip data export tasks.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListDataExportTasksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceExportsApi(Configuration.Default);
            var status = "Accepted";  // string | Status of the task(s) to be returned. Multiple values are supported (optional) 
            var page = 1;  // int? | Page number to be retrieved; value range is > 0 (optional)  (default to 1)
            var perPage = 30;  // int? | Number of records to be returned per page; value range is 1 - 250 (optional)  (default to 30)

            try
            {
                // Get Data Export Task List
                DataExportTaskList result = apiInstance.ListDataExportTasks(status, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ComplianceExportsApi.ListDataExportTasks: " + e.Message );
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
 **status** | **string**| Status of the task(s) to be returned. Multiple values are supported | [optional] 
 **page** | **int?**| Page number to be retrieved; value range is &gt; 0 | [optional] [default to 1]
 **perPage** | **int?**| Number of records to be returned per page; value range is 1 - 250 | [optional] [default to 30]

### Return type

[**DataExportTaskList**](DataExportTaskList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data Export Task List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadDataExportTask

> DataExportTask ReadDataExportTask (string taskId)

Get Data Export Task

Returns the links for downloading Glip data exported within the specified task. If the export task is still in progress, then only the task status will be returned. If the data is ready for downloading, then the list of URLs will be returned.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadDataExportTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceExportsApi(Configuration.Default);
            var taskId = "taskId_example";  // string | Internal identifier of a task to be retrieved

            try
            {
                // Get Data Export Task
                DataExportTask result = apiInstance.ReadDataExportTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ComplianceExportsApi.ReadDataExportTask: " + e.Message );
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
 **taskId** | **string**| Internal identifier of a task to be retrieved | 

### Return type

[**DataExportTask**](DataExportTask.md)

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


## ReadDataExportTaskDataset

> System.IO.Stream ReadDataExportTaskDataset (string taskId, string datasetId)

Get Data Export Task Dataset

Returns the specified dataset by ID. Each dataset is a ZIP archive the size of which is limited to 1 Gb.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadDataExportTaskDatasetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceExportsApi(Configuration.Default);
            var taskId = "taskId_example";  // string | Internal identifier of a task
            var datasetId = "datasetId_example";  // string | Internal identifier of a dataset

            try
            {
                // Get Data Export Task Dataset
                System.IO.Stream result = apiInstance.ReadDataExportTaskDataset(taskId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ComplianceExportsApi.ReadDataExportTaskDataset: " + e.Message );
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
 **taskId** | **string**| Internal identifier of a task | 
 **datasetId** | **string**| Internal identifier of a dataset | 

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dataset Zip Archive |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

