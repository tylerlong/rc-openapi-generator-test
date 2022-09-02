# Org.OpenAPITools.Api.CallForwardingApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateForwardingNumber**](CallForwardingApi.md#createforwardingnumber) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number | Create Forwarding Number
[**DeleteForwardingNumber**](CallForwardingApi.md#deleteforwardingnumber) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId} | Delete Forwarding Number
[**DeleteForwardingNumbers**](CallForwardingApi.md#deleteforwardingnumbers) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number | Delete Forwarding Numbers
[**ListForwardingNumbers**](CallForwardingApi.md#listforwardingnumbers) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number | Get Forwarding Number List
[**ReadForwardingNumber**](CallForwardingApi.md#readforwardingnumber) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId} | Get Forwarding Number
[**UpdateForwardingNumber**](CallForwardingApi.md#updateforwardingnumber) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId} | Update Forwarding Number



## CreateForwardingNumber

> ForwardingNumberInfo CreateForwardingNumber (string accountId, string extensionId, CreateForwardingNumberRequest createForwardingNumberRequest)

Create Forwarding Number

Adds a new forwarding number to the forwarding number list.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateForwardingNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallForwardingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var createForwardingNumberRequest = new CreateForwardingNumberRequest(); // CreateForwardingNumberRequest | JSON body

            try
            {
                // Create Forwarding Number
                ForwardingNumberInfo result = apiInstance.CreateForwardingNumber(accountId, extensionId, createForwardingNumberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallForwardingApi.CreateForwardingNumber: " + e.Message );
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
 **createForwardingNumberRequest** | [**CreateForwardingNumberRequest**](CreateForwardingNumberRequest.md)| JSON body | 

### Return type

[**ForwardingNumberInfo**](ForwardingNumberInfo.md)

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


## DeleteForwardingNumber

> void DeleteForwardingNumber (string accountId, string extensionId, string forwardingNumberId)

Delete Forwarding Number

Deletes a forwarding number from the forwarding number list by its ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteForwardingNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallForwardingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var forwardingNumberId = "forwardingNumberId_example";  // string | Internal identifier of a forwarding number

            try
            {
                // Delete Forwarding Number
                apiInstance.DeleteForwardingNumber(accountId, extensionId, forwardingNumberId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallForwardingApi.DeleteForwardingNumber: " + e.Message );
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
 **forwardingNumberId** | **string**| Internal identifier of a forwarding number | 

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
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteForwardingNumbers

> void DeleteForwardingNumbers (string accountId, string extensionId, DeleteForwardingNumbersRequest deleteForwardingNumbersRequest)

Delete Forwarding Numbers

Deletes multiple forwarding numbers from the forwarding number list by IDs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteForwardingNumbersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallForwardingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var deleteForwardingNumbersRequest = new DeleteForwardingNumbersRequest(); // DeleteForwardingNumbersRequest | JSON body

            try
            {
                // Delete Forwarding Numbers
                apiInstance.DeleteForwardingNumbers(accountId, extensionId, deleteForwardingNumbersRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallForwardingApi.DeleteForwardingNumbers: " + e.Message );
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
 **deleteForwardingNumbersRequest** | [**DeleteForwardingNumbersRequest**](DeleteForwardingNumbersRequest.md)| JSON body | 

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
| **204** | No content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListForwardingNumbers

> GetExtensionForwardingNumberListResponse ListForwardingNumbers (string accountId, string extensionId, int? page = null, int? perPage = null)

Get Forwarding Number List

Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers used for call forwarding and call flip.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListForwardingNumbersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallForwardingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted. (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items). (optional)  (default to 100)

            try
            {
                // Get Forwarding Number List
                GetExtensionForwardingNumberListResponse result = apiInstance.ListForwardingNumbers(accountId, extensionId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallForwardingApi.ListForwardingNumbers: " + e.Message );
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
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted. | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items). | [optional] [default to 100]

### Return type

[**GetExtensionForwardingNumberListResponse**](GetExtensionForwardingNumberListResponse.md)

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


## ReadForwardingNumber

> ForwardingNumberInfo ReadForwardingNumber (string forwardingNumberId, string extensionId, string accountId)

Get Forwarding Number

Returns a specific forwarding number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadForwardingNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallForwardingApi(Configuration.Default);
            var forwardingNumberId = "forwardingNumberId_example";  // string | 
            var extensionId = "extensionId_example";  // string | 
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Forwarding Number
                ForwardingNumberInfo result = apiInstance.ReadForwardingNumber(forwardingNumberId, extensionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallForwardingApi.ReadForwardingNumber: " + e.Message );
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
 **forwardingNumberId** | **string**|  | 
 **extensionId** | **string**|  | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**ForwardingNumberInfo**](ForwardingNumberInfo.md)

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


## UpdateForwardingNumber

> ForwardingNumberInfo UpdateForwardingNumber (string accountId, string extensionId, string forwardingNumberId, UpdateForwardingNumberRequest updateForwardingNumberRequest)

Update Forwarding Number

Updates the existing forwarding number from the forwarding number list.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateForwardingNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallForwardingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var forwardingNumberId = "forwardingNumberId_example";  // string | Internal identifier of a forwarding number; returned in response in the 'id' field
            var updateForwardingNumberRequest = new UpdateForwardingNumberRequest(); // UpdateForwardingNumberRequest | JSON body

            try
            {
                // Update Forwarding Number
                ForwardingNumberInfo result = apiInstance.UpdateForwardingNumber(accountId, extensionId, forwardingNumberId, updateForwardingNumberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallForwardingApi.UpdateForwardingNumber: " + e.Message );
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
 **forwardingNumberId** | **string**| Internal identifier of a forwarding number; returned in response in the &#39;id&#39; field | 
 **updateForwardingNumberRequest** | [**UpdateForwardingNumberRequest**](UpdateForwardingNumberRequest.md)| JSON body | 

### Return type

[**ForwardingNumberInfo**](ForwardingNumberInfo.md)

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

