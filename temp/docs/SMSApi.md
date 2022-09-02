# Org.OpenAPITools.Api.SMSApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMMS**](SMSApi.md#createmms) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/mms | Send MMS
[**CreateSMSMessage**](SMSApi.md#createsmsmessage) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/sms | Send SMS



## CreateMMS

> GetSMSMessageInfoResponse CreateMMS (string accountId, string extensionId, MessageStoreCallerInfoRequest from, List<MessageStoreCallerInfoRequest> to, List<System.IO.Stream> attachments, string text = null, MessageCountryInfo country = null)

Send MMS

Creates and sends media messages. Sending MMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateMMSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SMSApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var from = new MessageStoreCallerInfoRequest(); // MessageStoreCallerInfoRequest | 
            var to = new List<MessageStoreCallerInfoRequest>(); // List<MessageStoreCallerInfoRequest> | Message receiver(s) information. The `phoneNumber` value is required
            var attachments = new List<System.IO.Stream>(); // List<System.IO.Stream> | Media file(s) to upload
            var text = "text_example";  // string | Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols (optional) 
            var country = new MessageCountryInfo(); // MessageCountryInfo |  (optional) 

            try
            {
                // Send MMS
                GetSMSMessageInfoResponse result = apiInstance.CreateMMS(accountId, extensionId, from, to, attachments, text, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SMSApi.CreateMMS: " + e.Message );
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
 **from** | [**MessageStoreCallerInfoRequest**](MessageStoreCallerInfoRequest.md)|  | 
 **to** | [**List&lt;MessageStoreCallerInfoRequest&gt;**](MessageStoreCallerInfoRequest.md)| Message receiver(s) information. The &#x60;phoneNumber&#x60; value is required | 
 **attachments** | [**List&lt;System.IO.Stream&gt;**](System.IO.Stream.md)| Media file(s) to upload | 
 **text** | **string**| Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols | [optional] 
 **country** | [**MessageCountryInfo**](MessageCountryInfo.md)|  | [optional] 

### Return type

[**GetSMSMessageInfoResponse**](GetSMSMessageInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/mixed, multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | MMS Message |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSMSMessage

> GetSMSMessageInfoResponse CreateSMSMessage (string accountId, string extensionId, CreateSMSMessage createSMSMessage)

Send SMS

Creates and sends a new text message. You can send SMS messages simultaneously to different recipients up to 40 requests per minute; this limitation is relevant for all client applications. Sending and receiving SMS is available for Toll-Free Numbers within the USA. You can send up to 10 attachments in one MMS message; the size of all attachments linked is limited to 1500000 bytes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSMSMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SMSApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var createSMSMessage = new CreateSMSMessage(); // CreateSMSMessage | JSON body

            try
            {
                // Send SMS
                GetSMSMessageInfoResponse result = apiInstance.CreateSMSMessage(accountId, extensionId, createSMSMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SMSApi.CreateSMSMessage: " + e.Message );
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
 **createSMSMessage** | [**CreateSMSMessage**](CreateSMSMessage.md)| JSON body | 

### Return type

[**GetSMSMessageInfoResponse**](GetSMSMessageInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json, multipart/mixed, multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

