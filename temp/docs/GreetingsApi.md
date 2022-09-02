# Org.OpenAPITools.Api.GreetingsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCompanyGreeting**](GreetingsApi.md#createcompanygreeting) | **POST** /restapi/v1.0/account/{accountId}/greeting | Create Company Greeting
[**CreateCustomUserGreeting**](GreetingsApi.md#createcustomusergreeting) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting | Create Custom User Greeting
[**ListStandardGreetings**](GreetingsApi.md#liststandardgreetings) | **GET** /restapi/v1.0/dictionary/greeting | Get Standard Greeting List
[**ReadCustomGreeting**](GreetingsApi.md#readcustomgreeting) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId} | Get Custom Greeting
[**ReadStandardGreeting**](GreetingsApi.md#readstandardgreeting) | **GET** /restapi/v1.0/dictionary/greeting/{greetingId} | Get Standard Greeting



## CreateCompanyGreeting

> CustomCompanyGreetingInfo CreateCompanyGreeting (string accountId, string type, System.IO.Stream binary, string answeringRuleId = null, string languageId = null)

Create Company Greeting

Creates a custom company greeting.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCompanyGreetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GreetingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var type = "Company";  // string | Type of a greeting, specifying the case when the greeting is played.
            var binary = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Media file to upload
            var answeringRuleId = "answeringRuleId_example";  // string | Internal identifier of an answering rule (optional) 
            var languageId = "languageId_example";  // string | Internal identifier of a language. See Get Language List (optional) 

            try
            {
                // Create Company Greeting
                CustomCompanyGreetingInfo result = apiInstance.CreateCompanyGreeting(accountId, type, binary, answeringRuleId, languageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GreetingsApi.CreateCompanyGreeting: " + e.Message );
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
 **type** | **string**| Type of a greeting, specifying the case when the greeting is played. | 
 **binary** | **System.IO.Stream**| Media file to upload | 
 **answeringRuleId** | **string**| Internal identifier of an answering rule | [optional] 
 **languageId** | **string**| Internal identifier of a language. See Get Language List | [optional] 

### Return type

[**CustomCompanyGreetingInfo**](CustomCompanyGreetingInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/mixed, multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCustomUserGreeting

> CustomUserGreetingInfo CreateCustomUserGreeting (string accountId, string extensionId, string type, System.IO.Stream binary, bool? apply = null, string answeringRuleId = null)

Create Custom User Greeting

Creates custom greeting for an extension user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCustomUserGreetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GreetingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var type = "Introductory";  // string | Type of a greeting, specifying the case when the greeting is played.
            var binary = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Media file to upload
            var apply = true;  // bool? | Specifies whether to apply an answering rule or not. If set to true then `answeringRule` parameter is mandatory. If set to false, then the answering rule is not applied even if specified (optional)  (default to true)
            var answeringRuleId = "answeringRuleId_example";  // string | Internal identifier of an answering rule (optional) 

            try
            {
                // Create Custom User Greeting
                CustomUserGreetingInfo result = apiInstance.CreateCustomUserGreeting(accountId, extensionId, type, binary, apply, answeringRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GreetingsApi.CreateCustomUserGreeting: " + e.Message );
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
 **type** | **string**| Type of a greeting, specifying the case when the greeting is played. | 
 **binary** | **System.IO.Stream**| Media file to upload | 
 **apply** | **bool?**| Specifies whether to apply an answering rule or not. If set to true then &#x60;answeringRule&#x60; parameter is mandatory. If set to false, then the answering rule is not applied even if specified | [optional] [default to true]
 **answeringRuleId** | **string**| Internal identifier of an answering rule | [optional] 

### Return type

[**CustomUserGreetingInfo**](CustomUserGreetingInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/mixed, multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListStandardGreetings

> DictionaryGreetingList ListStandardGreetings (int? page = null, int? perPage = null, string type = null, string usageType = null)

Get Standard Greeting List

Returns the list of predefined standard greetings. Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListStandardGreetingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GreetingsApi(Configuration.Default);
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted. (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items). (optional)  (default to 100)
            var type = "Introductory";  // string | Type of a greeting, specifying the case when the greeting is played (optional) 
            var usageType = "UserExtensionAnsweringRule";  // string | Usage type of a greeting, specifying if the greeting is applied for user extension or department (call queue) extension (optional) 

            try
            {
                // Get Standard Greeting List
                DictionaryGreetingList result = apiInstance.ListStandardGreetings(page, perPage, type, usageType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GreetingsApi.ListStandardGreetings: " + e.Message );
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
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted. | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items). | [optional] [default to 100]
 **type** | **string**| Type of a greeting, specifying the case when the greeting is played | [optional] 
 **usageType** | **string**| Usage type of a greeting, specifying if the greeting is applied for user extension or department (call queue) extension | [optional] 

### Return type

[**DictionaryGreetingList**](DictionaryGreetingList.md)

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


## ReadCustomGreeting

> CustomUserGreetingInfo ReadCustomGreeting (string accountId, string extensionId, long greetingId)

Get Custom Greeting

Returns a custom user greeting by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCustomGreetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GreetingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var greetingId = 789L;  // long | Internal identifier of a greeting

            try
            {
                // Get Custom Greeting
                CustomUserGreetingInfo result = apiInstance.ReadCustomGreeting(accountId, extensionId, greetingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GreetingsApi.ReadCustomGreeting: " + e.Message );
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
 **greetingId** | **long**| Internal identifier of a greeting | 

### Return type

[**CustomUserGreetingInfo**](CustomUserGreetingInfo.md)

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


## ReadStandardGreeting

> DictionaryGreetingInfo ReadStandardGreeting (string greetingId)

Get Standard Greeting

Returns a standard greeting by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadStandardGreetingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GreetingsApi(Configuration.Default);
            var greetingId = "greetingId_example";  // string | 

            try
            {
                // Get Standard Greeting
                DictionaryGreetingInfo result = apiInstance.ReadStandardGreeting(greetingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GreetingsApi.ReadStandardGreeting: " + e.Message );
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
 **greetingId** | **string**|  | 

### Return type

[**DictionaryGreetingInfo**](DictionaryGreetingInfo.md)

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

