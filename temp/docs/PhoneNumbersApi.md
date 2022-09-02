# Org.OpenAPITools.Api.PhoneNumbersApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAccountPhoneNumbers**](PhoneNumbersApi.md#listaccountphonenumbers) | **GET** /restapi/v1.0/account/{accountId}/phone-number | Get Company Phone Number List
[**ListExtensionPhoneNumbers**](PhoneNumbersApi.md#listextensionphonenumbers) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number | Get Extension Phone Number List
[**ParsePhoneNumber**](PhoneNumbersApi.md#parsephonenumber) | **POST** /restapi/v1.0/number-parser/parse | Parse Phone Number
[**ReadAccountPhoneNumber**](PhoneNumbersApi.md#readaccountphonenumber) | **GET** /restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId} | Get Phone Number



## ListAccountPhoneNumbers

> AccountPhoneNumbers ListAccountPhoneNumbers (string accountId, int? page = null, int? perPage = null, List<string> usageType = null, string status = null)

Get Company Phone Number List

Returns the list of phone numbers assigned to RingCentral customer account. Both company-level and extension-level numbers are returned.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAccountPhoneNumbersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneNumbersApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var usageType = new List<string>(); // List<string> | Usage type of a phone number (optional) 
            var status = "Normal";  // string | Status of a phone number. Multiple values are supported (optional) 

            try
            {
                // Get Company Phone Number List
                AccountPhoneNumbers result = apiInstance.ListAccountPhoneNumbers(accountId, page, perPage, usageType, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneNumbersApi.ListAccountPhoneNumbers: " + e.Message );
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
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **usageType** | [**List&lt;string&gt;**](string.md)| Usage type of a phone number | [optional] 
 **status** | **string**| Status of a phone number. Multiple values are supported | [optional] 

### Return type

[**AccountPhoneNumbers**](AccountPhoneNumbers.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListExtensionPhoneNumbers

> GetExtensionPhoneNumbersResponse ListExtensionPhoneNumbers (string accountId, string extensionId, string status = null, List<string> usageType = null, int? page = null, int? perPage = null)

Get Extension Phone Number List

Returns the list of phone numbers that are used by a particular extension, and can be filtered by the phone number type. The returned list contains all numbers which are directly mapped to a given extension plus the features and also company-level numbers which may be used when performing different operations on behalf of this extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListExtensionPhoneNumbersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneNumbersApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var status = "Normal";  // string | Status of a phone number. Multiple values are supported (optional) 
            var usageType = new List<string>(); // List<string> | Usage type of a phone number (optional) 
            var page = 56;  // int? | Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1' (optional) 
            var perPage = 56;  // int? | Indicates the page size (number of items). If not specified, the value is '100' by default (optional) 

            try
            {
                // Get Extension Phone Number List
                GetExtensionPhoneNumbersResponse result = apiInstance.ListExtensionPhoneNumbers(accountId, extensionId, status, usageType, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneNumbersApi.ListExtensionPhoneNumbers: " + e.Message );
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
 **status** | **string**| Status of a phone number. Multiple values are supported | [optional] 
 **usageType** | [**List&lt;string&gt;**](string.md)| Usage type of a phone number | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; | [optional] 
 **perPage** | **int?**| Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default | [optional] 

### Return type

[**GetExtensionPhoneNumbersResponse**](GetExtensionPhoneNumbersResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: User Phone Number List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ParsePhoneNumber

> ParsePhoneNumberResponse ParsePhoneNumber (ParsePhoneNumberRequest parsePhoneNumberRequest, string homeCountry = null, bool? nationalAsPriority = null)

Parse Phone Number

Returns one or more parsed and/or formatted phone numbers that are passed as a string.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ParsePhoneNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneNumbersApi(Configuration.Default);
            var parsePhoneNumberRequest = new ParsePhoneNumberRequest(); // ParsePhoneNumberRequest | JSON body
            var homeCountry = "homeCountry_example";  // string | Internal identifier of a home country. The default value is ISO code (ISO 3166) of the user's home country or brand country, if the user is undefined (optional) 
            var nationalAsPriority = true;  // bool? | The default value is 'False'. If 'True', the numbers that are closer to the home country are given higher priority (optional) 

            try
            {
                // Parse Phone Number
                ParsePhoneNumberResponse result = apiInstance.ParsePhoneNumber(parsePhoneNumberRequest, homeCountry, nationalAsPriority);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneNumbersApi.ParsePhoneNumber: " + e.Message );
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
 **parsePhoneNumberRequest** | [**ParsePhoneNumberRequest**](ParsePhoneNumberRequest.md)| JSON body | 
 **homeCountry** | **string**| Internal identifier of a home country. The default value is ISO code (ISO 3166) of the user&#39;s home country or brand country, if the user is undefined | [optional] 
 **nationalAsPriority** | **bool?**| The default value is &#39;False&#39;. If &#39;True&#39;, the numbers that are closer to the home country are given higher priority | [optional] 

### Return type

[**ParsePhoneNumberResponse**](ParsePhoneNumberResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadAccountPhoneNumber

> CompanyPhoneNumberInfo ReadAccountPhoneNumber (string accountId, long phoneNumberId)

Get Phone Number

Returns the phone number(s) belonging to a certain account or extension by phoneNumberId(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAccountPhoneNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneNumbersApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var phoneNumberId = 789L;  // long | Internal identifier of a phone number

            try
            {
                // Get Phone Number
                CompanyPhoneNumberInfo result = apiInstance.ReadAccountPhoneNumber(accountId, phoneNumberId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneNumbersApi.ReadAccountPhoneNumber: " + e.Message );
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
 **phoneNumberId** | **long**| Internal identifier of a phone number | 

### Return type

[**CompanyPhoneNumberInfo**](CompanyPhoneNumberInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

