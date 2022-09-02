# Org.OpenAPITools.Api.PagingOnlyGroupsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignMultiplePagingGroupUsersDevices**](PagingOnlyGroupsApi.md#assignmultiplepaginggroupusersdevices) | **POST** /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign | Assign Paging Group Users and Devices
[**ListPagingGroupDevices**](PagingOnlyGroupsApi.md#listpaginggroupdevices) | **GET** /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices | Get Paging Group Devices
[**ListPagingGroupUsers**](PagingOnlyGroupsApi.md#listpaginggroupusers) | **GET** /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users | Get Paging Group Users



## AssignMultiplePagingGroupUsersDevices

> void AssignMultiplePagingGroupUsersDevices (string accountId, string pagingOnlyGroupId, EditPagingGroupRequest editPagingGroupRequest = null)

Assign Paging Group Users and Devices

Adds and/or removes paging group users and devices.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignMultiplePagingGroupUsersDevicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PagingOnlyGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var pagingOnlyGroupId = "pagingOnlyGroupId_example";  // string | Internal identifier of a paging group
            var editPagingGroupRequest = new EditPagingGroupRequest(); // EditPagingGroupRequest |  (optional) 

            try
            {
                // Assign Paging Group Users and Devices
                apiInstance.AssignMultiplePagingGroupUsersDevices(accountId, pagingOnlyGroupId, editPagingGroupRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PagingOnlyGroupsApi.AssignMultiplePagingGroupUsersDevices: " + e.Message );
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
 **pagingOnlyGroupId** | **string**| Internal identifier of a paging group | 
 **editPagingGroupRequest** | [**EditPagingGroupRequest**](EditPagingGroupRequest.md)|  | [optional] 

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
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPagingGroupDevices

> PagingOnlyGroupDevices ListPagingGroupDevices (string accountId, string pagingOnlyGroupId, int? page = null, int? perPage = null)

Get Paging Group Devices

Returns the list of paging devices assigned to this group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListPagingGroupDevicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PagingOnlyGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var pagingOnlyGroupId = "pagingOnlyGroupId_example";  // string | Internal identifier of a paging group
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Paging Group Devices
                PagingOnlyGroupDevices result = apiInstance.ListPagingGroupDevices(accountId, pagingOnlyGroupId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PagingOnlyGroupsApi.ListPagingGroupDevices: " + e.Message );
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
 **pagingOnlyGroupId** | **string**| Internal identifier of a paging group | 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**PagingOnlyGroupDevices**](PagingOnlyGroupDevices.md)

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


## ListPagingGroupUsers

> PagingOnlyGroupUsers ListPagingGroupUsers (string accountId, string pagingOnlyGroupId, int? page = null, int? perPage = null)

Get Paging Group Users

Returns the list of users allowed to page this group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListPagingGroupUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PagingOnlyGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var pagingOnlyGroupId = "pagingOnlyGroupId_example";  // string | Internal identifier of a paging group
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Paging Group Users
                PagingOnlyGroupUsers result = apiInstance.ListPagingGroupUsers(accountId, pagingOnlyGroupId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PagingOnlyGroupsApi.ListPagingGroupUsers: " + e.Message );
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
 **pagingOnlyGroupId** | **string**| Internal identifier of a paging group | 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**PagingOnlyGroupUsers**](PagingOnlyGroupUsers.md)

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

