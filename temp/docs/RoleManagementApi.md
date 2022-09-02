# Org.OpenAPITools.Api.RoleManagementApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignDefaultRole**](RoleManagementApi.md#assigndefaultrole) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/assigned-role/default | Assign Default Role
[**AssignMultipleUserRoles**](RoleManagementApi.md#assignmultipleuserroles) | **POST** /restapi/v1.0/account/{accountId}/user-role/{roleId}/bulk-assign | Assign Multiple User Roles
[**CreateCustomRole**](RoleManagementApi.md#createcustomrole) | **POST** /restapi/v1.0/account/{accountId}/user-role | Create Custom Role
[**DeleteCustomRole**](RoleManagementApi.md#deletecustomrole) | **DELETE** /restapi/v1.0/account/{accountId}/user-role/{roleId} | Delete Custom Role
[**ListAssignedRoles**](RoleManagementApi.md#listassignedroles) | **GET** /restapi/v1.0/account/{accountId}/assigned-role | Get Assigned Role List
[**ListStandardUserRole**](RoleManagementApi.md#liststandarduserrole) | **GET** /restapi/v1.0/dictionary/user-role | Get Standard User Role List
[**ListUserAssignedRoles**](RoleManagementApi.md#listuserassignedroles) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/assigned-role | Get User Assigned Role List
[**ListUserRoles**](RoleManagementApi.md#listuserroles) | **GET** /restapi/v1.0/account/{accountId}/user-role | Get Account User Role List
[**ReadDefaultRole**](RoleManagementApi.md#readdefaultrole) | **GET** /restapi/v1.0/account/{accountId}/user-role/default | Get Default User Role
[**ReadStandardUserRole**](RoleManagementApi.md#readstandarduserrole) | **GET** /restapi/v1.0/dictionary/user-role/{roleId} | Get Standard User Role
[**ReadUserRole**](RoleManagementApi.md#readuserrole) | **GET** /restapi/v1.0/account/{accountId}/user-role/{roleId} | Get User Role
[**UpdateDefaultUserRole**](RoleManagementApi.md#updatedefaultuserrole) | **PUT** /restapi/v1.0/account/{accountId}/user-role/default | Set Default User Role
[**UpdateUserAssignedRoles**](RoleManagementApi.md#updateuserassignedroles) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/assigned-role | Update User Assigned Roles
[**UpdateUserRole**](RoleManagementApi.md#updateuserrole) | **PUT** /restapi/v1.0/account/{accountId}/user-role/{roleId} | Update User Role



## AssignDefaultRole

> AssignedRolesResource AssignDefaultRole (string extensionId, string accountId)

Assign Default Role

Assigns the default role to the currently logged-in user extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignDefaultRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Assign Default Role
                AssignedRolesResource result = apiInstance.AssignDefaultRole(extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.AssignDefaultRole: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**AssignedRolesResource**](AssignedRolesResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Assigned Roles Resource |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AssignMultipleUserRoles

> void AssignMultipleUserRoles (string roleId, string accountId, BulkRoleAssignResource bulkRoleAssignResource = null)

Assign Multiple User Roles

Assigns multiple user roles.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignMultipleUserRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var roleId = "roleId_example";  // string | Internal identifier of a role
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var bulkRoleAssignResource = new BulkRoleAssignResource(); // BulkRoleAssignResource |  (optional) 

            try
            {
                // Assign Multiple User Roles
                apiInstance.AssignMultipleUserRoles(roleId, accountId, bulkRoleAssignResource);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.AssignMultipleUserRoles: " + e.Message );
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
 **roleId** | **string**| Internal identifier of a role | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **bulkRoleAssignResource** | [**BulkRoleAssignResource**](BulkRoleAssignResource.md)|  | [optional] 

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


## CreateCustomRole

> void CreateCustomRole (string accountId, RoleResource roleResource = null)

Create Custom Role

Creates custom user role.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCustomRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var roleResource = new RoleResource(); // RoleResource |  (optional) 

            try
            {
                // Create Custom Role
                apiInstance.CreateCustomRole(accountId, roleResource);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.CreateCustomRole: " + e.Message );
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
 **roleResource** | [**RoleResource**](RoleResource.md)|  | [optional] 

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


## DeleteCustomRole

> void DeleteCustomRole (string roleId, string accountId, bool? validateOnly = null)

Delete Custom Role

Deletes custom user role by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCustomRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var roleId = "roleId_example";  // string | 
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var validateOnly = true;  // bool? | Specifies that role should be validated prior to deletion whether it can be deleted or not (optional) 

            try
            {
                // Delete Custom Role
                apiInstance.DeleteCustomRole(roleId, accountId, validateOnly);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.DeleteCustomRole: " + e.Message );
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
 **roleId** | **string**|  | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **validateOnly** | **bool?**| Specifies that role should be validated prior to deletion whether it can be deleted or not | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAssignedRoles

> ExtensionWithRolesCollectionResource ListAssignedRoles (string accountId, bool? showHidden = null)

Get Assigned Role List

Returns the list of assigned roles for the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAssignedRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var showHidden = true;  // bool? |  (optional) 

            try
            {
                // Get Assigned Role List
                ExtensionWithRolesCollectionResource result = apiInstance.ListAssignedRoles(accountId, showHidden);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ListAssignedRoles: " + e.Message );
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
 **showHidden** | **bool?**|  | [optional] 

### Return type

[**ExtensionWithRolesCollectionResource**](ExtensionWithRolesCollectionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListStandardUserRole

> RolesCollectionResource ListStandardUserRole (string page = null, string perPage = null, string servicePlanId = null)

Get Standard User Role List

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListStandardUserRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var page = "\"1\"";  // string |  (optional)  (default to "1")
            var perPage = "\"100\"";  // string |  (optional)  (default to "100")
            var servicePlanId = "servicePlanId_example";  // string |  (optional) 

            try
            {
                // Get Standard User Role List
                RolesCollectionResource result = apiInstance.ListStandardUserRole(page, perPage, servicePlanId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ListStandardUserRole: " + e.Message );
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

[**RolesCollectionResource**](RolesCollectionResource.md)

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


## ListUserAssignedRoles

> AssignedRolesResource ListUserAssignedRoles (string extensionId, string accountId, bool? showHidden = null)

Get User Assigned Role List

Returns the list of roles assigned to the current extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListUserAssignedRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var showHidden = true;  // bool? |  (optional) 

            try
            {
                // Get User Assigned Role List
                AssignedRolesResource result = apiInstance.ListUserAssignedRoles(extensionId, accountId, showHidden);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ListUserAssignedRoles: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **showHidden** | **bool?**|  | [optional] 

### Return type

[**AssignedRolesResource**](AssignedRolesResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Assigned Roles List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListUserRoles

> RolesCollectionResource ListUserRoles (string accountId, bool? custom = null, string page = null, string perPage = null)

Get Account User Role List

Returns the list of account user roles.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListUserRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var custom = true;  // bool? | Specifies whether to return custom or predefined only roles. If not specified, all roles are returned (optional) 
            var page = "\"1\"";  // string |  (optional)  (default to "1")
            var perPage = "\"100\"";  // string |  (optional)  (default to "100")

            try
            {
                // Get Account User Role List
                RolesCollectionResource result = apiInstance.ListUserRoles(accountId, custom, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ListUserRoles: " + e.Message );
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
 **custom** | **bool?**| Specifies whether to return custom or predefined only roles. If not specified, all roles are returned | [optional] 
 **page** | **string**|  | [optional] [default to &quot;1&quot;]
 **perPage** | **string**|  | [optional] [default to &quot;100&quot;]

### Return type

[**RolesCollectionResource**](RolesCollectionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account User Role List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadDefaultRole

> void ReadDefaultRole (string accountId)

Get Default User Role

Returns account default user role.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadDefaultRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Default User Role
                apiInstance.ReadDefaultRole(accountId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ReadDefaultRole: " + e.Message );
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
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadStandardUserRole

> RoleResource ReadStandardUserRole (string roleId)

Get Standard User Role

Returns standard user role.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadStandardUserRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var roleId = "roleId_example";  // string | 

            try
            {
                // Get Standard User Role
                RoleResource result = apiInstance.ReadStandardUserRole(roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ReadStandardUserRole: " + e.Message );
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
 **roleId** | **string**|  | 

### Return type

[**RoleResource**](RoleResource.md)

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


## ReadUserRole

> RoleResource ReadUserRole (string roleId, string accountId)

Get User Role

Returns a user role on the current account by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var roleId = "roleId_example";  // string | 
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get User Role
                RoleResource result = apiInstance.ReadUserRole(roleId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.ReadUserRole: " + e.Message );
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
 **roleId** | **string**|  | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateDefaultUserRole

> void UpdateDefaultUserRole (string accountId, DefaultUserRoleRequest defaultUserRoleRequest)

Set Default User Role

Updates account default user role.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateDefaultUserRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var defaultUserRoleRequest = new DefaultUserRoleRequest(); // DefaultUserRoleRequest | JSON body

            try
            {
                // Set Default User Role
                apiInstance.UpdateDefaultUserRole(accountId, defaultUserRoleRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.UpdateDefaultUserRole: " + e.Message );
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
 **defaultUserRoleRequest** | [**DefaultUserRoleRequest**](DefaultUserRoleRequest.md)| JSON body | 

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


## UpdateUserAssignedRoles

> AssignedRolesResource UpdateUserAssignedRoles (string extensionId, string accountId, AssignedRolesResource assignedRolesResource = null)

Update User Assigned Roles

Updates the list of assigned roles for the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserAssignedRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var assignedRolesResource = new AssignedRolesResource(); // AssignedRolesResource |  (optional) 

            try
            {
                // Update User Assigned Roles
                AssignedRolesResource result = apiInstance.UpdateUserAssignedRoles(extensionId, accountId, assignedRolesResource);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.UpdateUserAssignedRoles: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **assignedRolesResource** | [**AssignedRolesResource**](AssignedRolesResource.md)|  | [optional] 

### Return type

[**AssignedRolesResource**](AssignedRolesResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUserRole

> void UpdateUserRole (string roleId, string accountId, RoleResource roleResource = null)

Update User Role

Updates a user role on the current account by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleManagementApi(Configuration.Default);
            var roleId = "roleId_example";  // string | 
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var roleResource = new RoleResource(); // RoleResource |  (optional) 

            try
            {
                // Update User Role
                apiInstance.UpdateUserRole(roleId, accountId, roleResource);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoleManagementApi.UpdateUserRole: " + e.Message );
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
 **roleId** | **string**|  | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **roleResource** | [**RoleResource**](RoleResource.md)|  | [optional] 

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

