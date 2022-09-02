# Org.OpenAPITools.Api.CallHandlingRulesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAnsweringRule**](CallHandlingRulesApi.md#createansweringrule) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule | Create Call Handling Rule
[**CreateCompanyAnsweringRule**](CallHandlingRulesApi.md#createcompanyansweringrule) | **POST** /restapi/v1.0/account/{accountId}/answering-rule | Create Company Call Handling Rule
[**DeleteAnsweringRule**](CallHandlingRulesApi.md#deleteansweringrule) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId} | Delete Call Handling Rule
[**DeleteCompanyAnsweringRule**](CallHandlingRulesApi.md#deletecompanyansweringrule) | **DELETE** /restapi/v1.0/account/{accountId}/answering-rule/{ruleId} | Delete Company Call Handling Rule
[**GetForwardAllCalls**](CallHandlingRulesApi.md#getforwardallcalls) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forward-all-calls | Get Forward All Calls
[**ListAnsweringRules**](CallHandlingRulesApi.md#listansweringrules) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule | Get Call Handling Rules
[**ListCompanyAnsweringRules**](CallHandlingRulesApi.md#listcompanyansweringrules) | **GET** /restapi/v1.0/account/{accountId}/answering-rule | Get Company Call Handling Rule List
[**ReadAnsweringRule**](CallHandlingRulesApi.md#readansweringrule) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId} | Get Call Handling Rule
[**ReadCompanyAnsweringRule**](CallHandlingRulesApi.md#readcompanyansweringrule) | **GET** /restapi/v1.0/account/{accountId}/answering-rule/{ruleId} | Get Company Call Handling Rule
[**UpdateAnsweringRule**](CallHandlingRulesApi.md#updateansweringrule) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId} | Update Call Handling Rule
[**UpdateCompanyAnsweringRule**](CallHandlingRulesApi.md#updatecompanyansweringrule) | **PUT** /restapi/v1.0/account/{accountId}/answering-rule/{ruleId} | Update Company Call Handling Rule
[**UpdateForwardAllCalls**](CallHandlingRulesApi.md#updateforwardallcalls) | **PATCH** /restapi/v1.0/account/{accountId}/extension/{extensionId}/forward-all-calls | Update Forward All Calls



## CreateAnsweringRule

> CustomAnsweringRuleInfo CreateAnsweringRule (string accountId, string extensionId, CreateAnsweringRuleRequest createAnsweringRuleRequest)

Create Call Handling Rule

Creates a custom call handling rule for a particular caller ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var createAnsweringRuleRequest = new CreateAnsweringRuleRequest(); // CreateAnsweringRuleRequest | JSON body

            try
            {
                // Create Call Handling Rule
                CustomAnsweringRuleInfo result = apiInstance.CreateAnsweringRule(accountId, extensionId, createAnsweringRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.CreateAnsweringRule: " + e.Message );
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
 **createAnsweringRuleRequest** | [**CreateAnsweringRuleRequest**](CreateAnsweringRuleRequest.md)| JSON body | 

### Return type

[**CustomAnsweringRuleInfo**](CustomAnsweringRuleInfo.md)

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


## CreateCompanyAnsweringRule

> CompanyAnsweringRuleInfo CreateCompanyAnsweringRule (string accountId, CompanyAnsweringRuleRequest companyAnsweringRuleRequest)

Create Company Call Handling Rule

Creates call handling rule on account level.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCompanyAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var companyAnsweringRuleRequest = new CompanyAnsweringRuleRequest(); // CompanyAnsweringRuleRequest | JSON body

            try
            {
                // Create Company Call Handling Rule
                CompanyAnsweringRuleInfo result = apiInstance.CreateCompanyAnsweringRule(accountId, companyAnsweringRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.CreateCompanyAnsweringRule: " + e.Message );
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
 **companyAnsweringRuleRequest** | [**CompanyAnsweringRuleRequest**](CompanyAnsweringRuleRequest.md)| JSON body | 

### Return type

[**CompanyAnsweringRuleInfo**](CompanyAnsweringRuleInfo.md)

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


## DeleteAnsweringRule

> void DeleteAnsweringRule (string accountId, string extensionId, string ruleId)

Delete Call Handling Rule

Deletes a custom call handling rule by a particular ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ruleId = "ruleId_example";  // string | Internal identifier of an answering rule

            try
            {
                // Delete Call Handling Rule
                apiInstance.DeleteAnsweringRule(accountId, extensionId, ruleId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.DeleteAnsweringRule: " + e.Message );
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
 **ruleId** | **string**| Internal identifier of an answering rule | 

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


## DeleteCompanyAnsweringRule

> void DeleteCompanyAnsweringRule (string accountId, string ruleId)

Delete Company Call Handling Rule

Deletes a company custom call handling rule by a particular ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCompanyAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var ruleId = "ruleId_example";  // string | Internal identifier of an answering rule

            try
            {
                // Delete Company Call Handling Rule
                apiInstance.DeleteCompanyAnsweringRule(accountId, ruleId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.DeleteCompanyAnsweringRule: " + e.Message );
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
 **ruleId** | **string**| Internal identifier of an answering rule | 

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


## GetForwardAllCalls

> ForwardAllCallsInfo GetForwardAllCalls (string accountId, string extensionId)

Get Forward All Calls

Returns information about *Forward All Calls* feature setting.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetForwardAllCallsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Forward All Calls
                ForwardAllCallsInfo result = apiInstance.GetForwardAllCalls(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.GetForwardAllCalls: " + e.Message );
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

### Return type

[**ForwardAllCallsInfo**](ForwardAllCallsInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAnsweringRules

> UserAnsweringRuleList ListAnsweringRules (string accountId, string extensionId, string type = null, string view = null, bool? enabledOnly = null, string page = null, string perPage = null)

Get Call Handling Rules

Returns call handling rules of an extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAnsweringRulesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var type = "Custom";  // string | Filters custom call handling rules of the extension (optional) 
            var view = "Detailed";  // string |  (optional)  (default to Simple)
            var enabledOnly = false;  // bool? | If true, then only active call handling rules are returned (optional)  (default to false)
            var page = "\"1\"";  // string |  (optional)  (default to "1")
            var perPage = "\"100\"";  // string |  (optional)  (default to "100")

            try
            {
                // Get Call Handling Rules
                UserAnsweringRuleList result = apiInstance.ListAnsweringRules(accountId, extensionId, type, view, enabledOnly, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.ListAnsweringRules: " + e.Message );
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
 **type** | **string**| Filters custom call handling rules of the extension | [optional] 
 **view** | **string**|  | [optional] [default to Simple]
 **enabledOnly** | **bool?**| If true, then only active call handling rules are returned | [optional] [default to false]
 **page** | **string**|  | [optional] [default to &quot;1&quot;]
 **perPage** | **string**|  | [optional] [default to &quot;100&quot;]

### Return type

[**UserAnsweringRuleList**](UserAnsweringRuleList.md)

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


## ListCompanyAnsweringRules

> CompanyAnsweringRuleList ListCompanyAnsweringRules (string accountId, int? page = null, int? perPage = null)

Get Company Call Handling Rule List

Returns a list of company call handling rules.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCompanyAnsweringRulesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items per page) (optional)  (default to 100)

            try
            {
                // Get Company Call Handling Rule List
                CompanyAnsweringRuleList result = apiInstance.ListCompanyAnsweringRules(accountId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.ListCompanyAnsweringRules: " + e.Message );
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
 **perPage** | **int?**| Indicates the page size (number of items per page) | [optional] [default to 100]

### Return type

[**CompanyAnsweringRuleList**](CompanyAnsweringRuleList.md)

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


## ReadAnsweringRule

> AnsweringRuleInfo ReadAnsweringRule (string accountId, string extensionId, string ruleId, bool? showInactiveNumbers = null)

Get Call Handling Rule

Returns a call handling rule by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ruleId = "ruleId_example";  // string | Internal identifier of an answering rule. The value can be standard digital ID or specific ID - either 'business-hours-rule' or 'after-hours-rule'
            var showInactiveNumbers = false;  // bool? | Indicates whether inactive numbers should be returned or not (optional)  (default to false)

            try
            {
                // Get Call Handling Rule
                AnsweringRuleInfo result = apiInstance.ReadAnsweringRule(accountId, extensionId, ruleId, showInactiveNumbers);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.ReadAnsweringRule: " + e.Message );
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
 **ruleId** | **string**| Internal identifier of an answering rule. The value can be standard digital ID or specific ID - either &#39;business-hours-rule&#39; or &#39;after-hours-rule&#39; | 
 **showInactiveNumbers** | **bool?**| Indicates whether inactive numbers should be returned or not | [optional] [default to false]

### Return type

[**AnsweringRuleInfo**](AnsweringRuleInfo.md)

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


## ReadCompanyAnsweringRule

> CompanyAnsweringRuleInfo ReadCompanyAnsweringRule (string accountId, string ruleId)

Get Company Call Handling Rule

Returns a company call handling rule by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCompanyAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var ruleId = "ruleId_example";  // string | Internal identifier of an answering rule. The value can be standard digital ID or specific ID - either 'business-hours-rule' or 'after-hours-rule'

            try
            {
                // Get Company Call Handling Rule
                CompanyAnsweringRuleInfo result = apiInstance.ReadCompanyAnsweringRule(accountId, ruleId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.ReadCompanyAnsweringRule: " + e.Message );
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
 **ruleId** | **string**| Internal identifier of an answering rule. The value can be standard digital ID or specific ID - either &#39;business-hours-rule&#39; or &#39;after-hours-rule&#39; | 

### Return type

[**CompanyAnsweringRuleInfo**](CompanyAnsweringRuleInfo.md)

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


## UpdateAnsweringRule

> AnsweringRuleInfo UpdateAnsweringRule (string accountId, string extensionId, string ruleId, UpdateAnsweringRuleRequest updateAnsweringRuleRequest)

Update Call Handling Rule

Updates a custom call handling rule for a particular caller ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var ruleId = "ruleId_example";  // string | Internal identifier of an answering rule
            var updateAnsweringRuleRequest = new UpdateAnsweringRuleRequest(); // UpdateAnsweringRuleRequest | JSON body

            try
            {
                // Update Call Handling Rule
                AnsweringRuleInfo result = apiInstance.UpdateAnsweringRule(accountId, extensionId, ruleId, updateAnsweringRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.UpdateAnsweringRule: " + e.Message );
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
 **ruleId** | **string**| Internal identifier of an answering rule | 
 **updateAnsweringRuleRequest** | [**UpdateAnsweringRuleRequest**](UpdateAnsweringRuleRequest.md)| JSON body | 

### Return type

[**AnsweringRuleInfo**](AnsweringRuleInfo.md)

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


## UpdateCompanyAnsweringRule

> CompanyAnsweringRuleInfo UpdateCompanyAnsweringRule (string accountId, string ruleId, CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate)

Update Company Call Handling Rule

Updates a company call handling rule.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCompanyAnsweringRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var ruleId = "ruleId_example";  // string | Internal identifier of an answering rule. The value can be standard digital ID or specific ID - either 'business-hours-rule' or 'after-hours-rule'
            var companyAnsweringRuleUpdate = new CompanyAnsweringRuleUpdate(); // CompanyAnsweringRuleUpdate | JSON body

            try
            {
                // Update Company Call Handling Rule
                CompanyAnsweringRuleInfo result = apiInstance.UpdateCompanyAnsweringRule(accountId, ruleId, companyAnsweringRuleUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.UpdateCompanyAnsweringRule: " + e.Message );
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
 **ruleId** | **string**| Internal identifier of an answering rule. The value can be standard digital ID or specific ID - either &#39;business-hours-rule&#39; or &#39;after-hours-rule&#39; | 
 **companyAnsweringRuleUpdate** | [**CompanyAnsweringRuleUpdate**](CompanyAnsweringRuleUpdate.md)| JSON body | 

### Return type

[**CompanyAnsweringRuleInfo**](CompanyAnsweringRuleInfo.md)

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


## UpdateForwardAllCalls

> ForwardAllCallsInfo UpdateForwardAllCalls (string accountId, string extensionId, ForwardAllCallsInfo forwardAllCallsInfo)

Update Forward All Calls

Updates *Forward All Calls* feature setting.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateForwardAllCallsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHandlingRulesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var forwardAllCallsInfo = new ForwardAllCallsInfo(); // ForwardAllCallsInfo | JSON body

            try
            {
                // Update Forward All Calls
                ForwardAllCallsInfo result = apiInstance.UpdateForwardAllCalls(accountId, extensionId, forwardAllCallsInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallHandlingRulesApi.UpdateForwardAllCalls: " + e.Message );
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
 **forwardAllCallsInfo** | [**ForwardAllCallsInfo**](ForwardAllCallsInfo.md)| JSON body | 

### Return type

[**ForwardAllCallsInfo**](ForwardAllCallsInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

