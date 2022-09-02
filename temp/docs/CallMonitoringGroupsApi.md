# Org.OpenAPITools.Api.CallMonitoringGroupsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCallMonitoringGroup**](CallMonitoringGroupsApi.md#createcallmonitoringgroup) | **POST** /restapi/v1.0/account/{accountId}/call-monitoring-groups | Create Call Monitoring Group
[**DeleteCallMonitoringGroup**](CallMonitoringGroupsApi.md#deletecallmonitoringgroup) | **DELETE** /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId} | Delete Call Monitoring Group
[**ListCallMonitoringGroupMembers**](CallMonitoringGroupsApi.md#listcallmonitoringgroupmembers) | **GET** /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members | Get Call Monitoring Group Member List
[**ListCallMonitoringGroups**](CallMonitoringGroupsApi.md#listcallmonitoringgroups) | **GET** /restapi/v1.0/account/{accountId}/call-monitoring-groups | Get Call Monitoring Groups List
[**UpdateCallMonitoringGroup**](CallMonitoringGroupsApi.md#updatecallmonitoringgroup) | **PUT** /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId} | Updates Call Monitoring Group
[**UpdateCallMonitoringGroupList**](CallMonitoringGroupsApi.md#updatecallmonitoringgrouplist) | **POST** /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign | Update Call Monitoring Group List



## CreateCallMonitoringGroup

> CallMonitoringGroup CreateCallMonitoringGroup (string accountId, CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest)

Create Call Monitoring Group

Creates a new call monitoring group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCallMonitoringGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallMonitoringGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var createCallMonitoringGroupRequest = new CreateCallMonitoringGroupRequest(); // CreateCallMonitoringGroupRequest | Parameters of a call monitoring group that will be created

            try
            {
                // Create Call Monitoring Group
                CallMonitoringGroup result = apiInstance.CreateCallMonitoringGroup(accountId, createCallMonitoringGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallMonitoringGroupsApi.CreateCallMonitoringGroup: " + e.Message );
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
 **createCallMonitoringGroupRequest** | [**CreateCallMonitoringGroupRequest**](CreateCallMonitoringGroupRequest.md)| Parameters of a call monitoring group that will be created | 

### Return type

[**CallMonitoringGroup**](CallMonitoringGroup.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCallMonitoringGroup

> void DeleteCallMonitoringGroup (string accountId, string groupId)

Delete Call Monitoring Group

Removes information about the given call monitoring group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCallMonitoringGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallMonitoringGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 

            try
            {
                // Delete Call Monitoring Group
                apiInstance.DeleteCallMonitoringGroup(accountId, groupId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallMonitoringGroupsApi.DeleteCallMonitoringGroup: " + e.Message );
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
| **404** | Group with the given identifier doesn&#39;t belong to the account. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCallMonitoringGroupMembers

> CallMonitoringGroupMemberList ListCallMonitoringGroupMembers (string accountId, string groupId, int? page = null, int? perPage = null)

Get Call Monitoring Group Member List

Returns call monitoring group members.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallMonitoringGroupMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallMonitoringGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are allowed (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Call Monitoring Group Member List
                CallMonitoringGroupMemberList result = apiInstance.ListCallMonitoringGroupMembers(accountId, groupId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallMonitoringGroupsApi.ListCallMonitoringGroupMembers: " + e.Message );
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

[**CallMonitoringGroupMemberList**](CallMonitoringGroupMemberList.md)

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


## ListCallMonitoringGroups

> CallMonitoringGroups ListCallMonitoringGroups (string accountId, int? page = null, int? perPage = null, string memberExtensionId = null)

Get Call Monitoring Groups List

Returns call monitoring groups that can be filtered by some extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallMonitoringGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallMonitoringGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are allowed (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var memberExtensionId = "memberExtensionId_example";  // string | Internal identifier of an extension that is a member of every group within the result (optional) 

            try
            {
                // Get Call Monitoring Groups List
                CallMonitoringGroups result = apiInstance.ListCallMonitoringGroups(accountId, page, perPage, memberExtensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallMonitoringGroupsApi.ListCallMonitoringGroups: " + e.Message );
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
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are allowed | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **memberExtensionId** | **string**| Internal identifier of an extension that is a member of every group within the result | [optional] 

### Return type

[**CallMonitoringGroups**](CallMonitoringGroups.md)

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


## UpdateCallMonitoringGroup

> CallMonitoringGroup UpdateCallMonitoringGroup (string accountId, string groupId, CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest)

Updates Call Monitoring Group

Updates call monitoring group name by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallMonitoringGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallMonitoringGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | Internal identifier of a call monitoring group
            var createCallMonitoringGroupRequest = new CreateCallMonitoringGroupRequest(); // CreateCallMonitoringGroupRequest | Parameters of a call monitoring group that will be updated

            try
            {
                // Updates Call Monitoring Group
                CallMonitoringGroup result = apiInstance.UpdateCallMonitoringGroup(accountId, groupId, createCallMonitoringGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallMonitoringGroupsApi.UpdateCallMonitoringGroup: " + e.Message );
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
 **groupId** | **string**| Internal identifier of a call monitoring group | 
 **createCallMonitoringGroupRequest** | [**CreateCallMonitoringGroupRequest**](CreateCallMonitoringGroupRequest.md)| Parameters of a call monitoring group that will be updated | 

### Return type

[**CallMonitoringGroup**](CallMonitoringGroup.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Value for group name is unacceptable. |  -  |
| **403** | User has no permissions to create groups. |  -  |
| **404** | Group with the given identifier doesn&#39;t belong to the account. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCallMonitoringGroupList

> void UpdateCallMonitoringGroupList (string accountId, string groupId, CallMonitoringBulkAssign callMonitoringBulkAssign)

Update Call Monitoring Group List

Updates call monitoring groups.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallMonitoringGroupListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallMonitoringGroupsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | 
            var callMonitoringBulkAssign = new CallMonitoringBulkAssign(); // CallMonitoringBulkAssign | Changes for the given group

            try
            {
                // Update Call Monitoring Group List
                apiInstance.UpdateCallMonitoringGroupList(accountId, groupId, callMonitoringBulkAssign);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallMonitoringGroupsApi.UpdateCallMonitoringGroupList: " + e.Message );
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
 **callMonitoringBulkAssign** | [**CallMonitoringBulkAssign**](CallMonitoringBulkAssign.md)| Changes for the given group | 

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
| **204** | No Content |  -  |
| **400** | Extension of type [ParkLocation] could not be a member of [call monitoring] |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

