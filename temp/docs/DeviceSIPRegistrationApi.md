# Org.OpenAPITools.Api.DeviceSIPRegistrationApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSIPRegistration**](DeviceSIPRegistrationApi.md#createsipregistration) | **POST** /restapi/v1.0/client-info/sip-provision | Register Device



## CreateSIPRegistration

> CreateSipRegistrationResponse CreateSIPRegistration (CreateSipRegistrationRequest createSipRegistrationRequest)

Register Device

Creates SIP registration of a device/application (WebPhone, Mobile, softphone).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSIPRegistrationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceSIPRegistrationApi(Configuration.Default);
            var createSipRegistrationRequest = new CreateSipRegistrationRequest(); // CreateSipRegistrationRequest | JSON body

            try
            {
                // Register Device
                CreateSipRegistrationResponse result = apiInstance.CreateSIPRegistration(createSipRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DeviceSIPRegistrationApi.CreateSIPRegistration: " + e.Message );
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
 **createSipRegistrationRequest** | [**CreateSipRegistrationRequest**](CreateSipRegistrationRequest.md)| JSON body | 

### Return type

[**CreateSipRegistrationResponse**](CreateSipRegistrationResponse.md)

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

