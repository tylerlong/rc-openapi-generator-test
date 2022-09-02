# Org.OpenAPITools.Api.CustomFieldsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomField**](CustomFieldsApi.md#createcustomfield) | **POST** /restapi/v1.0/account/{accountId}/custom-fields | Create Custom Field
[**DeleteCustomField**](CustomFieldsApi.md#deletecustomfield) | **DELETE** /restapi/v1.0/account/{accountId}/custom-fields/{fieldId} | Delete Custom Field
[**ListCustomFields**](CustomFieldsApi.md#listcustomfields) | **GET** /restapi/v1.0/account/{accountId}/custom-fields | Get Custom Field List
[**UpdateCustomField**](CustomFieldsApi.md#updatecustomfield) | **PUT** /restapi/v1.0/account/{accountId}/custom-fields/{fieldId} | Update Сustom Field



## CreateCustomField

> CustomFieldResource CreateCustomField (string accountId, CustomFieldCreateRequest customFieldCreateRequest = null)

Create Custom Field

Creates custom field attached to the object.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCustomFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomFieldsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var customFieldCreateRequest = new CustomFieldCreateRequest(); // CustomFieldCreateRequest |  (optional) 

            try
            {
                // Create Custom Field
                CustomFieldResource result = apiInstance.CreateCustomField(accountId, customFieldCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomField: " + e.Message );
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
 **customFieldCreateRequest** | [**CustomFieldCreateRequest**](CustomFieldCreateRequest.md)|  | [optional] 

### Return type

[**CustomFieldResource**](CustomFieldResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom Field |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCustomField

> void DeleteCustomField (string accountId, string fieldId)

Delete Custom Field

Deletes custom field(s) by ID(s) with the corresponding values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCustomFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomFieldsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var fieldId = "fieldId_example";  // string | Custom field identifier

            try
            {
                // Delete Custom Field
                apiInstance.DeleteCustomField(accountId, fieldId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteCustomField: " + e.Message );
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
 **fieldId** | **string**| Custom field identifier | 

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


## ListCustomFields

> CustomFieldsResource ListCustomFields (string accountId)

Get Custom Field List

Returns the list of created custom fields.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCustomFieldsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomFieldsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Custom Field List
                CustomFieldsResource result = apiInstance.ListCustomFields(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListCustomFields: " + e.Message );
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

[**CustomFieldsResource**](CustomFieldsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom Field List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomField

> CustomFieldResource UpdateCustomField (string accountId, string fieldId, CustomFieldUpdateRequest customFieldUpdateRequest = null)

Update Сustom Field

Updates custom field by ID specified in path.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomFieldsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var fieldId = "fieldId_example";  // string | Custom field identifier
            var customFieldUpdateRequest = new CustomFieldUpdateRequest(); // CustomFieldUpdateRequest |  (optional) 

            try
            {
                // Update Сustom Field
                CustomFieldResource result = apiInstance.UpdateCustomField(accountId, fieldId, customFieldUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.UpdateCustomField: " + e.Message );
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
 **fieldId** | **string**| Custom field identifier | 
 **customFieldUpdateRequest** | [**CustomFieldUpdateRequest**](CustomFieldUpdateRequest.md)|  | [optional] 

### Return type

[**CustomFieldResource**](CustomFieldResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom Field |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

