# Org.OpenAPITools.Api.ProfileApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReadGlipCompany**](ProfileApi.md#readglipcompany) | **GET** /restapi/v1.0/glip/companies/{companyId} | Get Company Info
[**ReadGlipPerson**](ProfileApi.md#readglipperson) | **GET** /restapi/v1.0/glip/persons/{personId} | Get Person
[**ReadGlipPreferences**](ProfileApi.md#readglippreferences) | **GET** /restapi/v1.0/glip/preferences | Get Preferences



## ReadGlipCompany

> GlipCompany ReadGlipCompany (string companyId)

Get Company Info

Returns information about one or more companies by their IDs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipCompanyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfileApi(Configuration.Default);
            var companyId = "\"~\"";  // string | Internal identifier of an RC account/Glip company, or tilde (~) to indicate a company the current user belongs to. (default to "~")

            try
            {
                // Get Company Info
                GlipCompany result = apiInstance.ReadGlipCompany(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProfileApi.ReadGlipCompany: " + e.Message );
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
 **companyId** | **string**| Internal identifier of an RC account/Glip company, or tilde (~) to indicate a company the current user belongs to. | [default to &quot;~&quot;]

### Return type

[**GlipCompany**](GlipCompany.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, multipart/mixed


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **207** | Mixed Result |  -  |
| **403** | You do not have permissions to get such kind of information |  -  |
| **404** | Company Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipPerson

> GlipPersonInfo ReadGlipPerson (string personId)

Get Person

Returns a user or multiple users by their ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipPersonExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfileApi(Configuration.Default);
            var personId = "personId_example";  // string | Internal identifier of a user to be returned, the maximum number of IDs is 30

            try
            {
                // Get Person
                GlipPersonInfo result = apiInstance.ReadGlipPerson(personId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProfileApi.ReadGlipPerson: " + e.Message );
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
 **personId** | **string**| Internal identifier of a user to be returned, the maximum number of IDs is 30 | 

### Return type

[**GlipPersonInfo**](GlipPersonInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **207** | Mixed Result |  -  |
| **403** | You do not have permissions to get such kind of information |  -  |
| **404** | Person Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadGlipPreferences

> GlipPreferencesInfo ReadGlipPreferences ()

Get Preferences

Returns information about user preferences.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadGlipPreferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfileApi(Configuration.Default);

            try
            {
                // Get Preferences
                GlipPreferencesInfo result = apiInstance.ReadGlipPreferences();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProfileApi.ReadGlipPreferences: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**GlipPreferencesInfo**](GlipPreferencesInfo.md)

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

