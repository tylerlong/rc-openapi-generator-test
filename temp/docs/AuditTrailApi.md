# Org.OpenAPITools.Api.AuditTrailApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuditTrailSearch**](AuditTrailApi.md#audittrailsearch) | **POST** /restapi/v1.0/account/{accountId}/audit-trail/search | Search Audit Trail Data



## AuditTrailSearch

> AccountHistorySearchPublicResponse AuditTrailSearch (string accountId, AccountHistorySearchPublicRequest accountHistorySearchPublicRequest = null)

Search Audit Trail Data

Returns the audit trail data applying specific filters. Audit trail searching is limited to the last 10,000 records or last 180 days, whichever comes first.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuditTrailSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditTrailApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account to indicate the account logged-in within the current session (default to "~")
            var accountHistorySearchPublicRequest = new AccountHistorySearchPublicRequest(); // AccountHistorySearchPublicRequest | Filter (optional) 

            try
            {
                // Search Audit Trail Data
                AccountHistorySearchPublicResponse result = apiInstance.AuditTrailSearch(accountId, accountHistorySearchPublicRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuditTrailApi.AuditTrailSearch: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **accountHistorySearchPublicRequest** | [**AccountHistorySearchPublicRequest**](AccountHistorySearchPublicRequest.md)| Filter | [optional] 

### Return type

[**AccountHistorySearchPublicResponse**](AccountHistorySearchPublicResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Account History Records |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Some unexpected error during current request processing |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

