# Org.OpenAPITools.Api.SCIMApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](SCIMApi.md#createuser) | **POST** /scim/Users | Create User
[**CreateUser2**](SCIMApi.md#createuser2) | **POST** /scim/v2/Users | Create User
[**DeleteUser2**](SCIMApi.md#deleteuser2) | **DELETE** /scim/v2/Users/{id} | Delete User
[**PatchUser2**](SCIMApi.md#patchuser2) | **PATCH** /scim/v2/Users/{id} | Update/Patch User
[**ReadServiceProviderConfig**](SCIMApi.md#readserviceproviderconfig) | **GET** /scim/ServiceProviderConfig | Get Service Provider Config
[**ReadServiceProviderConfig2**](SCIMApi.md#readserviceproviderconfig2) | **GET** /scim/v2/ServiceProviderConfig | Get Service Provider Config
[**ReadUser2**](SCIMApi.md#readuser2) | **GET** /scim/v2/Users/{id} | Get User
[**ReplaceUser2**](SCIMApi.md#replaceuser2) | **PUT** /scim/v2/Users/{id} | Update/Replace User
[**SearchViaGet**](SCIMApi.md#searchviaget) | **GET** /scim/Users | Search/List Users
[**SearchViaGet2**](SCIMApi.md#searchviaget2) | **GET** /scim/v2/Users | Search/List Users
[**SearchViaPost2**](SCIMApi.md#searchviapost2) | **POST** /scim/v2/Users/.search | Search/List Users



## CreateUser

> UserResponse CreateUser (CreateUser createUser = null)

Create User

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var createUser = new CreateUser(); // CreateUser | New user without ID (optional) 

            try
            {
                // Create User
                UserResponse result = apiInstance.CreateUser(createUser);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.CreateUser: " + e.Message );
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
 **createUser** | [**CreateUser**](CreateUser.md)| New user without ID | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json, application/scim+json
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successfully created user |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **404** | not found |  -  |
| **409** | duplicate email |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateUser2

> UserResponse CreateUser2 (CreateUser createUser = null)

Create User

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUser2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var createUser = new CreateUser(); // CreateUser | a new user without 'id' (optional) 

            try
            {
                // Create User
                UserResponse result = apiInstance.CreateUser2(createUser);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.CreateUser2: " + e.Message );
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
 **createUser** | [**CreateUser**](CreateUser.md)| a new user without &#39;id&#39; | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json, application/scim+json
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successfully created user |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **404** | not found |  -  |
| **409** | duplicate email |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteUser2

> void DeleteUser2 (string id)

Delete User

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteUser2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var id = "id_example";  // string | user id

            try
            {
                // Delete User
                apiInstance.DeleteUser2(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.DeleteUser2: " + e.Message );
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
 **id** | **string**| user id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | successfully deleted |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **404** | not found |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchUser2

> UserResponse PatchUser2 (string id, UserPatch userPatch = null)

Update/Patch User

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchUser2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var id = "id_example";  // string | user id
            var userPatch = new UserPatch(); // UserPatch | patch operations list (optional) 

            try
            {
                // Update/Patch User
                UserResponse result = apiInstance.PatchUser2(id, userPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.PatchUser2: " + e.Message );
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
 **id** | **string**| user id | 
 **userPatch** | [**UserPatch**](UserPatch.md)| patch operations list | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json, application/scim+json
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successfully partially updated user |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **404** | not found |  -  |
| **409** | duplicate email |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadServiceProviderConfig

> ServiceProviderConfig ReadServiceProviderConfig ()

Get Service Provider Config

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadServiceProviderConfigExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);

            try
            {
                // Get Service Provider Config
                ServiceProviderConfig result = apiInstance.ReadServiceProviderConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.ReadServiceProviderConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ServiceProviderConfig**](ServiceProviderConfig.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service Provider Configuration |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadServiceProviderConfig2

> ServiceProviderConfig ReadServiceProviderConfig2 ()

Get Service Provider Config

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadServiceProviderConfig2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);

            try
            {
                // Get Service Provider Config
                ServiceProviderConfig result = apiInstance.ReadServiceProviderConfig2();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.ReadServiceProviderConfig2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ServiceProviderConfig**](ServiceProviderConfig.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service Provider Configuration |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadUser2

> UserResponse ReadUser2 (string id)

Get User

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUser2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var id = "id_example";  // string | user id

            try
            {
                // Get User
                UserResponse result = apiInstance.ReadUser2(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.ReadUser2: " + e.Message );
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
 **id** | **string**| user id | 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **404** | not found |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceUser2

> UserResponse ReplaceUser2 (string id, User user = null)

Update/Replace User

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceUser2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var id = "id_example";  // string | user id
            var user = new User(); // User | an existing user (optional) 

            try
            {
                // Update/Replace User
                UserResponse result = apiInstance.ReplaceUser2(id, user);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.ReplaceUser2: " + e.Message );
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
 **id** | **string**| user id | 
 **user** | [**User**](User.md)| an existing user | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json, application/scim+json
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successfully fully updated a user |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **404** | not found |  -  |
| **409** | duplicate email |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchViaGet

> UserSearchResponse SearchViaGet (string filter = null, int? startIndex = null, int? count = null)

Search/List Users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchViaGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var filter = "filter_example";  // string | only support 'userName' or 'email' filter expressions for now (optional) 
            var startIndex = 1;  // int? | start index (1-based) (optional)  (default to 1)
            var count = 100;  // int? | page size (optional)  (default to 100)

            try
            {
                // Search/List Users
                UserSearchResponse result = apiInstance.SearchViaGet(filter, startIndex, count);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.SearchViaGet: " + e.Message );
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
 **filter** | **string**| only support &#39;userName&#39; or &#39;email&#39; filter expressions for now | [optional] 
 **startIndex** | **int?**| start index (1-based) | [optional] [default to 1]
 **count** | **int?**| page size | [optional] [default to 100]

### Return type

[**UserSearchResponse**](UserSearchResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchViaGet2

> UserSearchResponse SearchViaGet2 (string filter = null, int? startIndex = null, int? count = null)

Search/List Users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchViaGet2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var filter = "filter_example";  // string | only support 'userName' or 'email' filter expressions for now (optional) 
            var startIndex = 1;  // int? | start index (1-based) (optional)  (default to 1)
            var count = 100;  // int? | page size (optional)  (default to 100)

            try
            {
                // Search/List Users
                UserSearchResponse result = apiInstance.SearchViaGet2(filter, startIndex, count);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.SearchViaGet2: " + e.Message );
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
 **filter** | **string**| only support &#39;userName&#39; or &#39;email&#39; filter expressions for now | [optional] 
 **startIndex** | **int?**| start index (1-based) | [optional] [default to 1]
 **count** | **int?**| page size | [optional] [default to 100]

### Return type

[**UserSearchResponse**](UserSearchResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchViaPost2

> UserSearchResponse SearchViaPost2 (SearchRequest searchRequest = null)

Search/List Users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchViaPost2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi(Configuration.Default);
            var searchRequest = new SearchRequest(); // SearchRequest | search parameters (optional) 

            try
            {
                // Search/List Users
                UserSearchResponse result = apiInstance.SearchViaPost2(searchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SCIMApi.SearchViaPost2: " + e.Message );
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
 **searchRequest** | [**SearchRequest**](SearchRequest.md)| search parameters | [optional] 

### Return type

[**UserSearchResponse**](UserSearchResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json, application/scim+json
- **Accept**: application/json, application/scim+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad request |  -  |
| **401** | authorization failure |  -  |
| **403** | permissions denied |  -  |
| **429** | too many requests |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

