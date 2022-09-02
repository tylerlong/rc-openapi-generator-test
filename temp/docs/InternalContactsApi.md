# Org.OpenAPITools.Api.InternalContactsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDirectoryEntries**](InternalContactsApi.md#listdirectoryentries) | **GET** /restapi/v1.0/account/{accountId}/directory/entries | Get Company Directory Entries
[**ReadAccountFederation**](InternalContactsApi.md#readaccountfederation) | **GET** /restapi/v1.0/account/{accountId}/directory/federation | Get Account Federation
[**ReadDirectoryEntry**](InternalContactsApi.md#readdirectoryentry) | **GET** /restapi/v1.0/account/{accountId}/directory/entries/{entryId} | Get Corporate Directory Entry
[**SearchDirectoryEntries**](InternalContactsApi.md#searchdirectoryentries) | **POST** /restapi/v1.0/account/{accountId}/directory/entries/search | Search Company Directory Entries



## ListDirectoryEntries

> DirectoryResource ListDirectoryEntries (string accountId, bool? showFederated = null, string type = null, string page = null, int? perPage = null, string siteId = null, string ifNoneMatch = null)

Get Company Directory Entries

Returns contact information on corporate users of federated accounts. Please note: 1. `User`, `DigitalUser`, `VirtualUser` and `FaxUser` types are returned as `User` type. 2. `ApplicationExtension` type is not returned. 3. Only extensions in `Enabled`, `Disabled` and `NotActivated` state are returned.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListDirectoryEntriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var showFederated = true;  // bool? | If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in this case (optional)  (default to true)
            var type = "User";  // string | Type of an extension. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology (optional) 
            var page = "\"1\"";  // string | Page number (optional)  (default to "1")
            var perPage = 1000;  // int? | Records count to be returned per one page. The default value is 1000. Specific keyword values: `all` - all records are returned in one page; `max` - maximum count of records that can be returned in one page (optional)  (default to 1000)
            var siteId = "siteId_example";  // string | Internal identifier of the business site to which extensions belong (optional) 
            var ifNoneMatch = "ifNoneMatch_example";  // string | If-None-Match (optional) 

            try
            {
                // Get Company Directory Entries
                DirectoryResource result = apiInstance.ListDirectoryEntries(accountId, showFederated, type, page, perPage, siteId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InternalContactsApi.ListDirectoryEntries: " + e.Message );
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
 **showFederated** | **bool?**| If &#39;True&#39; then contacts of all accounts in federation are returned. If &#39;False&#39; then only contacts of the current account are returned, and account section is eliminated in this case | [optional] [default to true]
 **type** | **string**| Type of an extension. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology | [optional] 
 **page** | **string**| Page number | [optional] [default to &quot;1&quot;]
 **perPage** | **int?**| Records count to be returned per one page. The default value is 1000. Specific keyword values: &#x60;all&#x60; - all records are returned in one page; &#x60;max&#x60; - maximum count of records that can be returned in one page | [optional] [default to 1000]
 **siteId** | **string**| Internal identifier of the business site to which extensions belong | [optional] 
 **ifNoneMatch** | **string**| If-None-Match | [optional] 

### Return type

[**DirectoryResource**](DirectoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paged collection of all contacts information for a given account. Records can be empty if no data found. |  -  |
| **400** | Current request cannot be processed due to error in its body and/or url. |  -  |
| **500** | Some unexpected error during current request processing. |  -  |
| **503** | Network error during request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadAccountFederation

> FederationResource ReadAccountFederation (string accountId, string rCExtensionId = null)

Get Account Federation

Returns information on a federation and associated accounts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAccountFederationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var rCExtensionId = "rCExtensionId_example";  // string | RCExtensionId (optional) 

            try
            {
                // Get Account Federation
                FederationResource result = apiInstance.ReadAccountFederation(accountId, rCExtensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InternalContactsApi.ReadAccountFederation: " + e.Message );
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
 **rCExtensionId** | **string**| RCExtensionId | [optional] 

### Return type

[**FederationResource**](FederationResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of found federations. Records array can be empty if no data found |  -  |
| **400** | Current request cannot be processed due to error in its body and/or url |  -  |
| **500** | Some unexpected error during current request processing. |  -  |
| **503** | Network error during request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadDirectoryEntry

> ContactResource ReadDirectoryEntry (string entryId, string accountId)

Get Corporate Directory Entry

Returns contact information on a particular corporate user of a federated account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadDirectoryEntryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InternalContactsApi(Configuration.Default);
            var entryId = "entryId_example";  // string | Internal identifier of extension to read information for
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Corporate Directory Entry
                ContactResource result = apiInstance.ReadDirectoryEntry(entryId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InternalContactsApi.ReadDirectoryEntry: " + e.Message );
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
 **entryId** | **string**| Internal identifier of extension to read information for | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**ContactResource**](ContactResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact information for given parameters. If value doesn&#39;t found then empty body will be returned |  -  |
| **400** | Current request cannot be processed due to error in its body and/or url |  -  |
| **500** | Some unexpected error during current request processing |  -  |
| **503** | Network error during request. One should check connection between ADG processing node and ADX data node |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchDirectoryEntries

> DirectoryResource SearchDirectoryEntries (string accountId, SearchDirectoryEntriesRequest searchDirectoryEntriesRequest = null)

Search Company Directory Entries

Returns contact information on corporate users of federated accounts according to the specified filtering and ordering.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchDirectoryEntriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var searchDirectoryEntriesRequest = new SearchDirectoryEntriesRequest(); // SearchDirectoryEntriesRequest |  (optional) 

            try
            {
                // Search Company Directory Entries
                DirectoryResource result = apiInstance.SearchDirectoryEntries(accountId, searchDirectoryEntriesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InternalContactsApi.SearchDirectoryEntries: " + e.Message );
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
 **searchDirectoryEntriesRequest** | [**SearchDirectoryEntriesRequest**](SearchDirectoryEntriesRequest.md)|  | [optional] 

### Return type

[**DirectoryResource**](DirectoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paged collection of all contacts information for a given account according to filtering and ordering. Records can be empty if no data found |  -  |
| **400** | Current request cannot be processed due to error in its body and/or url |  -  |
| **500** | Some unexpected error during current request processing. |  -  |
| **503** | Network error during request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

