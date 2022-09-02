# Org.OpenAPITools.Api.PagerMessagesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInternalTextMessage**](PagerMessagesApi.md#createinternaltextmessage) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager | Create Internal Text Message



## CreateInternalTextMessage

> GetInternalTextMessageInfoResponse CreateInternalTextMessage (string accountId, string extensionId, CreateInternalTextMessageRequest createInternalTextMessageRequest)

Create Internal Text Message

Creates and sends an internal text message.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateInternalTextMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PagerMessagesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var createInternalTextMessageRequest = new CreateInternalTextMessageRequest(); // CreateInternalTextMessageRequest | JSON body

            try
            {
                // Create Internal Text Message
                GetInternalTextMessageInfoResponse result = apiInstance.CreateInternalTextMessage(accountId, extensionId, createInternalTextMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PagerMessagesApi.CreateInternalTextMessage: " + e.Message );
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
 **createInternalTextMessageRequest** | [**CreateInternalTextMessageRequest**](CreateInternalTextMessageRequest.md)| JSON body | 

### Return type

[**GetInternalTextMessageInfoResponse**](GetInternalTextMessageInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Text Message |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

