# Org.OpenAPITools.Api.BusinessHoursApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReadCompanyBusinessHours**](BusinessHoursApi.md#readcompanybusinesshours) | **GET** /restapi/v1.0/account/{accountId}/business-hours | Get Company Business Hours
[**ReadUserBusinessHours**](BusinessHoursApi.md#readuserbusinesshours) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours | Get User Business Hours
[**UpdateCompanyBusinessHours**](BusinessHoursApi.md#updatecompanybusinesshours) | **PUT** /restapi/v1.0/account/{accountId}/business-hours | Update Company Business Hours
[**UpdateUserBusinessHours**](BusinessHoursApi.md#updateuserbusinesshours) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours | Update User Business Hours



## ReadCompanyBusinessHours

> CompanyBusinessHours ReadCompanyBusinessHours (string accountId)

Get Company Business Hours

Returns the company business hours schedule. Business hours (and After hours - all the remaining time) schedules are commonly used for setting call handling rules - `business-hours-rule` and `after-hours-rule` correspondingly.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCompanyBusinessHoursExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessHoursApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Company Business Hours
                CompanyBusinessHours result = apiInstance.ReadCompanyBusinessHours(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BusinessHoursApi.ReadCompanyBusinessHours: " + e.Message );
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

### Return type

[**CompanyBusinessHours**](CompanyBusinessHours.md)

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


## ReadUserBusinessHours

> GetUserBusinessHoursResponse ReadUserBusinessHours (string accountId, string extensionId)

Get User Business Hours

Returns the user business hours schedule. Business hours (and After hours - all the remaining time) schedules are commonly used for setting call handling rules - `business-hours-rule` and `after-hours-rule` correspondingly. **Please note:** If the user business hours are set to 'Custom hours' then a particular schedule is returned; however if set to '24 hours/7 days a week' the schedule will be empty.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserBusinessHoursExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessHoursApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get User Business Hours
                GetUserBusinessHoursResponse result = apiInstance.ReadUserBusinessHours(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BusinessHoursApi.ReadUserBusinessHours: " + e.Message );
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

[**GetUserBusinessHoursResponse**](GetUserBusinessHoursResponse.md)

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


## UpdateCompanyBusinessHours

> CompanyBusinessHours UpdateCompanyBusinessHours (string accountId, CompanyBusinessHoursUpdateRequest companyBusinessHoursUpdateRequest)

Update Company Business Hours

Updates the company business hours schedule.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCompanyBusinessHoursExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessHoursApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var companyBusinessHoursUpdateRequest = new CompanyBusinessHoursUpdateRequest(); // CompanyBusinessHoursUpdateRequest | JSON body

            try
            {
                // Update Company Business Hours
                CompanyBusinessHours result = apiInstance.UpdateCompanyBusinessHours(accountId, companyBusinessHoursUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BusinessHoursApi.UpdateCompanyBusinessHours: " + e.Message );
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
 **companyBusinessHoursUpdateRequest** | [**CompanyBusinessHoursUpdateRequest**](CompanyBusinessHoursUpdateRequest.md)| JSON body | 

### Return type

[**CompanyBusinessHours**](CompanyBusinessHours.md)

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


## UpdateUserBusinessHours

> UserBusinessHoursUpdateResponse UpdateUserBusinessHours (string accountId, string extensionId, UserBusinessHoursUpdateRequest userBusinessHoursUpdateRequest)

Update User Business Hours

Updates the user business hours schedule.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserBusinessHoursExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessHoursApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var userBusinessHoursUpdateRequest = new UserBusinessHoursUpdateRequest(); // UserBusinessHoursUpdateRequest | JSON body

            try
            {
                // Update User Business Hours
                UserBusinessHoursUpdateResponse result = apiInstance.UpdateUserBusinessHours(accountId, extensionId, userBusinessHoursUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BusinessHoursApi.UpdateUserBusinessHours: " + e.Message );
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
 **userBusinessHoursUpdateRequest** | [**UserBusinessHoursUpdateRequest**](UserBusinessHoursUpdateRequest.md)| JSON body | 

### Return type

[**UserBusinessHoursUpdateResponse**](UserBusinessHoursUpdateResponse.md)

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

