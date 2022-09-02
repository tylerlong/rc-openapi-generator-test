# Org.OpenAPITools.Api.CallBlockingApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBlockedAllowedNumber**](CallBlockingApi.md#createblockedallowednumber) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers | Add Blocked/Allowed Number
[**DeleteBlockedAllowedNumber**](CallBlockingApi.md#deleteblockedallowednumber) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId} | Delete Blocked/Allowed Number
[**ListBlockedAllowedNumbers**](CallBlockingApi.md#listblockedallowednumbers) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers | Get Blocked/Allowed Phone Numbers
[**ReadBlockedAllowedNumber**](CallBlockingApi.md#readblockedallowednumber) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId} | Get Blocked/Allowed Number
[**ReadCallerBlockingSettings**](CallBlockingApi.md#readcallerblockingsettings) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking | Get Caller Blocking Settings
[**UpdateBlockedAllowedNumber**](CallBlockingApi.md#updateblockedallowednumber) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId} | Update Blocked/Allowed Number
[**UpdateCallerBlockingSettings**](CallBlockingApi.md#updatecallerblockingsettings) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking | Update Caller Blocking Settings



## CreateBlockedAllowedNumber

> BlockedAllowedPhoneNumberInfo CreateBlockedAllowedNumber (string accountId, string extensionId, AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber)

Add Blocked/Allowed Number

Updates either blocked or allowed phone number list with a new phone number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBlockedAllowedNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 
            var addBlockedAllowedPhoneNumber = new AddBlockedAllowedPhoneNumber(); // AddBlockedAllowedPhoneNumber | JSON body

            try
            {
                // Add Blocked/Allowed Number
                BlockedAllowedPhoneNumberInfo result = apiInstance.CreateBlockedAllowedNumber(accountId, extensionId, addBlockedAllowedPhoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.CreateBlockedAllowedNumber: " + e.Message );
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
 **extensionId** | **string**|  | 
 **addBlockedAllowedPhoneNumber** | [**AddBlockedAllowedPhoneNumber**](AddBlockedAllowedPhoneNumber.md)| JSON body | 

### Return type

[**BlockedAllowedPhoneNumberInfo**](BlockedAllowedPhoneNumberInfo.md)

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


## DeleteBlockedAllowedNumber

> void DeleteBlockedAllowedNumber (string accountId, string extensionId, string blockedNumberId)

Delete Blocked/Allowed Number

Deletes blocked or allowed phone number(s) by their ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteBlockedAllowedNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 
            var blockedNumberId = "blockedNumberId_example";  // string | 

            try
            {
                // Delete Blocked/Allowed Number
                apiInstance.DeleteBlockedAllowedNumber(accountId, extensionId, blockedNumberId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.DeleteBlockedAllowedNumber: " + e.Message );
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
 **extensionId** | **string**|  | 
 **blockedNumberId** | **string**|  | 

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


## ListBlockedAllowedNumbers

> BlockedAllowedPhoneNumbersList ListBlockedAllowedNumbers (string accountId, string extensionId, int? page = null, int? perPage = null, string status = null)

Get Blocked/Allowed Phone Numbers

Returns the lists of blocked and allowed phone numbers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListBlockedAllowedNumbersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 
            var status = "Blocked";  // string |  (optional) 

            try
            {
                // Get Blocked/Allowed Phone Numbers
                BlockedAllowedPhoneNumbersList result = apiInstance.ListBlockedAllowedNumbers(accountId, extensionId, page, perPage, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.ListBlockedAllowedNumbers: " + e.Message );
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
 **extensionId** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **perPage** | **int?**|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**BlockedAllowedPhoneNumbersList**](BlockedAllowedPhoneNumbersList.md)

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


## ReadBlockedAllowedNumber

> BlockedAllowedPhoneNumberInfo ReadBlockedAllowedNumber (string accountId, string extensionId, string blockedNumberId)

Get Blocked/Allowed Number

Returns blocked or allowed phone number(s) by their ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadBlockedAllowedNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 
            var blockedNumberId = "blockedNumberId_example";  // string | 

            try
            {
                // Get Blocked/Allowed Number
                BlockedAllowedPhoneNumberInfo result = apiInstance.ReadBlockedAllowedNumber(accountId, extensionId, blockedNumberId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.ReadBlockedAllowedNumber: " + e.Message );
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
 **extensionId** | **string**|  | 
 **blockedNumberId** | **string**|  | 

### Return type

[**BlockedAllowedPhoneNumberInfo**](BlockedAllowedPhoneNumberInfo.md)

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


## ReadCallerBlockingSettings

> CallerBlockingSettings ReadCallerBlockingSettings (string accountId, string extensionId)

Get Caller Blocking Settings

Returns the current caller blocking settings of a user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallerBlockingSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 

            try
            {
                // Get Caller Blocking Settings
                CallerBlockingSettings result = apiInstance.ReadCallerBlockingSettings(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.ReadCallerBlockingSettings: " + e.Message );
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
 **extensionId** | **string**|  | 

### Return type

[**CallerBlockingSettings**](CallerBlockingSettings.md)

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


## UpdateBlockedAllowedNumber

> BlockedAllowedPhoneNumberInfo UpdateBlockedAllowedNumber (string accountId, string extensionId, string blockedNumberId, AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber = null)

Update Blocked/Allowed Number

Updates blocked or allowed phone number(s) by their ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateBlockedAllowedNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 
            var blockedNumberId = "blockedNumberId_example";  // string | 
            var addBlockedAllowedPhoneNumber = new AddBlockedAllowedPhoneNumber(); // AddBlockedAllowedPhoneNumber |  (optional) 

            try
            {
                // Update Blocked/Allowed Number
                BlockedAllowedPhoneNumberInfo result = apiInstance.UpdateBlockedAllowedNumber(accountId, extensionId, blockedNumberId, addBlockedAllowedPhoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.UpdateBlockedAllowedNumber: " + e.Message );
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
 **extensionId** | **string**|  | 
 **blockedNumberId** | **string**|  | 
 **addBlockedAllowedPhoneNumber** | [**AddBlockedAllowedPhoneNumber**](AddBlockedAllowedPhoneNumber.md)|  | [optional] 

### Return type

[**BlockedAllowedPhoneNumberInfo**](BlockedAllowedPhoneNumberInfo.md)

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


## UpdateCallerBlockingSettings

> CallerBlockingSettings UpdateCallerBlockingSettings (string accountId, string extensionId, CallerBlockingSettingsUpdate callerBlockingSettingsUpdate = null)

Update Caller Blocking Settings

Updates the current caller blocking settings of a user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallerBlockingSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallBlockingApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "extensionId_example";  // string | 
            var callerBlockingSettingsUpdate = new CallerBlockingSettingsUpdate(); // CallerBlockingSettingsUpdate |  (optional) 

            try
            {
                // Update Caller Blocking Settings
                CallerBlockingSettings result = apiInstance.UpdateCallerBlockingSettings(accountId, extensionId, callerBlockingSettingsUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallBlockingApi.UpdateCallerBlockingSettings: " + e.Message );
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
 **extensionId** | **string**|  | 
 **callerBlockingSettingsUpdate** | [**CallerBlockingSettingsUpdate**](CallerBlockingSettingsUpdate.md)|  | [optional] 

### Return type

[**CallerBlockingSettings**](CallerBlockingSettings.md)

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

