# Org.OpenAPITools.Api.FeaturesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReadUserFeatures**](FeaturesApi.md#readuserfeatures) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/features | Get User Features



## ReadUserFeatures

> FeatureList ReadUserFeatures (string accountId, string extensionId, bool? availableOnly = null, List<string> featureId = null)

Get User Features

Returns the list of supported features and information on their availability for the current extension. Specific feature(s) might be checked by providing `featureId` query param. Multiple values supported, format: `?featureId=Feature1&featureId=Feature2`. To get only available features in order to decrease response size, `availableOnly=true` query param might be specified. In case the feature is available for the current user, `\"available\": true` is returned in the response for the record with corresponding feature `id`. Otherwise, additional attribute `reason` is returned with the appropriate code: * `ServicePlanLimitation` - the feature not included to the account service plan; * `AccountLimitation` - the feature is turned off for the account; * `ExtensionTypeLimitation` - the feature is not applicable for the extension type; * `ExtensionLimitation` - the feature is not available for the extension, e.g., additional license required; * `InsufficientPermissions` - required permission not granted to the current user (not the one, who is specified in the URL, but the one who's access token is used); * `ConfigurationLimitation` - the feature is turned off for the extension, e.g., by the account administrator.  Also, some feature may have some additional parameters, e.g., limits, which are returned in `params` attribute as a name-value collection:      {       \"id\": \"HUD\",       \"available\": true,       \"params\": [         {           \"name\": \"limitMax\",           \"value\": \"100\"         }       ]     }

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserFeaturesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeaturesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var availableOnly = false;  // bool? |  (optional)  (default to false)
            var featureId = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get User Features
                FeatureList result = apiInstance.ReadUserFeatures(accountId, extensionId, availableOnly, featureId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeaturesApi.ReadUserFeatures: " + e.Message );
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
 **availableOnly** | **bool?**|  | [optional] [default to false]
 **featureId** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**FeatureList**](FeatureList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Feature List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

