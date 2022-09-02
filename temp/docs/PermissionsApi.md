# Org.OpenAPITools.Api.PermissionsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListPermissionCategories**](PermissionsApi.md#listpermissioncategories) | **GET** /restapi/v1.0/dictionary/permission-category | Get Permission Category List
[**ListPermissions**](PermissionsApi.md#listpermissions) | **GET** /restapi/v1.0/dictionary/permission | Get Permission List
[**ReadPermission**](PermissionsApi.md#readpermission) | **GET** /restapi/v1.0/dictionary/permission/{permissionId} | Get Permission
[**ReadPermissionCategory**](PermissionsApi.md#readpermissioncategory) | **GET** /restapi/v1.0/dictionary/permission-category/{permissionCategoryId} | Get Permission Category



## ListPermissionCategories

> PermissionCategoryCollectionResource ListPermissionCategories (string page = null, string perPage = null, string servicePlanId = null)

Get Permission Category List

Returns the list of permission categories.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListPermissionCategoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsApi(Configuration.Default);
            var page = "\"1\"";  // string |  (optional)  (default to "1")
            var perPage = "\"100\"";  // string |  (optional)  (default to "100")
            var servicePlanId = "servicePlanId_example";  // string |  (optional) 

            try
            {
                // Get Permission Category List
                PermissionCategoryCollectionResource result = apiInstance.ListPermissionCategories(page, perPage, servicePlanId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PermissionsApi.ListPermissionCategories: " + e.Message );
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
 **page** | **string**|  | [optional] [default to &quot;1&quot;]
 **perPage** | **string**|  | [optional] [default to &quot;100&quot;]
 **servicePlanId** | **string**|  | [optional] 

### Return type

[**PermissionCategoryCollectionResource**](PermissionCategoryCollectionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPermissions

> PermissionCollectionResource ListPermissions (string page = null, string perPage = null, bool? assignable = null, string servicePlanId = null)

Get Permission List

Returns a list of extension user permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListPermissionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsApi(Configuration.Default);
            var page = "\"1\"";  // string |  (optional)  (default to "1")
            var perPage = "\"100\"";  // string |  (optional)  (default to "100")
            var assignable = true;  // bool? |  (optional) 
            var servicePlanId = "servicePlanId_example";  // string |  (optional) 

            try
            {
                // Get Permission List
                PermissionCollectionResource result = apiInstance.ListPermissions(page, perPage, assignable, servicePlanId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PermissionsApi.ListPermissions: " + e.Message );
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
 **page** | **string**|  | [optional] [default to &quot;1&quot;]
 **perPage** | **string**|  | [optional] [default to &quot;100&quot;]
 **assignable** | **bool?**|  | [optional] 
 **servicePlanId** | **string**|  | [optional] 

### Return type

[**PermissionCollectionResource**](PermissionCollectionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadPermission

> PermissionResource ReadPermission (string permissionId)

Get Permission

Returns user permission by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadPermissionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsApi(Configuration.Default);
            var permissionId = "permissionId_example";  // string | 

            try
            {
                // Get Permission
                PermissionResource result = apiInstance.ReadPermission(permissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PermissionsApi.ReadPermission: " + e.Message );
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
 **permissionId** | **string**|  | 

### Return type

[**PermissionResource**](PermissionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadPermissionCategory

> PermissionCategoryResource ReadPermissionCategory (string permissionCategoryId)

Get Permission Category

Returns permission category by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadPermissionCategoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsApi(Configuration.Default);
            var permissionCategoryId = "permissionCategoryId_example";  // string | 

            try
            {
                // Get Permission Category
                PermissionCategoryResource result = apiInstance.ReadPermissionCategory(permissionCategoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PermissionsApi.ReadPermissionCategory: " + e.Message );
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
 **permissionCategoryId** | **string**|  | 

### Return type

[**PermissionCategoryResource**](PermissionCategoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

