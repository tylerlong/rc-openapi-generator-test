# Org.OpenAPITools.Api.CallQueuesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignMultipleCallQueueMembers**](CallQueuesApi.md#assignmultiplecallqueuemembers) | **POST** /restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign | Assign Multiple Call Queue Members
[**AssignMultipleDepartmentMembers**](CallQueuesApi.md#assignmultipledepartmentmembers) | **POST** /restapi/v1.0/account/{accountId}/department/bulk-assign | Assign Multiple Department Members
[**ListCallQueueMembers**](CallQueuesApi.md#listcallqueuemembers) | **GET** /restapi/v1.0/account/{accountId}/call-queues/{groupId}/members | Get Call Queue Members
[**ListCallQueues**](CallQueuesApi.md#listcallqueues) | **GET** /restapi/v1.0/account/{accountId}/call-queues | Get Call Queue List
[**ListDepartmentMembers**](CallQueuesApi.md#listdepartmentmembers) | **GET** /restapi/v1.0/account/{accountId}/department/{departmentId}/members | Get Department Member List
[**ReadCallQueueInfo**](CallQueuesApi.md#readcallqueueinfo) | **GET** /restapi/v1.0/account/{accountId}/call-queues/{groupId} | Get Call Queue
[**UpdateCallQueueInfo**](CallQueuesApi.md#updatecallqueueinfo) | **PUT** /restapi/v1.0/account/{accountId}/call-queues/{groupId} | Update Call Queue
[**UpdateUserCallQueues**](CallQueuesApi.md#updateusercallqueues) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queues | Update User Call Queues



## AssignMultipleCallQueueMembers

> void AssignMultipleCallQueueMembers (string accountId, string groupId, CallQueueBulkAssignResource callQueueBulkAssignResource)

Assign Multiple Call Queue Members

Updates a call queue group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignMultipleCallQueueMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 
            var callQueueBulkAssignResource = new CallQueueBulkAssignResource(); // CallQueueBulkAssignResource | Changes for the given group

            try
            {
                // Assign Multiple Call Queue Members
                apiInstance.AssignMultipleCallQueueMembers(accountId, groupId, callQueueBulkAssignResource);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.AssignMultipleCallQueueMembers: " + e.Message );
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
 **groupId** | **string**|  | 
 **callQueueBulkAssignResource** | [**CallQueueBulkAssignResource**](CallQueueBulkAssignResource.md)| Changes for the given group | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | Extension of type [${extensionType}] cannot be included into call queue |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AssignMultipleDepartmentMembers

> void AssignMultipleDepartmentMembers (string accountId, DepartmentBulkAssignResource departmentBulkAssignResource = null)

Assign Multiple Department Members

Adds and/or removes multiple call queue members. Please note, that this method is deprecated and legacy 'Department' entity corresponds to 'Call Queue' in modern RingCentral product terminology. In order to assign multiple call queue members please use the following method `POST/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignMultipleDepartmentMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var departmentBulkAssignResource = new DepartmentBulkAssignResource(); // DepartmentBulkAssignResource |  (optional) 

            try
            {
                // Assign Multiple Department Members
                apiInstance.AssignMultipleDepartmentMembers(accountId, departmentBulkAssignResource);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.AssignMultipleDepartmentMembers: " + e.Message );
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
 **departmentBulkAssignResource** | [**DepartmentBulkAssignResource**](DepartmentBulkAssignResource.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCallQueueMembers

> CallQueueMembers ListCallQueueMembers (string accountId, string groupId, int? page = null, int? perPage = null)

Get Call Queue Members

Returns call queue group members.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallQueueMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are allowed (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Call Queue Members
                CallQueueMembers result = apiInstance.ListCallQueueMembers(accountId, groupId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.ListCallQueueMembers: " + e.Message );
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
 **groupId** | **string**|  | 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are allowed | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**CallQueueMembers**](CallQueueMembers.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCallQueues

> CallQueues ListCallQueues (string accountId, int? page = null, int? perPage = null, string memberExtensionId = null)

Get Call Queue List

Returns call queue group list.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallQueuesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var memberExtensionId = "memberExtensionId_example";  // string | Internal identifier of an extension that is a member of every group within the result (optional) 

            try
            {
                // Get Call Queue List
                CallQueues result = apiInstance.ListCallQueues(accountId, page, perPage, memberExtensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.ListCallQueues: " + e.Message );
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
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **memberExtensionId** | **string**| Internal identifier of an extension that is a member of every group within the result | [optional] 

### Return type

[**CallQueues**](CallQueues.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListDepartmentMembers

> DepartmentMemberList ListDepartmentMembers (string accountId, long departmentId, int? page = null, int? perPage = null)

Get Department Member List

Viewing user account info (including name, business name, address and phone number/account number). Please note, that this method is deprecated and legacy 'Department' entity corresponds to 'Call Queue' in modern RingCentral product terminology. In order to retrieve call queue members please use the following method `GET/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListDepartmentMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var departmentId = 789L;  // long | Internal identifier of a Department extension (same as extensionId but only the ID of a department extension is valid). Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Department Member List
                DepartmentMemberList result = apiInstance.ListDepartmentMembers(accountId, departmentId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.ListDepartmentMembers: " + e.Message );
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
 **departmentId** | **long**| Internal identifier of a Department extension (same as extensionId but only the ID of a department extension is valid). Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**DepartmentMemberList**](DepartmentMemberList.md)

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


## ReadCallQueueInfo

> CallQueueDetails ReadCallQueueInfo (string accountId, string groupId)

Get Call Queue

Returns basic information on a call queue group extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallQueueInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 

            try
            {
                // Get Call Queue
                CallQueueDetails result = apiInstance.ReadCallQueueInfo(accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.ReadCallQueueInfo: " + e.Message );
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
 **groupId** | **string**|  | 

### Return type

[**CallQueueDetails**](CallQueueDetails.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call Queue Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCallQueueInfo

> CallQueueDetails UpdateCallQueueInfo (string accountId, string groupId, CallQueueUpdateDetails callQueueUpdateDetails)

Update Call Queue

Updates information on a call queue group extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallQueueInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 
            var callQueueUpdateDetails = new CallQueueUpdateDetails(); // CallQueueUpdateDetails | 

            try
            {
                // Update Call Queue
                CallQueueDetails result = apiInstance.UpdateCallQueueInfo(accountId, groupId, callQueueUpdateDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.UpdateCallQueueInfo: " + e.Message );
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
 **groupId** | **string**|  | 
 **callQueueUpdateDetails** | [**CallQueueUpdateDetails**](CallQueueUpdateDetails.md)|  | 

### Return type

[**CallQueueDetails**](CallQueueDetails.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Call Queue Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUserCallQueues

> UserCallQueues UpdateUserCallQueues (string accountId, string extensionId, UserCallQueues userCallQueues)

Update User Call Queues

Updates the list of call queues where the user is an agent. This is a full update request, which means that if any queue where the user is an agent is not mentioned in request, then the user is automatically removed from this queue.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserCallQueuesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallQueuesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var userCallQueues = new UserCallQueues(); // UserCallQueues | 

            try
            {
                // Update User Call Queues
                UserCallQueues result = apiInstance.UpdateUserCallQueues(accountId, extensionId, userCallQueues);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallQueuesApi.UpdateUserCallQueues: " + e.Message );
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
 **userCallQueues** | [**UserCallQueues**](UserCallQueues.md)|  | 

### Return type

[**UserCallQueues**](UserCallQueues.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

