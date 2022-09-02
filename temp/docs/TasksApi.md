# Org.OpenAPITools.Api.TasksApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteTask**](TasksApi.md#completetask) | **POST** /restapi/v1.0/glip/tasks/{taskId}/complete | Complete Task
[**CreateTask**](TasksApi.md#createtask) | **POST** /restapi/v1.0/glip/chats/{chatId}/tasks | Create Task
[**DeleteTask**](TasksApi.md#deletetask) | **DELETE** /restapi/v1.0/glip/tasks/{taskId} | Delete Task
[**ListChatTasks**](TasksApi.md#listchattasks) | **GET** /restapi/v1.0/glip/chats/{chatId}/tasks | Get Chat Tasks
[**PatchTask**](TasksApi.md#patchtask) | **PATCH** /restapi/v1.0/glip/tasks/{taskId} | Update Task
[**ReadTask**](TasksApi.md#readtask) | **GET** /restapi/v1.0/glip/tasks/{taskId} | Get Task



## CompleteTask

> void CompleteTask (string taskId, GlipCompleteTask glipCompleteTask)

Complete Task

Completes a task in the specified chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompleteTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(Configuration.Default);
            var taskId = "taskId_example";  // string | Internal identifier of a task
            var glipCompleteTask = new GlipCompleteTask(); // GlipCompleteTask | JSON body

            try
            {
                // Complete Task
                apiInstance.CompleteTask(taskId, glipCompleteTask);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.CompleteTask: " + e.Message );
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
 **glipCompleteTask** | [**GlipCompleteTask**](GlipCompleteTask.md)| JSON body | 

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
| **400** | Invalid input parameter(-s) |  -  |
| **403** | Forbidden |  -  |
| **404** | Requested task ID does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateTask

> GlipTaskInfo CreateTask (string chatId, GlipCreateTask glipCreateTask)

Create Task

Creates a task in the specified chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat
            var glipCreateTask = new GlipCreateTask(); // GlipCreateTask | 

            try
            {
                // Create Task
                GlipTaskInfo result = apiInstance.CreateTask(chatId, glipCreateTask);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat | 
 **glipCreateTask** | [**GlipCreateTask**](GlipCreateTask.md)|  | 

### Return type

[**GlipTaskInfo**](GlipTaskInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Task information |  -  |
| **400** | Invalid input parameter(-s) |  -  |
| **403** | Forbidden |  -  |
| **404** | Specified chat ID does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteTask

> void DeleteTask (string taskId)

Delete Task

Deletes the specified task.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(Configuration.Default);
            var taskId = "taskId_example";  // string | Internal identifier of a task

            try
            {
                // Delete Task
                apiInstance.DeleteTask(taskId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTask: " + e.Message );
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
| **403** | Forbidden |  -  |
| **404** | Task with the specified ID does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListChatTasks

> GlipTaskList ListChatTasks (string chatId, string creationTimeTo = null, string creationTimeFrom = null, List<string> creatorId = null, List<string> status = null, string assignmentStatus = null, List<string> assigneeId = null, string assigneeStatus = null, string pageToken = null, int? recordCount = null)

Get Chat Tasks

Returns the list of tasks of the specified chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListChatTasksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat
            var creationTimeTo = "\"now\"";  // string | The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2019-03-10T18:23:45Z (optional)  (default to "now")
            var creationTimeFrom = "creationTimeFrom_example";  // string | The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2016-02-23T00:00:00 (optional) 
            var creatorId = new List<string>(); // List<string> | Internal identifier of a task creator (optional) 
            var status = new List<string>(); // List<string> | Task execution status (optional) 
            var assignmentStatus = "Unassigned";  // string | Task assignment status (optional) 
            var assigneeId = new List<string>(); // List<string> | Internal identifier of a task assignee (optional) 
            var assigneeStatus = "Pending";  // string | Task execution status by assignee(-s) specified in assigneeId (optional) 
            var pageToken = "pageToken_example";  // string | Token of the current page. If token is omitted then the first page should be returned (optional) 
            var recordCount = 30;  // int? | Number of records to be returned per screen (optional)  (default to 30)

            try
            {
                // Get Chat Tasks
                GlipTaskList result = apiInstance.ListChatTasks(chatId, creationTimeTo, creationTimeFrom, creatorId, status, assignmentStatus, assigneeId, assigneeStatus, pageToken, recordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.ListChatTasks: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat | 
 **creationTimeTo** | **string**| The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2019-03-10T18:23:45Z | [optional] [default to &quot;now&quot;]
 **creationTimeFrom** | **string**| The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2016-02-23T00:00:00 | [optional] 
 **creatorId** | [**List&lt;string&gt;**](string.md)| Internal identifier of a task creator | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| Task execution status | [optional] 
 **assignmentStatus** | **string**| Task assignment status | [optional] 
 **assigneeId** | [**List&lt;string&gt;**](string.md)| Internal identifier of a task assignee | [optional] 
 **assigneeStatus** | **string**| Task execution status by assignee(-s) specified in assigneeId | [optional] 
 **pageToken** | **string**| Token of the current page. If token is omitted then the first page should be returned | [optional] 
 **recordCount** | **int?**| Number of records to be returned per screen | [optional] [default to 30]

### Return type

[**GlipTaskList**](GlipTaskList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid input parameter(-s) |  -  |
| **403** | Forbidden |  -  |
| **404** | Specified chat ID does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchTask

> GlipTaskList PatchTask (string taskId, GlipUpdateTask glipUpdateTask = null)

Update Task

Updates the specified task by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(Configuration.Default);
            var taskId = "taskId_example";  // string | Internal identifier of a task
            var glipUpdateTask = new GlipUpdateTask(); // GlipUpdateTask | JSON body (optional) 

            try
            {
                // Update Task
                GlipTaskList result = apiInstance.PatchTask(taskId, glipUpdateTask);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.PatchTask: " + e.Message );
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
 **glipUpdateTask** | [**GlipUpdateTask**](GlipUpdateTask.md)| JSON body | [optional] 

### Return type

[**GlipTaskList**](GlipTaskList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Tasks |  -  |
| **400** | Invalid input parameter(-s) |  -  |
| **403** | Forbidden |  -  |
| **404** | Task with the specified ID does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadTask

> GlipTaskInfo ReadTask (string taskId)

Get Task

Returns information about the specified task(s) by ID(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(Configuration.Default);
            var taskId = "taskId_example";  // string | Internal identifier of a task, or comma separated list of task IDs

            try
            {
                // Get Task
                GlipTaskInfo result = apiInstance.ReadTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.ReadTask: " + e.Message );
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
 **taskId** | **string**| Internal identifier of a task, or comma separated list of task IDs | 

### Return type

[**GlipTaskInfo**](GlipTaskInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Task Information |  -  |
| **400** | Invalid input parameter(-s) |  -  |
| **403** | Forbidden |  -  |
| **404** | Requested task ID does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

