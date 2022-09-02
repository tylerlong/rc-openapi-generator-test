# Org.OpenAPITools.Api.FaxApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFaxMessage**](FaxApi.md#createfaxmessage) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/fax | Create Fax Message
[**ListFaxCoverPages**](FaxApi.md#listfaxcoverpages) | **GET** /restapi/v1.0/dictionary/fax-cover-page | Get Fax Cover Page List



## CreateFaxMessage

> FaxResponse CreateFaxMessage (string accountId, string extensionId, System.IO.Stream attachment, List<string> to, string faxResolution = null, DateTime? sendTime = null, string isoCode = null, int? coverIndex = null, string coverPageText = null)

Create Fax Message

Creates and sends/resends a fax message. Resend can be implemented if sending has failed. Fax attachment size (both single and total) is limited to 50Mb.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateFaxMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FaxApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account (integer) or tilde (~) to indicate the account which was logged-in within the current session. (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension (integer) or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to upload
            var to = new List<string>(); // List<string> | To Phone Number
            var faxResolution = "High";  // string | Resolution of Fax (optional) 
            var sendTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Timestamp to send fax at. If not specified (current or the past), the fax is sent immediately (optional) 
            var isoCode = "isoCode_example";  // string | ISO Code. e.g UK (optional) 
            var coverIndex = 56;  // int? | Cover page identifier. If coverIndex is set to '0' (zero) cover page is not attached. For the list of available cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is attached (which is configured in 'Outbound Fax Settings') (optional) 
            var coverPageText = "coverPageText_example";  // string | Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols (optional) 

            try
            {
                // Create Fax Message
                FaxResponse result = apiInstance.CreateFaxMessage(accountId, extensionId, attachment, to, faxResolution, sendTime, isoCode, coverIndex, coverPageText);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxApi.CreateFaxMessage: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account (integer) or tilde (~) to indicate the account which was logged-in within the current session. | [default to &quot;~&quot;]
 **extensionId** | **string**| Internal identifier of an extension (integer) or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **attachment** | **System.IO.Stream**| File to upload | 
 **to** | [**List&lt;string&gt;**](string.md)| To Phone Number | 
 **faxResolution** | **string**| Resolution of Fax | [optional] 
 **sendTime** | **DateTime?**| Timestamp to send fax at. If not specified (current or the past), the fax is sent immediately | [optional] 
 **isoCode** | **string**| ISO Code. e.g UK | [optional] 
 **coverIndex** | **int?**| Cover page identifier. If coverIndex is set to &#39;0&#39; (zero) cover page is not attached. For the list of available cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is attached (which is configured in &#39;Outbound Fax Settings&#39;) | [optional] 
 **coverPageText** | **string**| Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols | [optional] 

### Return type

[**FaxResponse**](FaxResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fax Message |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListFaxCoverPages

> ListFaxCoverPagesResponse ListFaxCoverPages (int? page = null, int? perPage = null)

Get Fax Cover Page List

Returns fax cover pages available for the current extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListFaxCoverPagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FaxApi(Configuration.Default);
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Fax Cover Page List
                ListFaxCoverPagesResponse result = apiInstance.ListFaxCoverPages(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxApi.ListFaxCoverPages: " + e.Message );
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
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**ListFaxCoverPagesResponse**](ListFaxCoverPagesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Fax Cover Pages |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

